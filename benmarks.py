import datetime
from dateutil.relativedelta import relativedelta
import pandas as pd
from shared_utilities import find_n_business_days_before

from .config import treasury_client, pg_client, engine, redis_connection, table_schema
from .update_secmaster import update_corporate_treasury_fields, update_derived_gov_fields, update_gov_fields


def process_df_function(df):
    output_df = df.copy()
    output_df[['bd_last_duration', 'bd_last_duration_date', 'bd_days_to_maturity']] = output_df.apply(lambda x: get_duration_fields(x['maturityDate'], x['cusip']), axis=1)
    return output_df


def get_bucket_range(bucket, start_add, end_add):
    today = datetime.datetime.now().date()
    days_to_maturity_start = 0
    days_to_maturity_end = 0
    
    if bucket == 'CT2':
        days_to_maturity_start = 366    
    else:
        start_date = datetime.datetime(today.year + start_add, 1, 1).date()
        days_to_maturity_start = (start_date - today).days
    
    if bucket == 'CT7':
        end_date = datetime.datetime(today.year + end_add, 3, 31).date()
        days_to_maturity_end = (end_date - today).days
    else:
        end_date = datetime.datetime(today.year + end_add, 12, 31).date()
        days_to_maturity_end = (end_date - today).days

    return (days_to_maturity_start, days_to_maturity_end)

CT2_RANGE = get_bucket_range('CT2', None, 2)
CT3_RANGE = get_bucket_range('CT3', 3, 3)
CT5_RANGE = get_bucket_range('CT5', 4, 6)
CT7_RANGE = get_bucket_range('CT7', 7, 8)
CT10_RANGE = get_bucket_range('CT10', 7, 15)
CT20_RANGE = get_bucket_range('CT20', 16, 23)
CT30_RANGE = get_bucket_range('CT30', 24, 7972)

BUCKET_ISSUE_DATE_CUTOFFS = {
    'CB3':270,
    'CB6':270,
    'CB12':270,
    'CT2':270,
    'CT3':270,
    'CT5':270,
    'CT7':270,
    'CT10':270,
    'CT20':270,
    'CT30':270
}

CURR_AMOUNT_OUTSTANDING_THRESHOLDS = {
    'CB3':1.20,
    'CB6':1.20,
    'CB12':1.20,
    'CT2':1.20,
    'CT3':1.20,
    'CT5':1.20,
    'CT7':1.20,
    'CT10':1.20,
    'CT20':1.20,
    'CT30':1.01    
}


def get_derived_fields(treasury):
    treasury['bd_maturityDate'] = treasury.get('maturityDate', None)
    if treasury['bd_maturityDate'] is None and treasury.get('maturityType', None) == 'Perpetual':
        treasury['bd_maturityDate'] = '2099-12-31'


    subtype = treasury['paymentCategorySubtype']

    maturityDate = treasury['bd_maturityDate']
    maturityDate2 = None
    if maturityDate:
        maturityDate = datetime.datetime.strptime(maturityDate, '%Y-%m-%d').date()
        maturityDate2 = maturityDate + datetime.timedelta(days=-1)

    endDate = None
    if ('interestSchedule' in treasury.keys()) and (type(treasury['interestSchedule']) == dict):
        endDate = treasury['interestSchedule'].get('endDate')
        if endDate:
            endDate = datetime.datetime.strptime(endDate, '%Y-%m-%d').date()

    if subtype == 'Fixed: Plain Vanilla Fixed Coupon' and ((endDate == maturityDate) or (endDate == maturityDate2)):
        treasury['bd_coupon_calc_type'] = 'PLAIN_VANILLA_FIX'

    elif ((subtype == 'Floating: Fixed Margin over Index') or (subtype == 'Floating: Floating')) and (
            (endDate == maturityDate) or ((endDate == maturityDate2))):
        treasury['bd_coupon_calc_type'] = 'PLAIN_VANILLA_FLOAT'

    elif subtype == 'Fixed: Zero Coupon':
        treasury['bd_coupon_calc_type'] = 'ZERO_COUPON'

    elif treasury['isStepper']:
        treasury['bd_coupon_calc_type'] = 'STEPPER'

    elif subtype == 'Fixed: Pay only at Maturity':
        treasury['bd_coupon_calc_type'] = 'PAY_ONLY_AT_MAT'

    else:
        treasury['bd_coupon_calc_type'] = None

    if (treasury['bd_coupon_calc_type'] in ['PLAIN_VANILLA_FIX', 'PAY_ONLY_AT_MAT']) and \
            (treasury.get('interestSchedule') is not None):
        treasury['bd_currentCoupon'] = treasury['interestSchedule'].get('coupon')

    elif treasury['bd_coupon_calc_type'] == 'ZERO_COUPON':
        treasury['bd_currentCoupon'] = 0

    elif treasury['bd_coupon_calc_type'] == 'STEPPER':
        treasury['bd_currentCoupon'] = 'STP'

    elif treasury['bd_coupon_calc_type'] == 'PLAIN_VANILLA_FLOAT':
        treasury['bd_currentCoupon'] = 'FLT'

    else:
        treasury['bd_currentCoupon'] = None

    update_derived_gov_fields(treasury)

    return treasury


def filter_for_missing_fields(treasury):
    required_fields = [
        'maturityDate',
        'currentCoupon',
        'paymentCategorySubtype',
        'isAnnuity',
        'isBondLinked',
        'isBullet',
        'isCallable',
        'isCapitalization',
        'isCommodityLinked',
        'isComplexFloater',
        'isConvertibleOrExchangeable',
        'isCorridor',
        'isCouponCummulative',
        'isCouponDeferrable',
        'isCovered',
        'isDualCurrency',
        'isEmerging',
        'isEquityLinked',
        'isFactorable',
        'isFunged',
        'isGuarantee',
        'isInflationLinked',
        'isInflationProtected',
        'isInterestIndexLinked',
        'isInterestLinked',
        'isInverseFloater',
        'isMtn',
        'isOffshore',
        'isPerpetual',
        'isPostDetermined',
        'isPrincipalIndexLinked',
        'isPuttable',
        'isRatingsSensitive',
        'isRedenominated',
        'isRegisterSensitive',
        'isStepper',
        'isTaxCall',
        'isTips',
        'hasAccretion',
        'hasAmortization',
        'hasCreditEnhancement',
        'hasEquityClawback',
        'hasExtendedTerms',
        'hasPik',
        'hasSink',
        'issueCountry',
        'issueCurrency',
        'issueDate',
        'currentAmountOutstanding',
        'issueSubType',
        'issueType',
        'statusType',
        'tier'
    ]

    for field in required_fields:
        if treasury.get(field, None) is None:
            message = 'Missing Required Field {}'.format(field)
            upload_treasury_to_rejection_table(treasury, message)
            return False

    nested = treasury.get('organizationDetails', None)
    if nested is None:
        message = 'Missing Required Field {}'.format(nested)
        upload_treasury_to_rejection_table(treasury, message)
        return False
    else:
        nested = nested.get('issuerName', None)
        if nested is None:
            message = 'Missing Required Field {}'.format(nested)
            upload_treasury_to_rejection_table(treasury, message)
            return False

    return True



def convert_string_to_date(date):
    try:
        return datetime.datetime.strptime(date, '%Y-%m-%d').date()
    except Exception as e:
        print(e)
        return None


def get_treasuries_to_update():
    treasuries = treasury_client.get_all_treasury_bonds()
    eligible_treasuries = list(treasuries)
    treasuries.close()
    eligible_treasuries = drop_nans(eligible_treasuries)
    return eligible_treasuries


def drop_nans(all_treasuries):
    universe = pd.DataFrame(all_treasuries)
    universe = universe.where(pd.notnull(universe), None)
    universe = universe.to_dict("records")

    return universe


def generate_treasury_benchmark(treasury_bond):
    ticker = None
    coupon = None
    maturity = treasury_bond.get('bd_maturityDate', None)
    if maturity is not None:
        maturity = maturity.split('-')
        tmp = maturity[0]
        maturity[0] = maturity[1]
        maturity[1] = maturity[2]
        maturity[2] = tmp
        maturity = '/'.join(maturity)
    else:
        maturity = ''

    keys = treasury_bond.keys()

    if treasury_bond.get('IssuerType', None) == 'Money Market Instrument':
        ticker = 'B'
    else:
        ticker = 'T'

    if 'currentCoupon' not in keys:
        coupon = ''
    else:
        coupon = treasury_bond['currentCoupon']

    return ticker + ' ' + str(coupon) + ' ' + maturity


def get_days_to_maturity(maturity_date):
    today = datetime.date.today()
    if maturity_date is not None:
        return (maturity_date - today).days
    else:
        return None


def order_potential_benchmarks_by_bucket(treasuries):
    bucket_benchmark_map = {
        'CB3':[],
        'CB6':[],
        'CB12':[],
        'CT2':[],
        'CT3':[],
        'CT5':[],
        'CT7':[],
        'CT10':[],
        'CT20':[],
        'CT30':[]
    }
    
    for treasury in treasuries:
        if treasury['bd_potential_benchmark'] == False:
            continue
        else:
            bucket_label = treasury['bd_consensus_benchmark']
            bucket_benchmark_map[bucket_label].append(treasury)
    
    return bucket_benchmark_map


def sort_bucket_by_target(bucket, bucket_label):
    bucket_targets = {
        'CB3':90,
        'CB6':180,
        'CB12':365,
        'CT2':730,
        'CT3':1095,
        'CT5':1825,
        'CT7':2555,
        'CT10':3650,
        'CT20':7300,
        'CT30':10950
        }

    target = bucket_targets[bucket_label]

    def sort_function(treasury):
        return (abs(treasury['bd_t_benchmark_days_to_maturity'] - target), treasury['bd_days_since_issue'])
    
    bucket.sort(key=sort_function)
    return bucket


def assign_target_maturity_rank(bucket):
    for i, treasury in enumerate(bucket):
        treasury['bd_target_maturity_rank'] = i + 1  
    return bucket


def assign_last_updated(df):
    last_update_timestamp = datetime.datetime.now().date().strftime('%Y-%m-%d')
    try:
        previous_update_value = df['bd_benchmark_last_updated']
    except Exception as e:
        print(e)
        previous_update_value = None

    benchmark = df['bd_treasury_benchmark']
    if benchmark is not None:
        return last_update_timestamp
    else:
        return previous_update_value
            

def calculate_days_since_issued(bucket):
    today = datetime.datetime.now().date()
    for treasury in bucket:
        issue_date = treasury.get('issueDate', None)
        issue_date = convert_string_to_date(issue_date)
        if issue_date == None:
            continue
        else:
            days_since_issued = (today - issue_date).days
            treasury['bd_days_since_issue'] = days_since_issued
    return bucket


def calculate_bd_issue_date_cutoff(bucket, bucket_label):
    global BUCKET_ISSUE_DATE_CUTOFFS

    minimum_days_since_issued = float('inf')
    for treasury in bucket:
        if treasury['bd_days_since_issue'] < minimum_days_since_issued:
            minimum_days_since_issued = treasury['bd_days_since_issue']
    
    return minimum_days_since_issued + BUCKET_ISSUE_DATE_CUTOFFS[bucket_label]


def assign_issue_date_cutoff_filter(bucket, cutoff):
    for treasury in bucket:
        if treasury['bd_days_since_issue'] <= cutoff:
            treasury['bd_issue_date_cutoff_filter'] = True
        else:
            treasury['bd_issue_date_cutoff_filter'] = False
    
    return bucket


def narrow_bucket_to_eligible_benchmarks(bucket):
    upper_bound = min(5, len(bucket))
    eligible_benchmarks = []
    i = 0

    while i < upper_bound:
        if bucket[i]['bd_issue_date_cutoff_filter'] == True:
            eligible_benchmarks.append(bucket[i])
        i+=1
        if len(eligible_benchmarks) == 0 and i == upper_bound:
            upper_bound += 1
    return eligible_benchmarks


def select_benchmark(bucket, bucket_label):
    global CURR_AMOUNT_OUTSTANDING_THRESHOLDS
    if len(bucket) == 1:
        return bucket[0]
    else:
        amount_outstanding = bucket[0]['currentAmountOutstanding']
        threshold = CURR_AMOUNT_OUTSTANDING_THRESHOLDS[bucket_label]
        for bond in bucket:
            if bond['currentAmountOutstanding'] > threshold * amount_outstanding:
                return bond
        return bucket[0]


def assign_maturity_bucket(bond, buckets, days_to_maturity):
    # bounds are inclusive

    if days_to_maturity < 0:
        if 'matured' in buckets:
            buckets['matured'].append(bond)
        else:
            buckets['matured'] = [bond]
    elif days_to_maturity > 0 and days_to_maturity < 121:
        if '0m_3m' in buckets:
            buckets['0m_3m'].append(bond)
        else:
            buckets['0m_3m'] = [bond]
    elif days_to_maturity > 120 and days_to_maturity < 201:
        if '3m_6m' in buckets:
            buckets['3m_6m'].append(bond)
        else:
            buckets['3m_6m'] = [bond]
    elif days_to_maturity > 200 and days_to_maturity < 401:
        if '6m_1y' in buckets:
            buckets['6m_1y'].append(bond)
        else:
            buckets['6m_1y'] = [bond]
    elif days_to_maturity > 400 and days_to_maturity < 731:
        if '1y_2y' in buckets:
            buckets['1y_2y'].append(bond)
        else:
            buckets['1y_2y'] = [bond]
    elif days_to_maturity > 730 and days_to_maturity < 1096:
        if '2y_3y' in buckets:
            buckets['2y_3y'].append(bond)
        else:
            buckets['2y_3y'] = [bond]
    elif days_to_maturity > 1095 and days_to_maturity < 1826:
        if '3y_5y' in buckets:
            buckets['3y_5y'].append(bond)
        else:
            buckets['3y_5y'] = [bond]
    elif days_to_maturity > 1825 and days_to_maturity < 2921:
        if '5y_8y' in buckets:
            buckets['5y_8y'].append(bond)
        else:
            buckets['5y_8y'] = [bond]
    elif days_to_maturity > 2920 and days_to_maturity < 5476:
        if '8y_15y' in buckets:
            buckets['8y_15y'].append(bond)
        else:
            buckets['8y_15y'] = [bond]
    elif days_to_maturity > 5475 and days_to_maturity < 8761:
        if '15y_24y' in buckets:
            buckets['15y_24y'].append(bond)
        else:
            buckets['15y_24y'] = [bond]
    else:
        if '24y' in buckets:
            buckets['24y'].append(bond)
        else:
            buckets['24y'] = [bond]

    return buckets


def assign_individual_bucket(days_to_maturity):
    if -1 < days_to_maturity < 101:
        return ('[0, 100)', 'CB3')
    elif 100 < days_to_maturity < 201:
        return ('[101, 200)', 'CB6')
    elif 200 < days_to_maturity < 401:
        return ('[201, 400)', 'CB12')
    elif 400 < days_to_maturity < 731:
        return ('[401, 730)', 'CT2')
    elif 730 < days_to_maturity < 1101:
        return ('[731, 1095)', 'CT3')
    elif 1100 < days_to_maturity < 1831:
        return ('[1096,  1825)', 'CT5')
    elif 1830 < days_to_maturity < 2921:
        return ('[1826, 2920) ', 'CT7')
    elif 2920 < days_to_maturity < 5476:
        return ('[2921, 5475)', 'CT10')
    elif 5475 < days_to_maturity < 8761:
        return ('[5476, 8760)', 'CT20')
    elif 8760 < days_to_maturity < 10000000:
        return ('[8761, 10000000)', 'CT30')
    else:
        return (None, None)


def filter_possible_otr(treasury):
    try:
        print("Traseury Issue date", treasury['issueDate'])
        issueDate = convert_string_to_date(treasury['issueDate'])
        maturityDate = convert_string_to_date(treasury['bd_maturityDate'])
        today = datetime.date.today()
        if (
                (treasury['paymentCategorySubtype'] == 'Fixed: Plain Vanilla Fixed Coupon' or
                 treasury['paymentCategorySubtype'] == 'Fixed: Zero Coupon') and
                treasury['isAnnuity'] == False and
                treasury['isBondLinked'] == False and
                treasury['isBullet'] == True and
                treasury['isCallable'] == False and
                treasury['isCapitalization'] == False and
                treasury['isCommodityLinked'] == False and
                treasury['isComplexFloater'] == False and
                treasury['isConvertibleOrExchangeable'] == 'Neither' and
                treasury['isCorridor'] == False and
                treasury['isCouponCummulative'] == False and
                treasury['isCouponDeferrable'] == False and
                treasury['isCovered'] == False and
                treasury['isDualCurrency'] == False and
                treasury['isEmerging'] == False and
                treasury['isEquityLinked'] == False and
                treasury['isFactorable'] == False and
                treasury['isFunged'] == False and
                treasury['isGuarantee'] == False and
                treasury['isInflationLinked'] == False and
                treasury['isInflationProtected'] == False and
                treasury['isInterestIndexLinked'] == False and
                treasury['isInterestLinked'] == False and
                treasury['isInverseFloater'] == False and
                (treasury['isMtn'] == False or treasury['isMtn'] == True) and
                treasury['isOffshore'] == False and
                treasury['isPerpetual'] == False and
                treasury['isPostDetermined'] == False and
                treasury['isPrincipalIndexLinked'] == False and
                treasury['isPuttable'] == False and
                treasury['isRatingsSensitive'] == False and
                treasury['isRedenominated'] == False and
                treasury['isRegisterSensitive'] == False and
                treasury['isStepper'] == False and
                treasury['isTaxCall'] == False and
                treasury['isTips'] == False and
                treasury['hasAccretion'] == False and
                treasury['hasAmortization'] == False and
                treasury['hasCreditEnhancement'] == False and
                treasury['hasEquityClawback'] == False and
                treasury['hasExtendedTerms'] == False and
                treasury['hasPik'] == False and
                treasury['hasSink'] == False and
                treasury['issueCountry'] == 'USA' and
                treasury['issueCurrency'] == 'USD' and
                (issueDate.year > 2000 and issueDate <= today) and
                (treasury.get('collateralType', None) != "N/A" or treasury.get('collateralType', None) is not None) and
                treasury['currentAmountOutstanding'] != 0 and
                (treasury['issueSubType'] == 'Bond' or treasury['issueSubType'] == 'Note' or
                 (treasury['issueSubType'] == 'Bill' and treasury['bd_t_benchmark_days_to_maturity'] < 547)) and
                (treasury['issueType'] == 'Bond' or treasury['issueType'] == 'Note' or
                 (treasury['issueType'] == 'Money Market Instrument' and treasury['bd_t_benchmark_days_to_maturity'] < 547)) and
                treasury['statusType'] == 'Active' and
                (treasury['tier'] != 'Sec' or treasury['tier'] == 'Sr Sec') and
                treasury['organizationDetails']['issuerName'] == 'United States of America' and
                treasury['bd_currentCoupon'] is not None and
                treasury['bd_maturityDate'] is not None and
                treasury['cusip'] is not None and 
                treasury['isin'] is not None and
                treasury['currentAmountOutstanding'] is not None and
                maturityDate > today):
            return True
        else:
            return False
    except KeyError as e:
        #print("Rejecting treasury bond with id " + str(treasury['bonddroid_id']) + " because of missing key " + str(e))
        # upload_treasury_to_rejection_table(treasury, str(e))
        return False
    except Exception as e:
        print('Err: ' + str(e))
        print('\n')
        return False



def get_most_recent_issues(bucket):
    newer_issue = bucket[0]
    older_issue = bucket[0]

    for treasury in bucket:
        issue_date = convert_string_to_date(treasury['issueDate'])
        newer_issue_date = convert_string_to_date(newer_issue['issueDate'])

        if issue_date > newer_issue_date:
            older_issue = newer_issue
            newer_issue = treasury

    return {'newer_issue': newer_issue, 'older_issue': older_issue}


def get_corporates_to_update():
    tc = treasury_client.get_secmaster_connection()
    corporates = tc.find({
        'bd_issueCurrency':'USD',
        '$and':[{'bd_classification':{'$ne':'Government'}}, {'bd_classification':{'$ne':None}}],
        'statusType':'Active'
        },{
        '_id': 0, 
        'bonddroid_id': 1, 
        'issueDate':1,
        'cusip': 1, 
        'maturityDate': 1,
        'bd_benchmark_last_updated':1
    })
    print("Number of corporates to update:")
    print(treasury_client.get_secmaster_connection().count_documents({
        'bd_classification':{'$ne':'Government'},
        'bd_classification':{'$ne':None},
        'statusType':'Active',
        'bd_issueCurrency':'USD'
        }))
    return corporates


def save_benchmark_data(treasuries, bucket_label):
    print('Saving {} bucket...'.format(bucket_label))
    for treasury in treasuries:
        update_gov_fields(
            treasury['bd_t_benchmark'], 
            treasury['bd_t_benchmark_days_to_maturity'], 
            treasury['bd_maturity_bucket'], 
            treasury['bd_consensus_benchmark'], 
            treasury['bd_potential_benchmark'],
            treasury['bd_otr_treasury'], 
            treasury['bonddroid_id'],
            treasury['bd_target_maturity_rank'],
            treasury['bd_days_since_issue'],
            treasury['bd_issue_date_cutoff_filter'],
            treasury['bd_classification']
            )


def get_otr(treasuries):
    bucket_benchmark_map = order_potential_benchmarks_by_bucket(treasuries)
    print(f'BUCKET BENCHMARK MAP : {bucket_benchmark_map}')
    for bucket_label, bucket in bucket_benchmark_map.items():
        bucket_benchmark_map[bucket_label] = calculate_days_since_issued(bucket_benchmark_map[bucket_label])
        bucket_benchmark_map[bucket_label] = sort_bucket_by_target(bucket, bucket_label)
        bucket_benchmark_map[bucket_label] = assign_target_maturity_rank(bucket_benchmark_map[bucket_label])
        bucket_issue_cutoff = calculate_bd_issue_date_cutoff(bucket_benchmark_map[bucket_label], bucket_label)
        bucket_benchmark_map[bucket_label] = assign_issue_date_cutoff_filter(bucket_benchmark_map[bucket_label], bucket_issue_cutoff)
        save_benchmark_data(bucket, bucket_label)
        bucket_benchmark_map[bucket_label] = narrow_bucket_to_eligible_benchmarks(bucket_benchmark_map[bucket_label])
        bucket_benchmark_map[bucket_label] = select_benchmark(bucket_benchmark_map[bucket_label], bucket_label)
    
    print(f'SAVING FOR BUCKET VALUE : Leftovers')
    print(f'FIRST TREASURY : {treasuries[0]}')
    save_benchmark_data(treasuries, 'Leftovers')
    return bucket_benchmark_map


def get_otr_manual():
    #CHANGE KEYS TO CHANGE TREASURY BONDS
    #LAST UPDATED 8/7/2022 with 7/22/2022 benchmarks
    PRE_SELECTED_TREASURIES = {
        '912796V63':'CB3',
        '912796XS3':'CB6',
        '912796XQ7':'CB12',
        '91282CEX5':'CT2',
        '91282CEY3':'CT3',
        '91282CEW7':'CT5',
        '91282CEV9':'CT7',
        '91282CEP2':'CT10',
        '912810TF5':'CT20',
        '912810TD0':'CT30'  
    }
    query = []
    for cusip,bucket in PRE_SELECTED_TREASURIES.items():
        query.append({'cusip':cusip})
    
    treasuries = treasury_client.get_secmaster_connection().find({'$or':query}, 
    {
        '_id': 0, 
        'bd_t_benchmark':1,
        'bd_t_benchmark_days_to_maturity':1, 
        'bonddroid_id': 1, 
        'cusip': 1,
        'figi': 1, 
        'isin': 1,
        'bd_maturityDate': 1, 
        'bd_consensus_benchmark':1
    })
    treasuries = list(treasuries)

    bucket_map = {}
    for treasury in treasuries:
        cusip = treasury['cusip']
        bucket = PRE_SELECTED_TREASURIES[cusip]
        bucket_map[bucket] = treasury
        
    return bucket_map

def get_duration_fields(maturity, cusip):
    corporate_days_to_maturity = get_days_to_maturity(convert_string_to_date(maturity))
    if corporate_days_to_maturity is None:
        return pd.Series([None, None, None])

    corporate_duration = None
    duration_timestamp = None
    

    if cusip is not None and corporate_days_to_maturity > 0:
        corporate_duration_byte, duration_timestamp_byte = redis_connection.hmget(cusip, 'duration', 'krd_timestamp')
        
        if corporate_duration_byte is not None:
            corporate_duration = float(corporate_duration_byte)*365

#         duration_timestamp_byte = redis_connection.hget(cusip, 'krd_timestamp')
        if duration_timestamp_byte is not None:
            # duration_timestamp = datetime.datetime.strptime(duration_timestamp_byte.decode(), '%Y-%m-%d %H:%M:%S.%f')
            duration_timestamp = duration_timestamp_byte.decode()
    return pd.Series([corporate_duration, duration_timestamp, corporate_days_to_maturity])


def get_corporate_buckets(corporate_days, issue_date):

    global CT2_RANGE
    global CT3_RANGE
    global CT5_RANGE
    global CT7_RANGE
    global CT10_RANGE
    global CT20_RANGE
    global CT30_RANGE

    CT7_ISSUE_DATE = convert_string_to_date('2021-01-01')
    issue_date = convert_string_to_date(issue_date)

    if corporate_days >= 0 and corporate_days <= 90:
        return 'CB3'
    elif corporate_days >= 91 and corporate_days <= 180:
        return 'CB6'
    elif corporate_days >= 181 and corporate_days <= 365:
        return 'CB12'
    elif corporate_days >= CT2_RANGE[0] and corporate_days <= CT2_RANGE[1]:
        return 'CT2'
    elif corporate_days >= CT3_RANGE[0] and corporate_days <= CT3_RANGE[1]:
        return 'CT3'
    elif corporate_days >= CT5_RANGE[0] and corporate_days <= CT5_RANGE[1]:
        return 'CT5'
    elif corporate_days >= CT7_RANGE[0] and corporate_days <= CT7_RANGE[1]:
        if issue_date == None:
            return 'CT10'
        elif issue_date > CT7_ISSUE_DATE:
            return 'CT7'
        else:
            return 'CT10'
    elif corporate_days >= CT10_RANGE[0] and corporate_days <= CT10_RANGE[1]:
        return 'CT10'
    elif corporate_days >= CT20_RANGE[0] and corporate_days <= CT20_RANGE[1]:
        return 'CT20'
    elif corporate_days >= CT30_RANGE[0] and corporate_days <= CT30_RANGE[1]:
        return 'CT30'
    else:
        return None


def pair_corporates_to_treasuries(otr_treasuries, issue_date, corporate_duration_date, corporate_duration_in_days, corporate_days_to_maturity):
    
    print("corporate_days_to_maturity",corporate_days_to_maturity)
    if corporate_days_to_maturity == None:
        return pd.Series([None, None,
        None, None, None, 
        None, None, None]) 

    pairing_field = get_pairing_field(corporate_duration_date, corporate_duration_in_days, corporate_days_to_maturity)

    consensus_benchmark = get_corporate_buckets(pairing_field, issue_date)
    
    if consensus_benchmark == None:
        return pd.Series([None, None,
        None, None, None, 
        None, None, None])

    otr_treasury = otr_treasuries[consensus_benchmark]
    #print('otr_treasury(766)=',otr_treasury)
    print('consensus_benchmark=',consensus_benchmark)
    treasury_benchmark = otr_treasury.get('bd_t_benchmark')
    treasury_days_to_maturity = otr_treasury.get('bd_t_benchmark_days_to_maturity') 
    treasury_bonddroid_id = otr_treasury.get('bonddroid_id')
    treasury_cusip = otr_treasury.get('cusip')
    treasury_figi = otr_treasury.get('figi') 
    treasury_isin = otr_treasury.get('isin')
    treasury_maturity = otr_treasury.get('bd_maturityDate') 
    treasury_consensus_benchmark = otr_treasury.get('bd_consensus_benchmark')

    duration_used = True if pairing_field == corporate_duration_in_days else False

    return pd.Series([treasury_benchmark, treasury_days_to_maturity,
        treasury_bonddroid_id, treasury_cusip,treasury_figi, treasury_isin, 
        treasury_maturity, treasury_consensus_benchmark, duration_used])    


def get_pairing_field(corporate_duration_date, corporate_duration_in_days, corporate_days_to_maturity, today=None):
    if corporate_duration_date is None:
        return corporate_days_to_maturity
    else:
        if today == None:
            today = datetime.datetime.now()
        one_business_day_before = find_n_business_days_before(today, 1)

        corporate_duration_date = corporate_duration_date.split(' ')[0]
        duration_date = datetime.datetime.strptime(corporate_duration_date, '%Y-%m-%d')
        diff = (duration_date - one_business_day_before).days

        pairing_field = None

        days_to_maturity_threshold = .5 * corporate_days_to_maturity

        if corporate_duration_in_days is not None:
            if corporate_duration_in_days <= days_to_maturity_threshold and abs(diff) <= 1:
                pairing_field = corporate_duration_in_days
            else:
                pairing_field = corporate_days_to_maturity
        else:
            pairing_field = corporate_days_to_maturity

        if pairing_field is None or pairing_field < 0:
            return None
    
    return pairing_field


def upload_treasury_corporate_mapping(df):
    upload = pd.DataFrame(df[['bd_treasury_benchmark', 'bd_treasury_days_to_maturity', 'bd_treasury_bonddroid_id',
             'bd_treasury_cusip', 'bd_treasury_figi', 'bd_treasury_isin',
             'bd_treasury_maturity', 'bd_treasury_consensus_benchmark']])

    upload['corporate_bonddroid_id'] = df["bonddroid_id"]
    upload['corporate_cusip'] = df["cusip"]
    upload['corporate_maturity_date'] = df["maturityDate"]
    upload['bd_last_duration'] = df['bd_last_duration'] # duration in days
    upload['bd_last_duration_timestamp'] = df['bd_last_duration_date']
    upload['duration_used'] = df['duration_used']



    today = datetime.date.today().strftime("%Y-%m-%d")
    upload['date'] = today

    print(upload.shape)
    try:
        upload.to_csv('/home/data/treasury_corporate_mapping_dump.csv', index = None)
    except:
        print('can not dump treasury corporate mapping csv')
    upload.to_sql('treasury_corporate_mapping', engine, schema = table_schema, index = False, if_exists='append', method = 'multi')

    return

