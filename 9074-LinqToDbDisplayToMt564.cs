using Caaps_Models.Display;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using LogUtility.Logger;
using System.Dynamic;

namespace CaapsLinqToDB.DBModels
{
    public class LinqToDbDisplayToMt564
    {
        public MT564Message TransformDisplayToMt564(MT564Message mt564, DisplayData displayData)
        {
            try
            {

                /***==========Corporate Action Option Details fields============***/
                if (displayData != null)
                {

                    /***========== General Information ===========================***/
                    if (mt564.MessageData.GeneralInformation == null)
                    {
                        mt564.MessageData.GeneralInformation = new MGeneralInformation();
                    }

                    if (mt564.MessageData.GeneralInformation.Reference == null)
                    {
                        mt564.MessageData.GeneralInformation.Reference = new List<MReference>();
                    }

                    if (displayData.CorporateActionReference != null)
                    {
                        MReference reference = mt564.MessageData.GeneralInformation.Reference.FirstOrDefault(x => x.Qualifier == "CORP");
                        Boolean isAdd = false;
                        if (reference == null)
                        {
                            reference = new MReference();
                            isAdd = true;
                        }

                        reference.Qualifier = "CORP";
                        reference.Reference = displayData.CorporateActionReference;
                        if (isAdd)
                        {
                            mt564.MessageData.GeneralInformation.Reference.Add(reference);
                        }
                    }
                    else
                    {
                        MReference reference = mt564.MessageData.GeneralInformation.Reference.FirstOrDefault(x => x.Qualifier == "CORP");
                        if (reference != null)
                        {
                            reference.Reference = null;
                        }
                    }

                    if (displayData.OfficialCorporateActionEventReference != null)
                    {
                        MReference reference = mt564.MessageData.GeneralInformation.Reference.FirstOrDefault(x => x.Qualifier == "COAF");
                        Boolean isAdd = false;
                        if (reference == null)
                        {
                            reference = new MReference();
                            isAdd = true;
                        }

                        reference.Qualifier = "COAF";
                        reference.Reference = displayData.OfficialCorporateActionEventReference;
                        if (isAdd)
                        {
                            mt564.MessageData.GeneralInformation.Reference.Add(reference);
                        }
                    }
                    else
                    {
                        MReference reference = mt564.MessageData.GeneralInformation.Reference.FirstOrDefault(x => x.Qualifier == "COAF");
                        if (reference != null)
                        {
                            reference.Reference = null;
                        }
                    }

                    //22F
                    if (mt564.MessageData.GeneralInformation.Indicator == null)
                    {
                        mt564.MessageData.GeneralInformation.Indicator = new List<MIndicator>();
                    }


                    if (displayData.EventProcessing != null)
                    {
                        MIndicator indicator = mt564.MessageData.GeneralInformation.Indicator.FirstOrDefault(x => x.Qualifier == "CAEP");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }

                        indicator.Qualifier = "CAEP";
                        indicator.Indicator = displayData.EventProcessing;
                        if (isAdd)
                        {
                            mt564.MessageData.GeneralInformation.Indicator.Add(indicator);
                        }
                    }
                    else
                    {
                        MIndicator indicator = mt564.MessageData.GeneralInformation.Indicator.FirstOrDefault(x => x.Qualifier == "CAEP");
                        if (indicator != null)
                        {
                            indicator.Indicator = null;
                        }
                    }

                    if (displayData.EventType != null)
                    {
                        MIndicator indicator = mt564.MessageData.GeneralInformation.Indicator.FirstOrDefault(x => x.Qualifier == "CAEV");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }

                        indicator.Qualifier = "CAEV";
                        indicator.Indicator = displayData.EventType;
                        if (isAdd)
                        {
                            mt564.MessageData.GeneralInformation.Indicator.Add(indicator);
                        }
                    }
                    else
                    {
                        MIndicator indicator = mt564.MessageData.GeneralInformation.Indicator.FirstOrDefault(x => x.Qualifier == "CAEV");
                        if (indicator != null)
                        {
                            indicator.Indicator = null;
                        }
                    }

                    if (displayData.MVC != null)
                    {
                        MIndicator indicator = mt564.MessageData.GeneralInformation.Indicator.FirstOrDefault(x => x.Qualifier == "CAMV");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }

                        indicator.Qualifier = "CAMV";
                        indicator.Indicator = displayData.MVC;
                        if (isAdd)
                        {
                            mt564.MessageData.GeneralInformation.Indicator.Add(indicator);
                        }
                    }
                    else
                    {
                        MIndicator indicator = mt564.MessageData.GeneralInformation.Indicator.FirstOrDefault(x => x.Qualifier == "CAMV");
                        if (indicator != null)
                        {
                            indicator.Indicator = null;
                        }
                    }

                    //==================== Underlying Securities =========================
                    if (mt564.MessageData.UnderlyingSecurities.FinancialInstrument == null)
                    {
                        mt564.MessageData.UnderlyingSecurities.FinancialInstrument = new MFinancialInstrument();
                    }

                    mt564.MessageData.UnderlyingSecurities.FinancialInstrument.SecurityDescription = displayData.SecurityDescription;
                    mt564.MessageData.UnderlyingSecurities.FinancialInstrument.SecurityType = displayData.SecurityIDType;
                    mt564.MessageData.UnderlyingSecurities.FinancialInstrument.SecurityValue = displayData.SecurityID;


                    Boolean isUFinancialInstrumentAttributesAdd = false;
                    if (mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes == null)
                    {
                        mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes = new MFinancialInstrumentAttributes();
                    }
                    else
                    {
                        isUFinancialInstrumentAttributesAdd = true;
                    }

                    if (mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes.Dates == null)
                    {
                        mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes.Dates = new List<MDateTime>();
                    }

                    //98A
                    if (displayData.ExpiryDate != null)
                    {
                        isUFinancialInstrumentAttributesAdd = true;
                        MDateTime date = mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes.Dates.FirstOrDefault(x => x.Qualifier == "EXPI");
                        Boolean isAdd = false;
                        if (date == null)
                        {
                            date = new MDateTime();
                            isAdd = true;
                        }
                        date.Date = displayData.ExpiryDate.Value.ToString("yyyyMMdd");
                        date.Qualifier = "EXPI";

                        if (isAdd)
                        {
                            mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes.Dates.Add(date);
                        }

                    }
                    else
                    {
                        MDateTime date = mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes.Dates.FirstOrDefault(x => x.Qualifier == "EXPI");
                        if (date != null)
                        {
                            isUFinancialInstrumentAttributesAdd = true;
                            date.Date = null;
                        }
                    }

                    if (displayData.MaturityDate != null)
                    {
                        isUFinancialInstrumentAttributesAdd = true;
                        MDateTime date = mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes.Dates.FirstOrDefault(x => x.Qualifier == "MATU");
                        Boolean isAdd = false;
                        if (date == null)
                        {
                            date = new MDateTime();
                            isAdd = true;
                        }
                        date.Date = displayData.MaturityDate.Value.ToString("yyyyMMdd");
                        date.Qualifier = "MATU";

                        if (isAdd)
                        {
                            mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes.Dates.Add(date);
                        }

                    }
                    else
                    {
                        MDateTime date = mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes.Dates.FirstOrDefault(x => x.Qualifier == "MATU");
                        if (date != null)
                        {
                            isUFinancialInstrumentAttributesAdd = true;
                            date.Date = null;
                        }
                    }


                    if (displayData.PlaceOfListing != null)
                    {
                        isUFinancialInstrumentAttributesAdd = true;
                        if (mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes.Place == null)
                        {
                            mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes.Place = new MPlaceOfListning();
                        }
                        mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes.Place.Narrative = string.IsNullOrEmpty(displayData.PlaceOfListing) ? null : displayData.PlaceOfListing;
                        mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes.Place.Qualifier = "PLIS";
                    }

                    if (mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes.TypeOfInstrument == null)
                    {
                        mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes.TypeOfInstrument = new List<MTypeOfInstrument>();
                    }


                    //12a
                    if (displayData.InstrumentCodeOrDescription != null)
                    {
                        isUFinancialInstrumentAttributesAdd = true;
                        MTypeOfInstrument typeOfInstrument = mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes.TypeOfInstrument.FirstOrDefault(x => x.Qualifier == "CLAS");
                        Boolean isAdd = false;
                        if (typeOfInstrument == null)
                        {
                            typeOfInstrument = new MTypeOfInstrument();
                            isAdd = true;
                        }

                        typeOfInstrument.Qualifier = "CLAS";
                        typeOfInstrument.Description = displayData.InstrumentCodeOrDescription;
                        if (isAdd)
                        {
                            mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes.TypeOfInstrument.Add(typeOfInstrument);
                        }
                    }
                    else
                    {
                        MTypeOfInstrument typeOfInstrument = mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes.TypeOfInstrument.FirstOrDefault(x => x.Qualifier == "CLAS");
                        if (typeOfInstrument != null)
                        {
                            isUFinancialInstrumentAttributesAdd = true;
                            typeOfInstrument.Description = null;
                        }

                    }

                    if (displayData.InstrumentCode != null)
                    {
                        isUFinancialInstrumentAttributesAdd = true;
                        MTypeOfInstrument typeOfInstrument = mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes.TypeOfInstrument.FirstOrDefault(x => x.Qualifier == "CLAS");
                        Boolean isAdd = false;
                        if (typeOfInstrument == null)
                        {
                            typeOfInstrument = new MTypeOfInstrument();
                            isAdd = true;
                        }

                        typeOfInstrument.Qualifier = "CLAS";
                        typeOfInstrument.Cficode = displayData.InstrumentCode;
                        if (isAdd)
                        {
                            mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes.TypeOfInstrument.Add(typeOfInstrument);
                        }
                    }
                    else
                    {
                        MTypeOfInstrument typeOfInstrument = mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes.TypeOfInstrument.FirstOrDefault(x => x.Qualifier == "CLAS");
                        if (typeOfInstrument != null)
                        {
                            isUFinancialInstrumentAttributesAdd = true;
                            typeOfInstrument.Cficode = null;
                        }

                    }


                    if (isUFinancialInstrumentAttributesAdd == false)
                    {
                        mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes = null;
                    }


                    /***==========Corporate Action Details ========================***/
                    if (mt564.MessageData.CorporateActionDetails == null)
                    {
                        mt564.MessageData.CorporateActionDetails = new MCorporateActionDetails();
                    }

                    //90a - Price

                    if (mt564.MessageData.CorporateActionDetails.Price == null)
                    {
                        mt564.MessageData.CorporateActionDetails.Price = new List<MPrice>();
                    }

                    if (displayData.MaximumPriceCode != "NA" && (displayData.MaximumPrice != null || displayData.MaximumPriceCurrencyCode != null || displayData.MaximumPriceAmountTypeCode != null
                    || displayData.MaximumPriceCode != null))
                    {

                        MPrice price = mt564.MessageData.CorporateActionDetails.Price.FirstOrDefault(x => x.Qualifier == "MAXP");
                        Boolean isAdd = false;
                        if (price == null)
                        {
                            price = new MPrice();
                            isAdd = true;
                        }
                        price.Price = displayData.MaximumPrice;
                        price.CurrencyCode = displayData.MaximumPriceCurrencyCode;
                        price.AmountTypeCode = displayData.MaximumPriceAmountTypeCode;
                        price.PriceCode = displayData.MaximumPriceCode;
                        price.Qualifier = "MAXP";
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Price.Add(price);
                        }
                    }
                    else
                    {
                        MPrice price = mt564.MessageData.CorporateActionDetails.Price.FirstOrDefault(x => x.Qualifier == "MAXP");
                        if (price != null)
                        {
                            price.Price = null;
                            price.CurrencyCode = null;
                            price.AmountTypeCode = null;
                            price.PriceCode = null;
                        }
                    }

                    if (displayData.MinimumPriceCode != "NA" && (displayData.MinimumPrice != null || displayData.MinimumPriceCurrencyCode != null || displayData.MinimumPriceAmountTypeCode != null
                    || displayData.MinimumPriceCode != null))
                    {
                        MPrice price = mt564.MessageData.CorporateActionDetails.Price.FirstOrDefault(x => x.Qualifier == "MINP");
                        Boolean isAdd = false;
                        if (price == null)
                        {
                            price = new MPrice();
                            isAdd = true;
                        }
                        price.Price = displayData.MinimumPrice;
                        price.CurrencyCode = displayData.MinimumPriceCurrencyCode;
                        price.AmountTypeCode = displayData.MinimumPriceAmountTypeCode;
                        price.PriceCode = displayData.MinimumPriceCode;
                        price.Qualifier = "MINP";
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Price.Add(price);
                        }
                    }
                    else
                    {
                        MPrice price = mt564.MessageData.CorporateActionDetails.Price.FirstOrDefault(x => x.Qualifier == "MINP");
                        if (price != null)
                        {
                            price.Price = null;
                            price.CurrencyCode = null;
                            price.AmountTypeCode = null;
                            price.PriceCode = null;
                        }
                    }

                    //92a - Rate
                    if (mt564.MessageData.CorporateActionDetails.Rate == null)
                    {
                        mt564.MessageData.CorporateActionDetails.Rate = new List<MRate>();
                    }

                    if (displayData.BidIntervalRateTypeCode != "NA" && (displayData.BidIntervalRate != null || displayData.BidIntervalRateCurrency != null || displayData.BidIntervalRateTypeCode != null))
                    {
                        MRate rate = mt564.MessageData.CorporateActionDetails.Rate.FirstOrDefault(x => x.Qualifier == "BIDI");
                        Boolean isAdd = false;
                        if (rate == null)
                        {
                            rate = new MRate();
                            isAdd = true;
                        }
                        rate.Rate = displayData.BidIntervalRate;
                        rate.CurrencyCode = displayData.BidIntervalRateCurrency;
                        rate.RateTypeCode = displayData.BidIntervalRateTypeCode;
                        rate.Qualifier = "BIDI";
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Rate.Add(rate);
                        }
                    }
                    else
                    {
                        MRate rate = mt564.MessageData.CorporateActionDetails.Rate.FirstOrDefault(x => x.Qualifier == "BIDI");
                        if (rate != null)
                        {
                            rate.Rate = null;
                            rate.CurrencyCode = null;
                            rate.RateTypeCode = null;
                        }
                    }

                    if (displayData.DeclaredRateTypeCode != "NA" && (displayData.DeclaredRate != null || displayData.DeclaredRateCurrency != null || displayData.DeclaredRateTypeCode != null))
                    {
                        MRate rate = mt564.MessageData.CorporateActionDetails.Rate.FirstOrDefault(x => x.Qualifier == "DEVI");
                        Boolean isAdd = false;
                        if (rate == null)
                        {
                            rate = new MRate();
                            isAdd = true;
                        }
                        rate.Rate = displayData.DeclaredRate;
                        rate.CurrencyCode = displayData.DeclaredRateCurrency;
                        rate.RateTypeCode = displayData.DeclaredRateTypeCode;
                        rate.Qualifier = "DEVI";
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Rate.Add(rate);
                        }
                    }
                    else
                    {
                        MRate rate = mt564.MessageData.CorporateActionDetails.Rate.FirstOrDefault(x => x.Qualifier == "DEVI");
                        if (rate != null)
                        {
                            rate.Rate = null;
                            rate.CurrencyCode = null;
                            rate.RateTypeCode = null;
                        }
                    }

                    if (displayData.InterestRateTypeCode != "NA" && (displayData.Interest != null || displayData.InterestCurrency != null || displayData.InterestRateTypeCode != null))
                    {
                        MRate rate = mt564.MessageData.CorporateActionDetails.Rate.FirstOrDefault(x => x.Qualifier == "INTR");
                        Boolean isAdd = false;
                        if (rate == null)
                        {
                            rate = new MRate();
                            isAdd = true;
                        }
                        rate.Rate = displayData.Interest;
                        rate.CurrencyCode = displayData.InterestCurrency;
                        rate.RateTypeCode = displayData.InterestRateTypeCode;
                        rate.Qualifier = "INTR";
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Rate.Add(rate);
                        }
                    }
                    else
                    {
                        MRate rate = mt564.MessageData.CorporateActionDetails.Rate.FirstOrDefault(x => x.Qualifier == "INTR");
                        if (rate != null)
                        {
                            rate.Rate = null;
                            rate.CurrencyCode = null;
                            rate.RateTypeCode = null;
                        }
                    }

                    if (displayData.NextFactorRateTypeCode != "NA" && (displayData.NextFactorRateTypeCode != null || displayData.NextFactor != null))
                    {
                        MRate rate = mt564.MessageData.CorporateActionDetails.Rate.FirstOrDefault(x => x.Qualifier == "NWFC");
                        Boolean isAdd = false;
                        if (rate == null)
                        {
                            rate = new MRate();
                            isAdd = true;
                        }
                        rate.Rate = displayData.NextFactor;
                        rate.RateTypeCode = displayData.NextFactorRateTypeCode;
                        rate.Qualifier = "NWFC";
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Rate.Add(rate);
                        }
                    }
                    else
                    {
                        MRate rate = mt564.MessageData.CorporateActionDetails.Rate.FirstOrDefault(x => x.Qualifier == "NWFC");
                        if (rate != null)
                        {
                            rate.Rate = null;
                            rate.RateTypeCode = null;
                        }
                    }

                    if (displayData.PercentageSoughtRateTypeCode != "NA" && (displayData.PercentageSought != null || displayData.PercentageSoughtRateTypeCode != null))
                    {
                        MRate rate = mt564.MessageData.CorporateActionDetails.Rate.FirstOrDefault(x => x.Qualifier == "PTSC");
                        Boolean isAdd = false;
                        if (rate == null)
                        {
                            rate = new MRate();
                            isAdd = true;
                        }
                        rate.Rate = displayData.PercentageSought;
                        rate.RateTypeCode = displayData.PercentageSoughtRateTypeCode;
                        rate.Qualifier = "PTSC";
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Rate.Add(rate);
                        }
                    }
                    else
                    {
                        MRate rate = mt564.MessageData.CorporateActionDetails.Rate.FirstOrDefault(x => x.Qualifier == "PTSC");
                        if (rate != null)
                        {
                            rate.Rate = null;
                            rate.RateTypeCode = null;
                        }
                    }

                    if (displayData.RealizedLossRateTypeCode != "NA" && (displayData.RealizedLossRate != null || displayData.RealizedLossRateTypeCode != null || displayData.RealizedLossRateCurrency != null))
                    {
                        MRate rate = mt564.MessageData.CorporateActionDetails.Rate.FirstOrDefault(x => x.Qualifier == "RLOS");
                        Boolean isAdd = false;
                        if (rate == null)
                        {
                            rate = new MRate();
                            isAdd = true;
                        }
                        rate.Rate = displayData.RealizedLossRate;
                        rate.CurrencyCode = displayData.RealizedLossRateCurrency;
                        rate.RateTypeCode = displayData.RealizedLossRateTypeCode;
                        rate.Qualifier = "RLOS";
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Rate.Add(rate);
                        }
                    }
                    else
                    {
                        MRate rate = mt564.MessageData.CorporateActionDetails.Rate.FirstOrDefault(x => x.Qualifier == "RLOS");
                        if (rate != null)
                        {
                            rate.Rate = null;
                            rate.CurrencyCode = null;
                            rate.RateTypeCode = null;
                        }
                    }

                    if (displayData.ReinvestmentDiscountRatetoMarketRateTypeCode != "NA" && (displayData.ReinvestmentDiscountRatetoMarket != null || displayData.ReinvestmentDiscountRatetoMarketRateTypeCode != null || displayData.ReinvestmentDiscountRatetoMarketCurrency != null))
                    {
                        MRate rate = mt564.MessageData.CorporateActionDetails.Rate.FirstOrDefault(x => x.Qualifier == "RDIS");
                        Boolean isAdd = false;
                        if (rate == null)
                        {
                            rate = new MRate();
                            isAdd = true;
                        }
                        rate.Rate = displayData.ReinvestmentDiscountRatetoMarket;
                        rate.CurrencyCode = displayData.ReinvestmentDiscountRatetoMarketCurrency;
                        rate.RateTypeCode = displayData.ReinvestmentDiscountRatetoMarketRateTypeCode;
                        rate.Qualifier = "RDIS";
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Rate.Add(rate);
                        }
                    }
                    else
                    {
                        MRate rate = mt564.MessageData.CorporateActionDetails.Rate.FirstOrDefault(x => x.Qualifier == "RDIS");
                        if (rate != null)
                        {
                            rate.Rate = null;
                            rate.CurrencyCode = null;
                            rate.RateTypeCode = null;
                        }
                    }

                    if (displayData.PreviousPayFactorRateTypeCode != "NA" && (displayData.PreviousPayFactor != null || displayData.PreviousPayFactorRateTypeCode != null))
                    {
                        MRate rate = mt564.MessageData.CorporateActionDetails.Rate.FirstOrDefault(x => x.Qualifier == "PRFC");
                        Boolean isAdd = false;
                        if (rate == null)
                        {
                            rate = new MRate();
                            isAdd = true;
                        }
                        rate.Rate = displayData.PreviousPayFactor;
                        rate.RateTypeCode = displayData.PreviousPayFactorRateTypeCode;
                        rate.Qualifier = "PRFC";
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Rate.Add(rate);
                        }
                    }
                    else
                    {
                        MRate rate = mt564.MessageData.CorporateActionDetails.Rate.FirstOrDefault(x => x.Qualifier == "PRFC");
                        if (rate != null)
                        {
                            rate.Rate = null;
                            rate.RateTypeCode = null;
                        }
                    }

                    //17B - FLAG
                    if (mt564.MessageData.CorporateActionDetails.Flag == null)
                    {
                        mt564.MessageData.CorporateActionDetails.Flag = new List<MFlag>();
                    }

                    if (displayData.CertificationOrBreakDown != null && displayData.CertificationOrBreakDown != "NA")
                    {
                        MFlag flag = mt564.MessageData.CorporateActionDetails.Flag.FirstOrDefault(x => x.Qualifier == "CERT");
                        Boolean isAdd = false;
                        if (flag == null)
                        {
                            flag = new MFlag();
                            isAdd = true;
                        }
                        flag.Flag = displayData.CertificationOrBreakDown;
                        flag.Qualifier = "CERT";
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Flag.Add(flag);
                        }
                    }
                    else
                    {
                        MFlag flag = mt564.MessageData.CorporateActionDetails.Flag.FirstOrDefault(x => x.Qualifier == "CERT");
                        if (flag != null)
                        {
                            flag.Flag = null;
                        }
                    }


                    if (displayData.CADtlInformationtobeCompliedWith != null && displayData.CADtlInformationtobeCompliedWith != "NA")
                    {
                        MFlag flag = mt564.MessageData.CorporateActionDetails.Flag.FirstOrDefault(x => x.Qualifier == "COMP");
                        Boolean isAdd = false;
                        if (flag == null)
                        {
                            flag = new MFlag();
                            isAdd = true;
                        }
                        flag.Flag = displayData.CADtlInformationtobeCompliedWith;
                        flag.Qualifier = "COMP";
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Flag.Add(flag);
                        }
                    }
                    else
                    {
                        MFlag flag = mt564.MessageData.CorporateActionDetails.Flag.FirstOrDefault(x => x.Qualifier == "COMP");
                        if (flag != null)
                        {
                            flag.Flag = null;
                        }
                    }
                    if (displayData.LetterofGuaranteedDelivery != null && displayData.LetterofGuaranteedDelivery != "NA")
                    {
                        MFlag flag = mt564.MessageData.CorporateActionDetails.Flag.FirstOrDefault(x => x.Qualifier == "LEOG");
                        Boolean isAdd = false;
                        if (flag == null)
                        {
                            flag = new MFlag();
                            isAdd = true;
                        }
                        flag.Flag = displayData.LetterofGuaranteedDelivery;
                        flag.Qualifier = "LEOG";
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Flag.Add(flag);
                        }
                    }
                    else
                    {
                        MFlag flag = mt564.MessageData.CorporateActionDetails.Flag.FirstOrDefault(x => x.Qualifier == "LEOG");
                        if (flag != null)
                        {
                            flag.Flag = null;
                        }
                    }

                    //22F - indicator
                    if (mt564.MessageData.CorporateActionDetails.Indicator == null)
                    {
                        mt564.MessageData.CorporateActionDetails.Indicator = new List<MIndicator>();
                    }

                    if (displayData.Approved != null && displayData.Approved != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ESTA" && x.Indicator == "APPD");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "ESTA";
                        indicator.Indicator = displayData.Approved;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.Approved == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ESTA" && x.Indicator == "APPD");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "ESTA";
                            indicator.Indicator = null;
                        }
                    }

                    if (displayData.LotteryCancellationandReRun != null && displayData.LotteryCancellationandReRun != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ESTA" && x.Indicator == "FULL");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "ESTA";
                        indicator.Indicator = displayData.LotteryCancellationandReRun;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.LotteryCancellationandReRun == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ESTA" && x.Indicator == "FULL");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "ESTA";
                            indicator.Indicator = null;
                        }
                    }

                    if (displayData.PeriodofAction != null && displayData.PeriodofAction != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ESTA" && x.Indicator == "PWAL");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "ESTA";
                        indicator.Indicator = displayData.PeriodofAction;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.PeriodofAction == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ESTA" && x.Indicator == "PWAL");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "ESTA";
                            indicator.Indicator = null;
                        }
                    }

                    if (displayData.SubjecttoApproval != null && displayData.SubjecttoApproval != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ESTA" && x.Indicator == "SUAP");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "ESTA";
                        indicator.Indicator = displayData.SubjecttoApproval;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.SubjecttoApproval == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ESTA" && x.Indicator == "SUAP");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "ESTA";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.SupplementalLotteryCancellation != null && displayData.SupplementalLotteryCancellation != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ESTA" && x.Indicator == "RESC");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "ESTA";
                        indicator.Indicator = displayData.SupplementalLotteryCancellation;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.SupplementalLotteryCancellation == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ESTA" && x.Indicator == "RESC");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "ESTA";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.SupplementalLotteryCancellationandReRun != null && displayData.SupplementalLotteryCancellationandReRun != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ESTA" && x.Indicator == "PART");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "ESTA";
                        indicator.Indicator = displayData.SupplementalLotteryCancellationandReRun;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.SupplementalLotteryCancellationandReRun == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ESTA" && x.Indicator == "PART");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "ESTA";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.UnconditionalAsToAcceptance != null && displayData.UnconditionalAsToAcceptance != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ESTA" && x.Indicator == "UNAC");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "ESTA";
                        indicator.Indicator = displayData.UnconditionalAsToAcceptance;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.UnconditionalAsToAcceptance == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ESTA" && x.Indicator == "UNAC");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "ESTA";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.WhollyUnconditional != null && displayData.WhollyUnconditional != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ESTA" && x.Indicator == "WHOU");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "ESTA";
                        indicator.Indicator = displayData.WhollyUnconditional;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.WhollyUnconditional == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ESTA" && x.Indicator == "WHOU");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "ESTA";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.ClosedDeactivated != null && displayData.ClosedDeactivated != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ESTA" && x.Indicator == "CLDE");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "ESTA";
                        indicator.Indicator = displayData.ClosedDeactivated;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.ClosedDeactivated == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ESTA" && x.Indicator == "CLDE");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "ESTA";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.ClaimorCompensation != null && displayData.ClaimorCompensation != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ADDB" && x.Indicator == "CLAI");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "ADDB";
                        indicator.Indicator = displayData.ClaimorCompensation;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.ClaimorCompensation == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ADDB" && x.Indicator == "CLAI");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "ADDB";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.Consent != null && displayData.Consent != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ADDB" && x.Indicator == "CONS");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "ADDB";
                        indicator.Indicator = displayData.Consent;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.Consent == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ADDB" && x.Indicator == "CONS");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "ADDB";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.FullPreFunding != null && displayData.FullPreFunding != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ADDB" && x.Indicator == "FPRE");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "ADDB";
                        indicator.Indicator = displayData.FullPreFunding;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.FullPreFunding == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ADDB" && x.Indicator == "FPRE");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "ADDB";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.PartialMandatoryPutRedemption != null && displayData.PartialMandatoryPutRedemption != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ADDB" && x.Indicator == "PPUT");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "ADDB";
                        indicator.Indicator = displayData.PartialMandatoryPutRedemption;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.PartialMandatoryPutRedemption == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ADDB" && x.Indicator == "PPUT");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "ADDB";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.PartialPreFunding != null && displayData.PartialPreFunding != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ADDB" && x.Indicator == "PPRE");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "ADDB";
                        indicator.Indicator = displayData.PartialPreFunding;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.PartialPreFunding == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ADDB" && x.Indicator == "PPRE");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "ADDB";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.PreliminaryAdviceofPayment != null && displayData.PreliminaryAdviceofPayment != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ADDB" && x.Indicator == "CAPA");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "ADDB";
                        indicator.Indicator = displayData.PreliminaryAdviceofPayment;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.PreliminaryAdviceofPayment == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ADDB" && x.Indicator == "CAPA");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "ADDB";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.SchemePlanofArrangement != null && displayData.SchemePlanofArrangement != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ADDB" && x.Indicator == "SCHM");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "ADDB";
                        indicator.Indicator = displayData.SchemePlanofArrangement;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.SchemePlanofArrangement == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ADDB" && x.Indicator == "SCHM");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "ADDB";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.TaxRefund != null && displayData.TaxRefund != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ADDB" && x.Indicator == "TAXR");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "ADDB";
                        indicator.Indicator = displayData.TaxRefund;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.TaxRefund == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "ADDB" && x.Indicator == "TAXR");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "ADDB";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.CertificationFormat != null && displayData.CertificationFormat != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "CEFI");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "CEFI";
                        indicator.Indicator = displayData.CertificationFormat;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.CertificationFormat == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "CEFI");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "CEFI";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.NameChange != null && displayData.NameChange != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "CHAN" && x.Indicator == "NAME");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "CHAN";
                        indicator.Indicator = displayData.NameChange;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.NameChange == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "CHAN" && x.Indicator == "NAME");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "CHAN";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.ChangeinTerms != null && displayData.ChangeinTerms != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "CHAN" && x.Indicator == "TERM");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "CHAN";
                        indicator.Indicator = displayData.ChangeinTerms;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.ChangeinTerms == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "CHAN" && x.Indicator == "TERM");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "CHAN";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.ConsentType != null && displayData.ConsentType != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "CONS");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "CONS";
                        indicator.Indicator = displayData.ConsentType;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.ConsentType == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "CONS");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "CONS";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.EventSequence != null && displayData.EventSequence != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "CONV");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "CONV";
                        indicator.Indicator = displayData.EventSequence;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.EventSequence == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "CONV");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "CONV";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.PaymentOccurrenceType != null && displayData.PaymentOccurrenceType != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "DITY");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "DITY";
                        indicator.Indicator = displayData.PaymentOccurrenceType;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.PaymentOccurrenceType == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "DITY");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "DITY";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.DividendType != null && displayData.DividendType != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "DIVI");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "DIVI";
                        indicator.Indicator = displayData.DividendType;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.DividendType == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "DIVI");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "DIVI";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.LotteryType != null && displayData.LotteryType != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "LOTO");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "LOTO";
                        indicator.Indicator = displayData.LotteryType;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.LotteryType == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "LOTO");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "LOTO";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.PartialOffer != null && displayData.PartialOffer != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "OFFE" && x.Indicator == "PART");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "OFFE";
                        indicator.Indicator = displayData.PartialOffer;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.PartialOffer == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "OFFE" && x.Indicator == "PART");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "OFFE";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.RestrictionExchange != null && displayData.RestrictionExchange != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "OFFE" && x.Indicator == "ERUN");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "OFFE";
                        indicator.Indicator = displayData.RestrictionExchange;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.RestrictionExchange == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "OFFE" && x.Indicator == "ERUN");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "OFFE";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.SqueezeOutBid != null && displayData.SqueezeOutBid != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "OFFE" && x.Indicator == "SQUE");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "OFFE";
                        indicator.Indicator = displayData.SqueezeOutBid;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.SqueezeOutBid == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "OFFE" && x.Indicator == "SQUE");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "OFFE";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.DissentersRights != null && displayData.DissentersRights != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "OFFE" && x.Indicator == "DISS");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "OFFE";
                        indicator.Indicator = displayData.DissentersRights;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.DissentersRights == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "OFFE" && x.Indicator == "DISS");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "OFFE";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.FinalOffer != null && displayData.FinalOffer != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "OFFE" && x.Indicator == "FINL");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "OFFE";
                        indicator.Indicator = displayData.FinalOffer;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.FinalOffer == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "OFFE" && x.Indicator == "FINL");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "OFFE";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.FirstComeFirstServed != null && displayData.FirstComeFirstServed != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "OFFE" && x.Indicator == "FCFS");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "OFFE";
                        indicator.Indicator = displayData.FirstComeFirstServed;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.FirstComeFirstServed == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "OFFE" && x.Indicator == "FCFS");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "OFFE";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.IntermediateSecuritiesDistributionType != null && displayData.IntermediateSecuritiesDistributionType != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "RHDI");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "RHDI";
                        indicator.Indicator = displayData.IntermediateSecuritiesDistributionType;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.IntermediateSecuritiesDistributionType == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "RHDI");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "RHDI";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.Renounceable != null && displayData.Renounceable != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "SELL");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "SELL";
                        indicator.Indicator = displayData.Renounceable;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.Renounceable == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "SELL");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "SELL";
                            indicator.Indicator = null;
                        }
                    }
                    if (displayData.TIDTISCalculatedIndicator != null && displayData.TIDTISCalculatedIndicator != "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "TDTA");
                        Boolean isAdd = false;
                        if (indicator == null)
                        {
                            indicator = new MIndicator();
                            isAdd = true;
                        }
                        indicator.Qualifier = "TDTA";
                        indicator.Indicator = displayData.TIDTISCalculatedIndicator;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Indicator.Add(indicator);
                        }
                    }
                    else if (displayData.TIDTISCalculatedIndicator == "NA")
                    {
                        MIndicator indicator = mt564.MessageData.CorporateActionDetails.Indicator.FirstOrDefault(x => x.Qualifier == "TDTA");
                        if (indicator != null)
                        {
                            indicator.Qualifier = "TDTA";
                            indicator.Indicator = null;
                        }
                    }

                    //36a
                    if (mt564.MessageData.CorporateActionDetails.QuantityOfInstrument == null)
                    {
                        mt564.MessageData.CorporateActionDetails.QuantityOfInstrument = new List<MQuantityOfInstrument>();
                    }

                    if (displayData.BaseDenominationQuantityCode != "NA" && (displayData.BaseDenominationQuantity != null || displayData.BaseDenominationQuantityTypeCode != null || displayData.BaseDenominationQuantityCode != null))
                    {
                        MQuantityOfInstrument qof = mt564.MessageData.CorporateActionDetails.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "BASE");
                        Boolean isAdd = false;
                        if (qof == null)
                        {
                            qof = new MQuantityOfInstrument();
                            isAdd = true;
                        }
                        qof.Qualifier = "BASE";
                        qof.Quantity = displayData.BaseDenominationQuantity;
                        qof.QuantityTypeCode = displayData.BaseDenominationQuantityTypeCode;
                        qof.QuantityCode = displayData.BaseDenominationQuantityCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.QuantityOfInstrument.Add(qof);
                        }
                    }
                    else
                    {
                        MQuantityOfInstrument qof = mt564.MessageData.CorporateActionDetails.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "BASE");
                        if (qof != null)
                        {
                            qof.Quantity = null;
                            qof.QuantityTypeCode = null;
                            qof.QuantityCode = null;

                        }
                    }

                    if (displayData.IncrementalDenominationQuantityCode != "NA" && (displayData.IncrementalDenominationQuantity != null || displayData.IncrementalDenominationQuantityTypeCode != null || displayData.IncrementalDenominationQuantityCode != null))
                    {
                        MQuantityOfInstrument qof = mt564.MessageData.CorporateActionDetails.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "INCR");
                        Boolean isAdd = false;
                        if (qof == null)
                        {
                            qof = new MQuantityOfInstrument();
                            isAdd = true;
                        }
                        qof.Qualifier = "INCR";
                        qof.Quantity = displayData.IncrementalDenominationQuantity;
                        qof.QuantityTypeCode = displayData.IncrementalDenominationQuantityTypeCode;
                        qof.QuantityCode = displayData.IncrementalDenominationQuantityCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.QuantityOfInstrument.Add(qof);
                        }
                    }
                    else
                    {
                        MQuantityOfInstrument qof = mt564.MessageData.CorporateActionDetails.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "INCR");
                        if (qof != null)
                        {
                            qof.Quantity = null;
                            qof.QuantityTypeCode = null;
                            qof.QuantityCode = null;

                        }
                    }

                    if (displayData.MaximumQuantityofSecuritiesQuantityCode != "NA" && (displayData.MaximumQuantityofSecurities != null || displayData.MaximumQuantityofSecuritiesTypeCode != null || displayData.MaximumQuantityofSecuritiesQuantityCode != null))
                    {
                        MQuantityOfInstrument qof = mt564.MessageData.CorporateActionDetails.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "MQSO");
                        Boolean isAdd = false;
                        if (qof == null)
                        {
                            qof = new MQuantityOfInstrument();
                            isAdd = true;
                        }
                        qof.Qualifier = "MQSO";
                        qof.Quantity = displayData.MaximumQuantityofSecurities;
                        qof.QuantityTypeCode = displayData.MaximumQuantityofSecuritiesTypeCode;
                        qof.QuantityCode = displayData.MaximumQuantityofSecuritiesQuantityCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.QuantityOfInstrument.Add(qof);
                        }
                    }
                    else
                    {
                        MQuantityOfInstrument qof = mt564.MessageData.CorporateActionDetails.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "MQSO");
                        if (qof != null)
                        {
                            qof.Quantity = null;
                            qof.QuantityTypeCode = null;
                            qof.QuantityCode = null;

                        }
                    }


                    if (displayData.MinimumQuantitySoughtQuantityCode != "NA" && (displayData.MinimumQuantitySought != null || displayData.MinimumQuantitySoughtTypeCode != null || displayData.MinimumQuantitySoughtQuantityCode != null))
                    {
                        MQuantityOfInstrument qof = mt564.MessageData.CorporateActionDetails.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "QTSO");
                        Boolean isAdd = false;
                        if (qof == null)
                        {
                            qof = new MQuantityOfInstrument();
                            isAdd = true;
                        }
                        qof.Qualifier = "QTSO";
                        qof.Quantity = displayData.MinimumQuantitySought;
                        qof.QuantityTypeCode = displayData.MinimumQuantitySoughtTypeCode;
                        qof.QuantityCode = displayData.MinimumQuantitySoughtQuantityCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.QuantityOfInstrument.Add(qof);
                        }
                    }
                    else
                    {
                        MQuantityOfInstrument qof = mt564.MessageData.CorporateActionDetails.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "QTSO");
                        if (qof != null)
                        {
                            qof.Quantity = null;
                            qof.QuantityTypeCode = null;
                            qof.QuantityCode = null;

                        }
                    }

                    if (displayData.NewDenominationQuantityCode != "NA" && (displayData.NewDenominationQuantity != null || displayData.NewDenominationQuantityTypeCode != null || displayData.NewDenominationQuantityCode != null))
                    {
                        MQuantityOfInstrument qof = mt564.MessageData.CorporateActionDetails.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "NEWD");
                        Boolean isAdd = false;
                        if (qof == null)
                        {
                            qof = new MQuantityOfInstrument();
                            isAdd = true;
                        }
                        qof.Qualifier = "NEWD";
                        qof.Quantity = displayData.NewDenominationQuantity;
                        qof.QuantityTypeCode = displayData.NewDenominationQuantityTypeCode;
                        qof.QuantityCode = displayData.NewDenominationQuantityCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.QuantityOfInstrument.Add(qof);
                        }
                    }
                    else
                    {
                        MQuantityOfInstrument qof = mt564.MessageData.CorporateActionDetails.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "NEWD");
                        if (qof != null)
                        {
                            qof.Quantity = null;
                            qof.QuantityTypeCode = null;
                            qof.QuantityCode = null;

                        }
                    }

                    if (displayData.MinimumExercisableQuantityCode != "NA" && (displayData.MinimumExercisableQuantity != null || displayData.MinimumExercisableQuantityTypeCode != null || displayData.MinimumExercisableQuantityCode != null))
                    {
                        MQuantityOfInstrument qof = mt564.MessageData.CorporateActionDetails.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "MIEX");
                        Boolean isAdd = false;
                        if (qof == null)
                        {
                            qof = new MQuantityOfInstrument();
                            isAdd = true;
                        }
                        qof.Qualifier = "MIEX";
                        qof.Quantity = displayData.MinimumExercisableQuantity;
                        qof.QuantityTypeCode = displayData.MinimumExercisableQuantityTypeCode;
                        qof.QuantityCode = displayData.MinimumExercisableQuantityCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.QuantityOfInstrument.Add(qof);
                        }
                    }
                    else
                    {
                        MQuantityOfInstrument qof = mt564.MessageData.CorporateActionDetails.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "MIEX");
                        if (qof != null)
                        {
                            qof.Quantity = null;
                            qof.QuantityTypeCode = null;
                            qof.QuantityCode = null;

                        }
                    }
                    //70a
                    if (mt564.MessageData.CorporateActionDetails.Narrative == null)
                    {
                        mt564.MessageData.CorporateActionDetails.Narrative = new List<MNarrative>();
                    }

                    if (!string.IsNullOrEmpty(displayData.NewCompanyName))
                    {
                        MNarrative narrative = mt564.MessageData.CorporateActionDetails.Narrative.FirstOrDefault(x => x.Qualifier == "NAME");
                        Boolean isAdd = false;
                        if (narrative == null)
                        {
                            narrative = new MNarrative();
                            isAdd = true;
                        }
                        narrative.Qualifier = "NAME";
                        narrative.Narrative = displayData.NewCompanyName;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Narrative.Add(narrative);
                        }
                    }
                    else
                    {
                        MNarrative narrative = mt564.MessageData.CorporateActionDetails.Narrative.FirstOrDefault(x => x.Qualifier == "NAME");
                        if (narrative != null)
                        {
                            narrative.Narrative = null;

                        }
                    }
                    if (!string.IsNullOrEmpty(displayData.Offeror))
                    {
                        MNarrative narrative = mt564.MessageData.CorporateActionDetails.Narrative.FirstOrDefault(x => x.Qualifier == "OFFO");
                        Boolean isAdd = false;
                        if (narrative == null)
                        {
                            narrative = new MNarrative();
                            isAdd = true;
                        }
                        narrative.Qualifier = "OFFO";
                        narrative.Narrative = displayData.Offeror;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Narrative.Add(narrative);
                        }
                    }
                    else
                    {
                        MNarrative narrative = mt564.MessageData.CorporateActionDetails.Narrative.FirstOrDefault(x => x.Qualifier == "OFFO");
                        if (narrative != null)
                        {
                            narrative.Narrative = null;

                        }
                    }

                    //99A
                    if (!string.IsNullOrEmpty(displayData.NumberOfDaysAccrued))
                    {
                        MNumberCount numberCount = mt564.MessageData.CorporateActionDetails.NumberCount;
                        Boolean isAdd = false;

                        if (numberCount == null || numberCount.Qualifier != "DAAC")
                        {
                            numberCount = new MNumberCount();
                            isAdd = true;
                        }
                        numberCount.Qualifier = "DAAC";
                        numberCount.Number = displayData.NumberOfDaysAccrued;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.NumberCount = numberCount;
                        }
                    }
                    else
                    {
                        MNumberCount numberCount = mt564.MessageData.CorporateActionDetails.NumberCount;
                        if (numberCount != null)
                        {
                            numberCount.Number = null;
                        }
                    }

                    //94E - Place
                    mt564.MessageData.CorporateActionDetails.Place = new List<CaapsLinqToDB.DBModels.MPlace>();
                    if (!string.IsNullOrEmpty(displayData.MeetingPlace))
                    {
                        CaapsLinqToDB.DBModels.MPlace place = mt564.MessageData.CorporateActionDetails.Place.FirstOrDefault(x => x.Qualifier == "MEET");
                        Boolean isAdd = false;
                        if (place == null)
                        {
                            place = new CaapsLinqToDB.DBModels.MPlace();
                            isAdd = true;
                        }
                        place.Qualifier = "MEET";
                        place.Address = displayData.MeetingPlace;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Place.Add(place);
                        }

                    }
                    else
                    {
                        CaapsLinqToDB.DBModels.MPlace place = mt564.MessageData.CorporateActionDetails.Place.FirstOrDefault(x => x.Qualifier == "MEET");
                        if (place != null)
                        {
                            place.Address = null;
                        }
                    }



                    if (!string.IsNullOrEmpty(displayData.NewPlaceofIncorporation))
                    {
                        CaapsLinqToDB.DBModels.MPlace place = mt564.MessageData.CorporateActionDetails.Place.FirstOrDefault(x => x.Qualifier == "NPLI");
                        Boolean isAdd = false;
                        if (place == null)
                        {
                            place = new CaapsLinqToDB.DBModels.MPlace();
                            isAdd = true;
                        }
                        place.Qualifier = "NPLI";
                        place.Address = displayData.NewPlaceofIncorporation;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Place.Add(place);
                        }
                    }
                    else
                    {
                        CaapsLinqToDB.DBModels.MPlace place = mt564.MessageData.CorporateActionDetails.Place.FirstOrDefault(x => x.Qualifier == "NPLI");
                        if (place != null)
                        {
                            place.Address = null;
                        }
                    }

                    //98a
                    if (mt564.MessageData.CorporateActionDetails.DateTime == null)
                    {
                        mt564.MessageData.CorporateActionDetails.DateTime = new List<MDateTime>();
                    }

                    if (displayData.AnnouncementDateCode != "NA" && (displayData.AnnouncementDate != null || displayData.AnnouncementDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "ANOU");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "ANOU";
                        if (displayData.AnnouncementDate != null)
                        {
                            dateTime.Date = displayData.AnnouncementDate.Value.ToString("yyyyMMdd");
                            if (displayData.AnnouncementDate.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.AnnouncementDate.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.AnnouncementDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }

                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "ANOU");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }

                    if (displayData.CertificationDeadlineDateCode != "NA" && (displayData.CertificationDeadline != null || displayData.CertificationDeadlineDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "CERT");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "CERT";
                        if (displayData.CertificationDeadline != null)
                        {
                            dateTime.Date = displayData.CertificationDeadline.Value.ToString("yyyyMMdd");
                            if (displayData.CertificationDeadline.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.CertificationDeadline.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.CertificationDeadlineDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "CERT");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }

                    if (displayData.CourtApprovalDateCode != "NA" && (displayData.CourtApprovalDate != null || displayData.CourtApprovalDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "COAP");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "COAP";
                        if (displayData.CourtApprovalDate != null)
                        {
                            dateTime.Date = displayData.CourtApprovalDate.Value.ToString("yyyyMMdd");
                            if (displayData.CourtApprovalDate.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.CourtApprovalDate.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.CourtApprovalDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "COAP");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }


                    if (displayData.DeadlineforTaxBreakdownInstructionsDateCode != "NA" && (displayData.DeadlineforTaxBreakdownInstructions != null || displayData.DeadlineforTaxBreakdownInstructionsDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "TAXB");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "TAXB";
                        if (displayData.DeadlineforTaxBreakdownInstructions != null)
                        {
                            dateTime.Date = displayData.DeadlineforTaxBreakdownInstructions.Value.ToString("yyyyMMdd");
                            if (displayData.DeadlineforTaxBreakdownInstructions.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.DeadlineforTaxBreakdownInstructions.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.AnnouncementDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "TAXB");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }

                    if (displayData.DeadlinetoRegisterDateCode != "NA" && (displayData.DeadlinetoRegister != null || displayData.DeadlinetoRegisterDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "REGI");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "REGI";
                        if (displayData.DeadlinetoRegister != null)
                        {
                            dateTime.Date = displayData.DeadlinetoRegister.Value.ToString("yyyyMMdd");
                            if (displayData.DeadlinetoRegister.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.DeadlinetoRegister.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.DeadlinetoRegisterDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "REGI");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }

                    if (displayData.DeadlinetoSplitDateCode != "NA" && (displayData.DeadlinetoSplit != null || displayData.DeadlinetoSplitDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "SPLT");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "SPLT";
                        if (displayData.DeadlinetoSplit != null)
                        {
                            dateTime.Date = displayData.DeadlinetoSplit.Value.ToString("yyyyMMdd");
                            if (displayData.DeadlinetoSplit.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.DeadlinetoSplit.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.DeadlinetoSplitDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "SPLT");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.EarlyClosingDateCode != "NA" && (displayData.EarlyClosingDate != null || displayData.EarlyClosingDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "ECDT");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "ECDT";
                        if (displayData.EarlyClosingDate != null)
                        {
                            dateTime.Date = displayData.EarlyClosingDate.Value.ToString("yyyyMMdd");
                            if (displayData.EarlyClosingDate.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.EarlyClosingDate.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.EarlyClosingDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "ECDT");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.EarlyThirdPartyDeadlineDateCode != "NA" && (displayData.EarlyThirdPartyDeadline != null || displayData.EarlyThirdPartyDeadlineDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "ETPD");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "ETPD";
                        if (displayData.EarlyThirdPartyDeadline != null)
                        {
                            dateTime.Date = displayData.EarlyThirdPartyDeadline.Value.ToString("yyyyMMdd");
                            if (displayData.EarlyThirdPartyDeadline.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.EarlyThirdPartyDeadline.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.EarlyThirdPartyDeadlineDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "ETPD");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.EffectiveDateCode != "NA" && (displayData.EffectiveDate != null || displayData.EffectiveDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "EFFD");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "EFFD";
                        if (displayData.EffectiveDate != null)
                        {
                            dateTime.Date = displayData.EffectiveDate.Value.ToString("yyyyMMdd");
                            if (displayData.EffectiveDate.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.EffectiveDate.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.EffectiveDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "EFFD");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.ExDateCode != "NA" && (displayData.ExDate != null || displayData.ExDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "XDTE");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "XDTE";
                        if (displayData.ExDate != null)
                        {
                            dateTime.Date = displayData.ExDate.Value.ToString("yyyyMMdd");
                            if (displayData.ExDate.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.ExDate.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.ExDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "XDTE");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.FilingDateCode != "NA" && (displayData.FilingDate != null || displayData.FilingDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "FILL");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "FILL";
                        if (displayData.FilingDate != null)
                        {
                            dateTime.Date = displayData.FilingDate.Value.ToString("yyyyMMdd");
                            if (displayData.FilingDate.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.FilingDate.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.FilingDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "FILL");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.FixingDateCode != "NA" && (displayData.FixingDate != null || displayData.FixingDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "IFIX");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "IFIX";
                        if (displayData.FixingDate != null)
                        {
                            dateTime.Date = displayData.FixingDate.Value.ToString("yyyyMMdd");
                            if (displayData.FixingDate.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.FixingDate.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.FixingDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "IFIX");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.FurtherDetailedAnnouncementDateCode != "NA" && (displayData.FurtherDetailedAnnouncementDate != null || displayData.FurtherDetailedAnnouncementDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "FDAT");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "FDAT";
                        if (displayData.FurtherDetailedAnnouncementDate != null)
                        {
                            dateTime.Date = displayData.FurtherDetailedAnnouncementDate.Value.ToString("yyyyMMdd");
                            if (displayData.FurtherDetailedAnnouncementDate.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.FurtherDetailedAnnouncementDate.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.FurtherDetailedAnnouncementDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "FDAT");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.GuaranteedParticipationDateCode != "NA" && (displayData.GuaranteedParticipationDate != null || displayData.GuaranteedParticipationDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "GUPA");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "GUPA";
                        if (displayData.GuaranteedParticipationDate != null)
                        {
                            dateTime.Date = displayData.GuaranteedParticipationDate.Value.ToString("yyyyMMdd");
                            if (displayData.GuaranteedParticipationDate.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.GuaranteedParticipationDate.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.GuaranteedParticipationDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "GUPA");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.HearingDateCode != "NA" && (displayData.HearingDate != null || displayData.HearingDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "HEAR");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "HEAR";
                        if (displayData.HearingDate != null)
                        {
                            dateTime.Date = displayData.HearingDate.Value.ToString("yyyyMMdd");
                            if (displayData.HearingDate.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.HearingDate.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.HearingDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "HEAR");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.LeadPlaintiffDeadlineDateCode != "NA" && (displayData.LeadPlaintiffDeadline != null || displayData.LeadPlaintiffDeadlineDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "PLDT");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "PLDT";
                        if (displayData.LeadPlaintiffDeadline != null)
                        {
                            dateTime.Date = displayData.LeadPlaintiffDeadline.Value.ToString("yyyyMMdd");
                            if (displayData.LeadPlaintiffDeadline.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.LeadPlaintiffDeadline.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.LeadPlaintiffDeadlineDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "PLDT");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.LotteryDateCode != "NA" && (displayData.LotteryDate != null || displayData.LotteryDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "LOTO");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "LOTO";
                        if (displayData.LotteryDate != null)
                        {
                            dateTime.Date = displayData.LotteryDate.Value.ToString("yyyyMMdd");
                            if (displayData.LotteryDate.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.LotteryDate.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.LotteryDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "LOTO");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.MarketClaimTrackingEndDateCode != "NA" && (displayData.MarketClaimTrackingEndDate != null || displayData.MarketClaimTrackingEndDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "MCTD");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "MCTD";
                        if (displayData.MarketClaimTrackingEndDate != null)
                        {
                            dateTime.Date = displayData.MarketClaimTrackingEndDate.Value.ToString("yyyyMMdd");
                            if (displayData.MarketClaimTrackingEndDate.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.MarketClaimTrackingEndDate.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.MarketClaimTrackingEndDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "MCTD");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.MeetingDateCode != "NA" && (displayData.MeetingDate != null || displayData.MeetingDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "MEET");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "MEET";
                        if (displayData.MeetingDate != null)
                        {
                            dateTime.Date = displayData.MeetingDate.Value.ToString("yyyyMMdd");
                            if (displayData.MeetingDate.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.MeetingDate.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.MeetingDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "MEET");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.NewMaturityDateTimeDateCode != "NA" && (displayData.NewMaturityDateTime != null || displayData.NewMaturityDateTimeDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "MATU");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "MATU";
                        if (displayData.NewMaturityDateTime != null)
                        {
                            dateTime.Date = displayData.NewMaturityDateTime.Value.ToString("yyyyMMdd");
                            if (displayData.NewMaturityDateTime.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.NewMaturityDateTime.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.NewMaturityDateTimeDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "MATU");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.OfficialAnnouncementPublicationDateCode != "NA" && (displayData.OfficialAnnouncementPublicationDate != null || displayData.OfficialAnnouncementPublicationDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "OAPD");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "OAPD";
                        if (displayData.OfficialAnnouncementPublicationDate != null)
                        {
                            dateTime.Date = displayData.OfficialAnnouncementPublicationDate.Value.ToString("yyyyMMdd");
                            if (displayData.OfficialAnnouncementPublicationDate.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.OfficialAnnouncementPublicationDate.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.OfficialAnnouncementPublicationDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "OAPD");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.PaymentDateCode != "NA" && (displayData.PaymentDate != null || displayData.PaymentDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "PAYD");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "PAYD";
                        if (displayData.PaymentDate != null)
                        {
                            dateTime.Date = displayData.PaymentDate.Value.ToString("yyyyMMdd");
                            if (displayData.PaymentDate.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.PaymentDate.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.PaymentDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "PAYD");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.ProrationDateCode != "NA" && (displayData.ProrationDate != null || displayData.ProrationDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "PROD");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "PROD";
                        if (displayData.ProrationDate != null)
                        {
                            dateTime.Date = displayData.ProrationDate.Value.ToString("yyyyMMdd");
                            if (displayData.ProrationDate.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.ProrationDate.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.ProrationDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "PROD");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.RecordDateCode != "NA" && (displayData.RecordDate != null || displayData.RecordDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "RDTE");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "RDTE";
                        if (displayData.RecordDate != null)
                        {
                            dateTime.Date = displayData.RecordDate.Value.ToString("yyyyMMdd");
                            if (displayData.RecordDate.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.RecordDate.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.RecordDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "RDTE");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.ResultsPublicationDateCode != "NA" && (displayData.ResultsPublicationDate != null || displayData.ResultsPublicationDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "RESU");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "RESU";
                        if (displayData.ResultsPublicationDate != null)
                        {
                            dateTime.Date = displayData.ResultsPublicationDate.Value.ToString("yyyyMMdd");
                            if (displayData.ResultsPublicationDate.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.ResultsPublicationDate.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.ResultsPublicationDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "RESU");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.SpecialExDateCode != "NA" && (displayData.SpecialExDate != null || displayData.SpecialExDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "SXDT");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "SXDT";
                        if (displayData.SpecialExDate != null)
                        {
                            dateTime.Date = displayData.SpecialExDate.Value.ToString("yyyyMMdd");
                            if (displayData.SpecialExDate.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.SpecialExDate.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.SpecialExDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "SXDT");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.ThirdPartyDeadlineDateCode != "NA" && (displayData.ThirdPartyDeadline != null || displayData.ThirdPartyDeadlineDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "TPDT");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "TPDT";
                        if (displayData.ThirdPartyDeadline != null)
                        {
                            dateTime.Date = displayData.ThirdPartyDeadline.Value.ToString("yyyyMMdd");
                            if (displayData.ThirdPartyDeadline.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.ThirdPartyDeadline.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.ThirdPartyDeadlineDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "TPDT");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.TradingSuspendedDateCode != "NA" && (displayData.TradingSuspendedDate != null || displayData.TradingSuspendedDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "TSDT");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "TSDT";
                        if (displayData.TradingSuspendedDate != null)
                        {
                            dateTime.Date = displayData.TradingSuspendedDate.Value.ToString("yyyyMMdd");
                            if (displayData.TradingSuspendedDate.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.TradingSuspendedDate.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.TradingSuspendedDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "TSDT");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.UnconditionalDateCode != "NA" && (displayData.UnconditionalDate != null || displayData.UnconditionalDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "UNCO");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "UNCO";
                        if (displayData.UnconditionalDate != null)
                        {
                            dateTime.Date = displayData.UnconditionalDate.Value.ToString("yyyyMMdd");
                            if (displayData.UnconditionalDate.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.UnconditionalDate.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.UnconditionalDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "UNCO");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }
                    if (displayData.WhollyUnconditionalDateCode != "NA" && (displayData.WhollyUnconditionalDate != null || displayData.WhollyUnconditionalDateCode != null))
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "WUCO");
                        Boolean isAdd = false;
                        if (dateTime == null)
                        {
                            dateTime = new MDateTime();
                            isAdd = true;
                        }
                        dateTime.Qualifier = "WUCO";
                        if (displayData.WhollyUnconditionalDate != null)
                        {
                            dateTime.Date = displayData.WhollyUnconditionalDate.Value.ToString("yyyyMMdd");
                            if (displayData.WhollyUnconditionalDate.Value.ToString("HHmmss") != "000000")
                            {
                                dateTime.Time = displayData.WhollyUnconditionalDate.Value.ToString("HHmmss");
                            }
                            else
                            {
                                dateTime.Time = null;
                            }
                        }
                        else
                        {
                            dateTime.Date = null;
                            dateTime.Time = null;
                        }
                        dateTime.DateCode = displayData.WhollyUnconditionalDateCode;
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.DateTime.Add(dateTime);
                        }
                    }
                    else
                    {
                        MDateTime dateTime = mt564.MessageData.CorporateActionDetails.DateTime.FirstOrDefault(x => x.Qualifier == "WUCO");
                        if (dateTime != null)
                        {
                            dateTime.Time = null;
                            dateTime.Date = null;
                            dateTime.DateCode = null;
                        }
                    }



                    //69a - Period

                    if (mt564.MessageData.CorporateActionDetails.Period == null)
                    {
                        mt564.MessageData.CorporateActionDetails.Period = new List<MPeriod>();
                    }

                    if ((displayData.BlockingPeriodFromDateCode != "NA" && displayData.BlockingPeriodToDateCode != "NA") && (displayData.BlockingPeriodFrom != null ||
                    displayData.BlockingPeriodFromDateCode != null ||
                    displayData.BlockingPeriodTo != null ||
                    displayData.BlockingPeriodToDateCode != null))
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "BLOCK");
                        Boolean isAdd = false;
                        if (period == null)
                        {
                            period = new MPeriod();
                            isAdd = true;
                        }

                        period.Qualifier = "BLOCK";
                        if (displayData.BlockingPeriodFrom != null)
                        {
                            period.FromDate = displayData.BlockingPeriodFrom.Value.ToString("yyyyMMdd");
                            if (displayData.BlockingPeriodFrom.Value.ToString("HHmmss") != "000000")
                            {
                                period.FromTime = displayData.BlockingPeriodFrom.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.FromTime = null;
                            }
                        }
                        else
                        {
                            period.FromTime = null;
                            period.FromDate = null;
                        }

                        if (displayData.BlockingPeriodTo != null)
                        {
                            period.ToDate = displayData.BlockingPeriodTo.Value.ToString("yyyyMMdd");
                            if (displayData.BlockingPeriodTo.Value.ToString("HHmmss") != "000000")
                            {
                                period.ToTime = displayData.BlockingPeriodTo.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.ToTime = null;
                            }
                        }
                        else
                        {
                            period.ToTime = null;
                            period.ToDate = null;
                        }

                        if (displayData.BlockingPeriodFromDateCode != null)
                        {
                            period.DateCode = displayData.BlockingPeriodFromDateCode;
                        }
                        else if (displayData.BlockingPeriodToDateCode != null)
                        {
                            period.DateCode = displayData.BlockingPeriodToDateCode;
                        }
                        else
                        {
                            period.DateCode = null;
                        }

                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Period.Add(period);
                        }

                    }
                    else
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "BLOCK");

                        if (period != null)
                        {
                            period.DateCode = null;
                            period.FromDate = null;
                            period.FromTime = null;
                            period.ToDate = null;
                            period.ToTime = null;
                        }
                    }

                    if ((displayData.BookClosurePeriodFromDateCode != "NA" && displayData.BookClosurePeriodToDateCode != "NA") && (displayData.BookClosurePeriodFrom != null ||
                    displayData.BookClosurePeriodToDateCode != null ||
                    displayData.BookClosurePeriodTo != null ||
                    displayData.BookClosurePeriodFromDateCode != null))
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "BOCL");
                        Boolean isAdd = false;
                        if (period == null)
                        {
                            period = new MPeriod();
                            isAdd = true;
                        }
                        period.Qualifier = "BOCL";
                        if (displayData.BookClosurePeriodFrom != null)
                        {
                            period.FromDate = displayData.BookClosurePeriodFrom.Value.ToString("yyyyMMdd");
                            if (displayData.BookClosurePeriodFrom.Value.ToString("HHmmss") != "000000")
                            {
                                period.FromTime = displayData.BookClosurePeriodFrom.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.FromTime = null;
                            }
                        }
                        else
                        {
                            period.FromTime = null;
                            period.FromDate = null;
                        }

                        if (displayData.BookClosurePeriodTo != null)
                        {
                            period.ToDate = displayData.BookClosurePeriodTo.Value.ToString("yyyyMMdd");
                            if (displayData.BookClosurePeriodTo.Value.ToString("HHmmss") != "000000")
                            {
                                period.ToTime = displayData.BookClosurePeriodTo.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.ToTime = null;
                            }
                        }
                        else
                        {
                            period.ToTime = null;
                            period.ToDate = null;
                        }

                        if (displayData.BookClosurePeriodFromDateCode != null)
                        {
                            period.DateCode = displayData.BookClosurePeriodFromDateCode;
                        }
                        else if (displayData.BookClosurePeriodToDateCode != null)
                        {
                            period.DateCode = displayData.BookClosurePeriodToDateCode;
                        }
                        else
                        {
                            period.DateCode = null;
                        }
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Period.Add(period);
                        }
                    }
                    else
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "BOCL");

                        if (period != null)
                        {
                            period.DateCode = null;
                            period.FromDate = null;
                            period.FromTime = null;
                            period.ToDate = null;
                            period.ToTime = null;
                        }
                    }

                    if ((displayData.ClaimPeriodFromDateCode != "NA" && displayData.ClaimPeriodToDateCode != "NA") && (displayData.ClaimPeriodFrom != null ||
                                        displayData.ClaimPeriodFromDateCode != null ||
                                        displayData.ClaimPeriodTo != null ||
                                        displayData.ClaimPeriodToDateCode != null))
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "CLCP");
                        Boolean isAdd = false;
                        if (period == null)
                        {
                            period = new MPeriod();
                            isAdd = true;
                        }
                        period.Qualifier = "CLCP";
                        if (displayData.ClaimPeriodFrom != null)
                        {
                            period.FromDate = displayData.ClaimPeriodFrom.Value.ToString("yyyyMMdd");
                            if (displayData.ClaimPeriodFrom.Value.ToString("HHmmss") != "000000")
                            {
                                period.FromTime = displayData.ClaimPeriodFrom.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.FromTime = null;
                            }
                        }
                        else
                        {
                            period.FromTime = null;
                            period.FromDate = null;
                        }

                        if (displayData.ClaimPeriodTo != null)
                        {
                            period.ToDate = displayData.ClaimPeriodTo.Value.ToString("yyyyMMdd");
                            if (displayData.ClaimPeriodTo.Value.ToString("HHmmss") != "000000")
                            {
                                period.ToTime = displayData.ClaimPeriodTo.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.ToTime = null;
                            }
                        }
                        else
                        {
                            period.ToTime = null;
                            period.ToDate = null;
                        }

                        if (displayData.ClaimPeriodFromDateCode != null)
                        {
                            period.DateCode = displayData.ClaimPeriodFromDateCode;
                        }
                        else if (displayData.ClaimPeriodToDateCode != null)
                        {
                            period.DateCode = displayData.ClaimPeriodToDateCode;
                        }
                        else
                        {
                            period.DateCode = null;
                        }
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Period.Add(period);
                        }
                    }
                    else
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "CLCP");

                        if (period != null)
                        {
                            period.DateCode = null;
                            period.FromDate = null;
                            period.FromTime = null;
                            period.ToDate = null;
                            period.ToTime = null;
                        }
                    }

                    if ((displayData.CoDepositoriesSuspensionPeriodFromDateCode != "NA" && displayData.CoDepositoriesSuspensionPeriodToDateCode != "NA") && (displayData.CoDepositoriesSuspensionPeriodFrom != null ||
                                        displayData.CoDepositoriesSuspensionPeriodFromDateCode != null ||
                                        displayData.CoDepositoriesSuspensionPeriodTo != null ||
                                        displayData.CoDepositoriesSuspensionPeriodToDateCode != null))
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "CODS");
                        Boolean isAdd = false;
                        if (period == null)
                        {
                            period = new MPeriod();
                            isAdd = true;
                        }
                        period.Qualifier = "CODS";
                        if (displayData.CoDepositoriesSuspensionPeriodFrom != null)
                        {
                            period.FromDate = displayData.CoDepositoriesSuspensionPeriodFrom.Value.ToString("yyyyMMdd");
                            if (displayData.CoDepositoriesSuspensionPeriodFrom.Value.ToString("HHmmss") != "000000")
                            {
                                period.FromTime = displayData.CoDepositoriesSuspensionPeriodFrom.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.FromTime = null;
                            }
                        }
                        else
                        {
                            period.FromTime = null;
                            period.FromDate = null;
                        }

                        if (displayData.CoDepositoriesSuspensionPeriodTo != null)
                        {
                            period.ToDate = displayData.CoDepositoriesSuspensionPeriodTo.Value.ToString("yyyyMMdd");
                            if (displayData.CoDepositoriesSuspensionPeriodTo.Value.ToString("HHmmss") != "000000")
                            {
                                period.ToTime = displayData.CoDepositoriesSuspensionPeriodTo.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.ToTime = null;
                            }
                        }
                        else
                        {
                            period.ToTime = null;
                            period.ToDate = null;
                        }

                        if (displayData.CoDepositoriesSuspensionPeriodFromDateCode != null)
                        {
                            period.DateCode = displayData.CoDepositoriesSuspensionPeriodFromDateCode;
                        }
                        else if (displayData.CoDepositoriesSuspensionPeriodToDateCode != null)
                        {
                            period.DateCode = displayData.CoDepositoriesSuspensionPeriodToDateCode;
                        }
                        else
                        {
                            period.DateCode = null;
                        }

                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Period.Add(period);
                        }
                    }
                    else
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "CODS");

                        if (period != null)
                        {
                            period.DateCode = null;
                            period.FromDate = null;
                            period.FromTime = null;
                            period.ToDate = null;
                            period.ToTime = null;
                        }
                    }

                    if ((displayData.CompulsoryPurchasePeriodFromDateCode != "NA" && displayData.CompulsoryPurchasePeriodToDateCode != "NA") && (displayData.CompulsoryPurchasePeriodFrom != null ||
                                        displayData.CompulsoryPurchasePeriodFromDateCode != null ||
                                        displayData.CompulsoryPurchasePeriodTo != null ||
                                        displayData.CompulsoryPurchasePeriodToDateCode != null))
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "CSPD");
                        Boolean isAdd = false;
                        if (period == null)
                        {
                            period = new MPeriod();
                            isAdd = true;
                        }
                        period.Qualifier = "CSPD";
                        if (displayData.CompulsoryPurchasePeriodFrom != null)
                        {
                            period.FromDate = displayData.CompulsoryPurchasePeriodFrom.Value.ToString("yyyyMMdd");
                            if (displayData.CompulsoryPurchasePeriodFrom.Value.ToString("HHmmss") != "000000")
                            {
                                period.FromTime = displayData.CompulsoryPurchasePeriodFrom.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.FromTime = null;
                            }
                        }
                        else
                        {
                            period.FromTime = null;
                            period.FromDate = null;
                        }

                        if (displayData.CompulsoryPurchasePeriodTo != null)
                        {
                            period.ToDate = displayData.CompulsoryPurchasePeriodTo.Value.ToString("yyyyMMdd");
                            if (displayData.CompulsoryPurchasePeriodTo.Value.ToString("HHmmss") != "000000")
                            {
                                period.ToTime = displayData.CompulsoryPurchasePeriodTo.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.ToTime = null;
                            }
                        }
                        else
                        {
                            period.ToTime = null;
                            period.ToDate = null;
                        }

                        if (displayData.CompulsoryPurchasePeriodFromDateCode != null)
                        {
                            period.DateCode = displayData.CompulsoryPurchasePeriodFromDateCode;
                        }
                        else if (displayData.CompulsoryPurchasePeriodToDateCode != null)
                        {
                            period.DateCode = displayData.CompulsoryPurchasePeriodToDateCode;
                        }
                        else
                        {
                            period.DateCode = null;
                        }

                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Period.Add(period);
                        }
                    }
                    else
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "CSPD");

                        if (period != null)
                        {
                            period.DateCode = null;
                            period.FromDate = null;
                            period.FromTime = null;
                            period.ToDate = null;
                            period.ToTime = null;
                        }
                    }

                    if ((displayData.DepositorySuspensionPeriodForBookEntryTransferFromDateCode != "NA" && displayData.DepositorySuspensionPeriodForBookEntryTransferToDateCode != "NA") && (displayData.DepositorySuspensionPeriodForBookEntryTransferFrom != null ||
                                        displayData.DepositorySuspensionPeriodForBookEntryTransferFromDateCode != null ||
                                        displayData.DepositorySuspensionPeriodForBookEntryTransferTo != null ||
                                        displayData.DepositorySuspensionPeriodForBookEntryTransferToDateCode != null))
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "DSBT");
                        Boolean isAdd = false;
                        if (period == null)
                        {
                            period = new MPeriod();
                            isAdd = true;
                        }
                        period.Qualifier = "DSBT";
                        if (displayData.DepositorySuspensionPeriodForBookEntryTransferFrom != null)
                        {
                            period.FromDate = displayData.DepositorySuspensionPeriodForBookEntryTransferFrom.Value.ToString("yyyyMMdd");
                            if (displayData.DepositorySuspensionPeriodForBookEntryTransferFrom.Value.ToString("HHmmss") != "000000")
                            {
                                period.FromTime = displayData.DepositorySuspensionPeriodForBookEntryTransferFrom.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.FromTime = null;
                            }
                        }
                        else
                        {
                            period.FromTime = null;
                            period.FromDate = null;
                        }

                        if (displayData.DepositorySuspensionPeriodForBookEntryTransferTo != null)
                        {
                            period.ToDate = displayData.DepositorySuspensionPeriodForBookEntryTransferTo.Value.ToString("yyyyMMdd");
                            if (displayData.DepositorySuspensionPeriodForBookEntryTransferTo.Value.ToString("HHmmss") != "000000")
                            {
                                period.ToTime = displayData.DepositorySuspensionPeriodForBookEntryTransferTo.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.ToTime = null;
                            }
                        }
                        else
                        {
                            period.ToTime = null;
                            period.ToDate = null;
                        }

                        if (displayData.DepositorySuspensionPeriodForBookEntryTransferFromDateCode != null)
                        {
                            period.DateCode = displayData.DepositorySuspensionPeriodForBookEntryTransferFromDateCode;
                        }
                        else if (displayData.DepositorySuspensionPeriodForBookEntryTransferToDateCode != null)
                        {
                            period.DateCode = displayData.DepositorySuspensionPeriodForBookEntryTransferToDateCode;
                        }
                        else
                        {
                            period.DateCode = null;
                        }
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Period.Add(period);
                        }
                    }
                    else
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "DSBT");

                        if (period != null)
                        {
                            period.DateCode = null;
                            period.FromDate = null;
                            period.FromTime = null;
                            period.ToDate = null;
                            period.ToTime = null;
                        }
                    }

                    if ((displayData.DepositorySuspensionPeriodforDepositatAgentFromDateCode != "NA" && displayData.DepositorySuspensionPeriodforDepositatAgentToDateCode != "NA") && (displayData.DepositorySuspensionPeriodforDepositatAgentFrom != null ||
                                        displayData.DepositorySuspensionPeriodforDepositatAgentFromDateCode != null ||
                                        displayData.DepositorySuspensionPeriodforDepositatAgentTo != null ||
                                        displayData.DepositorySuspensionPeriodforDepositatAgentToDateCode != null))
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "DSDA");
                        Boolean isAdd = false;
                        if (period == null)
                        {
                            period = new MPeriod();
                            isAdd = true;
                        }
                        period.Qualifier = "DSDA";
                        if (displayData.DepositorySuspensionPeriodforDepositatAgentFrom != null)
                        {
                            period.FromDate = displayData.DepositorySuspensionPeriodforDepositatAgentFrom.Value.ToString("yyyyMMdd");
                            if (displayData.DepositorySuspensionPeriodforDepositatAgentFrom.Value.ToString("HHmmss") != "000000")
                            {
                                period.FromTime = displayData.DepositorySuspensionPeriodforDepositatAgentFrom.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.FromTime = null;
                            }
                        }
                        else
                        {
                            period.FromTime = null;
                            period.FromDate = null;
                        }

                        if (displayData.DepositorySuspensionPeriodforDepositatAgentTo != null)
                        {
                            period.ToDate = displayData.DepositorySuspensionPeriodforDepositatAgentTo.Value.ToString("yyyyMMdd");
                            if (displayData.DepositorySuspensionPeriodforDepositatAgentTo.Value.ToString("HHmmss") != "000000")
                            {
                                period.ToTime = displayData.DepositorySuspensionPeriodforDepositatAgentTo.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.ToTime = null;
                            }
                        }
                        else
                        {
                            period.ToTime = null;
                            period.ToDate = null;
                        }

                        if (displayData.DepositorySuspensionPeriodforDepositatAgentFromDateCode != null)
                        {
                            period.DateCode = displayData.DepositorySuspensionPeriodforDepositatAgentFromDateCode;
                        }
                        else if (displayData.DepositorySuspensionPeriodforDepositatAgentToDateCode != null)
                        {
                            period.DateCode = displayData.DepositorySuspensionPeriodforDepositatAgentToDateCode;
                        }
                        else
                        {
                            period.DateCode = null;
                        }
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Period.Add(period);
                        }
                    }
                    else
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "DSDA");

                        if (period != null)
                        {
                            period.DateCode = null;
                            period.FromDate = null;
                            period.FromTime = null;
                            period.ToDate = null;
                            period.ToTime = null;
                        }
                    }

                    if ((displayData.DepositorySuspensionPeriodForDepositFromDateCode != "NA" && displayData.DepositorySuspensionPeriodForDepositToDateCode != "NA") && (displayData.DepositorySuspensionPeriodForDepositFrom != null ||
                                        displayData.DepositorySuspensionPeriodForDepositFromDateCode != null ||
                                        displayData.DepositorySuspensionPeriodForDepositTo != null ||
                                        displayData.DepositorySuspensionPeriodForDepositToDateCode != null))
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "DSDE");
                        Boolean isAdd = false;
                        if (period == null)
                        {
                            period = new MPeriod();
                            isAdd = true;
                        }
                        period.Qualifier = "DSDE";
                        if (displayData.DepositorySuspensionPeriodForDepositFrom != null)
                        {
                            period.FromDate = displayData.DepositorySuspensionPeriodForDepositFrom.Value.ToString("yyyyMMdd");
                            if (displayData.DepositorySuspensionPeriodForDepositFrom.Value.ToString("HHmmss") != "000000")
                            {
                                period.FromTime = displayData.DepositorySuspensionPeriodForDepositFrom.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.FromTime = null;
                            }
                        }
                        else
                        {
                            period.FromTime = null;
                            period.FromDate = null;
                        }

                        if (displayData.DepositorySuspensionPeriodForDepositTo != null)
                        {
                            period.ToDate = displayData.DepositorySuspensionPeriodForDepositTo.Value.ToString("yyyyMMdd");
                            if (displayData.DepositorySuspensionPeriodForDepositTo.Value.ToString("HHmmss") != "000000")
                            {
                                period.ToTime = displayData.DepositorySuspensionPeriodForDepositTo.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.ToTime = null;
                            }
                        }
                        else
                        {
                            period.ToTime = null;
                            period.ToDate = null;
                        }

                        if (displayData.DepositorySuspensionPeriodForDepositFromDateCode != null)
                        {
                            period.DateCode = displayData.DepositorySuspensionPeriodForDepositFromDateCode;
                        }
                        else if (displayData.DepositorySuspensionPeriodForDepositToDateCode != null)
                        {
                            period.DateCode = displayData.DepositorySuspensionPeriodForDepositToDateCode;
                        }
                        else
                        {
                            period.DateCode = null;
                        }
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Period.Add(period);
                        }
                    }
                    else
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "DSDE");

                        if (period != null)
                        {
                            period.DateCode = null;
                            period.FromDate = null;
                            period.FromTime = null;
                            period.ToDate = null;
                            period.ToTime = null;
                        }
                    }

                    if ((displayData.DepositorySuspensionPeriodForPledgeFromDateCode != "NA" && displayData.DepositorySuspensionPeriodForPledgeToDateCode != "NA") && (displayData.DepositorySuspensionPeriodForPledgeFrom != null ||
                                        displayData.DepositorySuspensionPeriodForPledgeFromDateCode != null ||
                                        displayData.DepositorySuspensionPeriodForPledgeTo != null ||
                                        displayData.DepositorySuspensionPeriodForPledgeToDateCode != null))
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "DSPL");
                        Boolean isAdd = false;
                        if (period == null)
                        {
                            period = new MPeriod();
                            isAdd = true;
                        }
                        period.Qualifier = "DSPL";
                        if (displayData.DepositorySuspensionPeriodForPledgeFrom != null)
                        {
                            period.FromDate = displayData.DepositorySuspensionPeriodForPledgeFrom.Value.ToString("yyyyMMdd");
                            if (displayData.DepositorySuspensionPeriodForPledgeFrom.Value.ToString("HHmmss") != "000000")
                            {
                                period.FromTime = displayData.DepositorySuspensionPeriodForPledgeFrom.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.FromTime = null;
                            }
                        }
                        else
                        {
                            period.FromTime = null;
                            period.FromDate = null;
                        }

                        if (displayData.DepositorySuspensionPeriodForPledgeTo != null)
                        {
                            period.ToDate = displayData.DepositorySuspensionPeriodForPledgeTo.Value.ToString("yyyyMMdd");
                            if (displayData.DepositorySuspensionPeriodForPledgeTo.Value.ToString("HHmmss") != "000000")
                            {
                                period.ToTime = displayData.DepositorySuspensionPeriodForPledgeTo.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.ToTime = null;
                            }
                        }
                        else
                        {
                            period.ToTime = null;
                            period.ToDate = null;
                        }

                        if (displayData.DepositorySuspensionPeriodForPledgeFromDateCode != null)
                        {
                            period.DateCode = displayData.DepositorySuspensionPeriodForPledgeFromDateCode;
                        }
                        else if (displayData.DepositorySuspensionPeriodForPledgeToDateCode != null)
                        {
                            period.DateCode = displayData.DepositorySuspensionPeriodForPledgeToDateCode;
                        }
                        else
                        {
                            period.DateCode = null;
                        }
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Period.Add(period);
                        }
                    }
                    else
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "DSPL");

                        if (period != null)
                        {
                            period.DateCode = null;
                            period.FromDate = null;
                            period.FromTime = null;
                            period.ToDate = null;
                            period.ToTime = null;
                        }
                    }

                    if ((displayData.DepositorySuspensionPeriodForSegregationFromDateCode != "NA" && displayData.DepositorySuspensionPeriodForSegregationToDateCode != "NA") && (displayData.DepositorySuspensionPeriodForSegregationFrom != null ||
                                        displayData.DepositorySuspensionPeriodForSegregationFromDateCode != null ||
                                        displayData.DepositorySuspensionPeriodForSegregationTo != null ||
                                        displayData.DepositorySuspensionPeriodForSegregationToDateCode != null))
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "DSSE");
                        Boolean isAdd = false;
                        if (period == null)
                        {
                            period = new MPeriod();
                            isAdd = true;
                        }
                        period.Qualifier = "DSSE";
                        if (displayData.DepositorySuspensionPeriodForSegregationFrom != null)
                        {
                            period.FromDate = displayData.DepositorySuspensionPeriodForSegregationFrom.Value.ToString("yyyyMMdd");
                            if (displayData.DepositorySuspensionPeriodForSegregationFrom.Value.ToString("HHmmss") != "000000")
                            {
                                period.FromTime = displayData.DepositorySuspensionPeriodForSegregationFrom.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.FromTime = null;
                            }
                        }
                        else
                        {
                            period.FromTime = null;
                            period.FromDate = null;
                        }

                        if (displayData.DepositorySuspensionPeriodForSegregationTo != null)
                        {
                            period.ToDate = displayData.DepositorySuspensionPeriodForSegregationTo.Value.ToString("yyyyMMdd");
                            if (displayData.DepositorySuspensionPeriodForSegregationTo.Value.ToString("HHmmss") != "000000")
                            {
                                period.ToTime = displayData.DepositorySuspensionPeriodForSegregationTo.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.ToTime = null;
                            }
                        }
                        else
                        {
                            period.ToTime = null;
                            period.ToDate = null;
                        }

                        if (displayData.DepositorySuspensionPeriodForSegregationFromDateCode != null)
                        {
                            period.DateCode = displayData.DepositorySuspensionPeriodForSegregationFromDateCode;
                        }
                        else if (displayData.DepositorySuspensionPeriodForSegregationToDateCode != null)
                        {
                            period.DateCode = displayData.DepositorySuspensionPeriodForSegregationToDateCode;
                        }
                        else
                        {
                            period.DateCode = null;
                        }
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Period.Add(period);
                        }
                    }
                    else
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "DSSE");

                        if (period != null)
                        {
                            period.DateCode = null;
                            period.FromDate = null;
                            period.FromTime = null;
                            period.ToDate = null;
                            period.ToTime = null;
                        }
                    }

                    if ((displayData.DepositorySuspensionPeriodforWithdrawalatAgentFromDateCode != "NA" && displayData.DepositorySuspensionPeriodforWithdrawalatAgentToDateCode != "NA") && (displayData.DepositorySuspensionPeriodforWithdrawalatAgentFrom != null ||
                                        displayData.DepositorySuspensionPeriodforWithdrawalatAgentFromDateCode != null ||
                                        displayData.DepositorySuspensionPeriodforWithdrawalatAgentTo != null ||
                                        displayData.DepositorySuspensionPeriodforWithdrawalatAgentToDateCode != null))
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "DSWA");
                        Boolean isAdd = false;
                        if (period == null)
                        {
                            period = new MPeriod();
                            isAdd = true;
                        }
                        period.Qualifier = "DSWA";
                        if (displayData.DepositorySuspensionPeriodforWithdrawalatAgentFrom != null)
                        {
                            period.FromDate = displayData.DepositorySuspensionPeriodforWithdrawalatAgentFrom.Value.ToString("yyyyMMdd");
                            if (displayData.DepositorySuspensionPeriodforWithdrawalatAgentFrom.Value.ToString("HHmmss") != "000000")
                            {
                                period.FromTime = displayData.DepositorySuspensionPeriodforWithdrawalatAgentFrom.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.FromTime = null;
                            }
                        }
                        else
                        {
                            period.FromTime = null;
                            period.FromDate = null;
                        }

                        if (displayData.DepositorySuspensionPeriodforWithdrawalatAgentTo != null)
                        {
                            period.ToDate = displayData.DepositorySuspensionPeriodforWithdrawalatAgentTo.Value.ToString("yyyyMMdd");
                            if (displayData.DepositorySuspensionPeriodforWithdrawalatAgentTo.Value.ToString("HHmmss") != "000000")
                            {
                                period.ToTime = displayData.DepositorySuspensionPeriodforWithdrawalatAgentTo.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.ToTime = null;
                            }
                        }
                        else
                        {
                            period.ToTime = null;
                            period.ToDate = null;
                        }

                        if (displayData.DepositorySuspensionPeriodforWithdrawalatAgentFromDateCode != null)
                        {
                            period.DateCode = displayData.DepositorySuspensionPeriodforWithdrawalatAgentFromDateCode;
                        }
                        else if (displayData.DepositorySuspensionPeriodforWithdrawalatAgentToDateCode != null)
                        {
                            period.DateCode = displayData.DepositorySuspensionPeriodforWithdrawalatAgentToDateCode;
                        }
                        else
                        {
                            period.DateCode = null;
                        }
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Period.Add(period);
                        }
                    }
                    else
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "DSWA");

                        if (period != null)
                        {
                            period.DateCode = null;
                            period.FromDate = null;
                            period.FromTime = null;
                            period.ToDate = null;
                            period.ToTime = null;
                        }
                    }

                    if ((displayData.DepositorySuspensionPeriodForWithdrawalInNomineeNameFromDateCode != "NA" && displayData.DepositorySuspensionPeriodForWithdrawalInNomineeNameToDateCode != "NA") && (displayData.DepositorySuspensionPeriodForWithdrawalInNomineeNameFrom != null ||
                                        displayData.DepositorySuspensionPeriodForWithdrawalInNomineeNameFromDateCode != null ||
                                        displayData.DepositorySuspensionPeriodForWithdrawalInNomineeNameTo != null ||
                                        displayData.DepositorySuspensionPeriodForWithdrawalInNomineeNameToDateCode != null))
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "DSWN");
                        Boolean isAdd = false;
                        if (period == null)
                        {
                            period = new MPeriod();
                            isAdd = true;
                        }
                        period.Qualifier = "DSWN";
                        if (displayData.DepositorySuspensionPeriodForWithdrawalInNomineeNameFrom != null)
                        {
                            period.FromDate = displayData.DepositorySuspensionPeriodForWithdrawalInNomineeNameFrom.Value.ToString("yyyyMMdd");
                            if (displayData.DepositorySuspensionPeriodForWithdrawalInNomineeNameFrom.Value.ToString("HHmmss") != "000000")
                            {
                                period.FromTime = displayData.DepositorySuspensionPeriodForWithdrawalInNomineeNameFrom.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.FromTime = null;
                            }
                        }
                        else
                        {
                            period.FromTime = null;
                            period.FromDate = null;
                        }

                        if (displayData.DepositorySuspensionPeriodForWithdrawalInNomineeNameTo != null)
                        {
                            period.ToDate = displayData.DepositorySuspensionPeriodForWithdrawalInNomineeNameTo.Value.ToString("yyyyMMdd");
                            if (displayData.DepositorySuspensionPeriodForWithdrawalInNomineeNameTo.Value.ToString("HHmmss") != "000000")
                            {
                                period.ToTime = displayData.DepositorySuspensionPeriodForWithdrawalInNomineeNameTo.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.ToTime = null;
                            }
                        }
                        else
                        {
                            period.ToTime = null;
                            period.ToDate = null;
                        }

                        if (displayData.DepositorySuspensionPeriodForWithdrawalInNomineeNameFromDateCode != null)
                        {
                            period.DateCode = displayData.DepositorySuspensionPeriodForWithdrawalInNomineeNameFromDateCode;
                        }
                        else if (displayData.DepositorySuspensionPeriodForWithdrawalInNomineeNameToDateCode != null)
                        {
                            period.DateCode = displayData.DepositorySuspensionPeriodForWithdrawalInNomineeNameToDateCode;
                        }
                        else
                        {
                            period.DateCode = null;
                        }
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Period.Add(period);
                        }
                    }
                    else
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "DSWN");

                        if (period != null)
                        {
                            period.DateCode = null;
                            period.FromDate = null;
                            period.FromTime = null;
                            period.ToDate = null;
                            period.ToTime = null;
                        }
                    }

                    if ((displayData.DepositorySuspensionPeriodForWithdrawalInStreetNameFromDateCode != "NA" && displayData.DepositorySuspensionPeriodForWithdrawalInStreetNameToDateCode != "NA") && (displayData.DepositorySuspensionPeriodForWithdrawalInStreetNameFrom != null ||
                                        displayData.DepositorySuspensionPeriodForWithdrawalInStreetNameFromDateCode != null ||
                                        displayData.DepositorySuspensionPeriodForWithdrawalInStreetNameTo != null ||
                                        displayData.DepositorySuspensionPeriodForWithdrawalInStreetNameToDateCode != null))
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "DSWS");
                        Boolean isAdd = false;
                        if (period == null)
                        {
                            period = new MPeriod();
                            isAdd = true;
                        }
                        period.Qualifier = "DSWS";
                        if (displayData.DepositorySuspensionPeriodForWithdrawalInStreetNameFrom != null)
                        {
                            period.FromDate = displayData.DepositorySuspensionPeriodForWithdrawalInStreetNameFrom.Value.ToString("yyyyMMdd");
                            if (displayData.DepositorySuspensionPeriodForWithdrawalInStreetNameFrom.Value.ToString("HHmmss") != "000000")
                            {
                                period.FromTime = displayData.DepositorySuspensionPeriodForWithdrawalInStreetNameFrom.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.FromTime = null;
                            }
                        }
                        else
                        {
                            period.FromTime = null;
                            period.FromDate = null;
                        }

                        if (displayData.DepositorySuspensionPeriodForWithdrawalInStreetNameTo != null)
                        {
                            period.ToDate = displayData.DepositorySuspensionPeriodForWithdrawalInStreetNameTo.Value.ToString("yyyyMMdd");
                            if (displayData.DepositorySuspensionPeriodForWithdrawalInStreetNameTo.Value.ToString("HHmmss") != "000000")
                            {
                                period.ToTime = displayData.DepositorySuspensionPeriodForWithdrawalInStreetNameTo.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.ToTime = null;
                            }
                        }
                        else
                        {
                            period.ToTime = null;
                            period.ToDate = null;
                        }

                        if (displayData.DepositorySuspensionPeriodForWithdrawalInStreetNameFromDateCode != null)
                        {
                            period.DateCode = displayData.DepositorySuspensionPeriodForWithdrawalInStreetNameFromDateCode;
                        }
                        else if (displayData.DepositorySuspensionPeriodForWithdrawalInStreetNameToDateCode != null)
                        {
                            period.DateCode = displayData.DepositorySuspensionPeriodForWithdrawalInStreetNameToDateCode;
                        }
                        else
                        {
                            period.DateCode = null;
                        }
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Period.Add(period);
                        }
                    }
                    else
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "DSWS");

                        if (period != null)
                        {
                            period.DateCode = null;
                            period.FromDate = null;
                            period.FromTime = null;
                            period.ToDate = null;
                            period.ToTime = null;
                        }
                    }

                    if ((displayData.InterestPeriodFromDateCode != "NA" && displayData.InterestPeriodToDateCode != "NA") && (displayData.InterestPeriodFrom != null ||
                                        displayData.InterestPeriodFromDateCode != null ||
                                        displayData.InterestPeriodTo != null ||
                                        displayData.InterestPeriodToDateCode != null))
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "INPE");
                        Boolean isAdd = false;
                        if (period == null)
                        {
                            period = new MPeriod();
                            isAdd = true;
                        }
                        period.Qualifier = "INPE";
                        if (displayData.InterestPeriodFrom != null)
                        {
                            period.FromDate = displayData.InterestPeriodFrom.Value.ToString("yyyyMMdd");
                            if (displayData.InterestPeriodFrom.Value.ToString("HHmmss") != "000000")
                            {
                                period.FromTime = displayData.InterestPeriodFrom.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.FromTime = null;
                            }
                        }
                        else
                        {
                            period.FromTime = null;
                            period.FromDate = null;
                        }

                        if (displayData.InterestPeriodTo != null)
                        {
                            period.ToDate = displayData.InterestPeriodTo.Value.ToString("yyyyMMdd");
                            if (displayData.InterestPeriodTo.Value.ToString("HHmmss") != "000000")
                            {
                                period.ToTime = displayData.InterestPeriodTo.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.ToTime = null;
                            }
                        }
                        else
                        {
                            period.ToTime = null;
                            period.ToDate = null;
                        }

                        if (displayData.InterestPeriodFromDateCode != null)
                        {
                            period.DateCode = displayData.InterestPeriodFromDateCode;
                        }
                        else if (displayData.InterestPeriodToDateCode != null)
                        {
                            period.DateCode = displayData.InterestPeriodToDateCode;
                        }
                        else
                        {
                            period.DateCode = null;
                        }
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Period.Add(period);
                        }
                    }
                    else
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "INPE");

                        if (period != null)
                        {
                            period.DateCode = null;
                            period.FromDate = null;
                            period.FromTime = null;
                            period.ToDate = null;
                            period.ToTime = null;
                        }
                    }

                    if ((displayData.PriceCalculationPeriodFromDateCode != "NA" && displayData.PriceCalculationPeriodToDateCode != "NA") && (displayData.PriceCalculationPeriodFrom != null ||
                                        displayData.PriceCalculationPeriodFromDateCode != null ||
                                        displayData.PriceCalculationPeriodTo != null ||
                                        displayData.PriceCalculationPeriodToDateCode != null))
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "PRIC");
                        Boolean isAdd = false;
                        if (period == null)
                        {
                            period = new MPeriod();
                            isAdd = true;
                        }
                        period.Qualifier = "PRIC";
                        if (displayData.PriceCalculationPeriodFrom != null)
                        {
                            period.FromDate = displayData.PriceCalculationPeriodFrom.Value.ToString("yyyyMMdd");
                            if (displayData.PriceCalculationPeriodFrom.Value.ToString("HHmmss") != "000000")
                            {
                                period.FromTime = displayData.PriceCalculationPeriodFrom.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.FromTime = null;
                            }
                        }
                        else
                        {
                            period.FromTime = null;
                            period.FromDate = null;
                        }

                        if (displayData.PriceCalculationPeriodTo != null)
                        {
                            period.ToDate = displayData.PriceCalculationPeriodTo.Value.ToString("yyyyMMdd");
                            if (displayData.PriceCalculationPeriodTo.Value.ToString("HHmmss") != "000000")
                            {
                                period.ToTime = displayData.PriceCalculationPeriodTo.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.ToTime = null;
                            }
                        }
                        else
                        {
                            period.ToTime = null;
                            period.ToDate = null;
                        }

                        if (displayData.PriceCalculationPeriodFromDateCode != null)
                        {
                            period.DateCode = displayData.PriceCalculationPeriodFromDateCode;
                        }
                        else if (displayData.PriceCalculationPeriodToDateCode != null)
                        {
                            period.DateCode = displayData.PriceCalculationPeriodToDateCode;
                        }
                        else
                        {
                            period.DateCode = null;
                        }
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Period.Add(period);
                        }
                    }
                    else
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "PRIC");

                        if (period != null)
                        {
                            period.DateCode = null;
                            period.FromDate = null;
                            period.FromTime = null;
                            period.ToDate = null;
                            period.ToTime = null;
                        }
                    }

                    if ((displayData.SplitPeriodFromDateCode != "NA" && displayData.SplitPeriodToDateCode != "NA") && (displayData.SplitPeriodFrom != null ||
                                        displayData.SplitPeriodFromDateCode != null ||
                                        displayData.SplitPeriodTo != null ||
                                        displayData.SplitPeriodToDateCode != null))
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "SPLP");
                        Boolean isAdd = false;
                        if (period == null)
                        {
                            period = new MPeriod();
                            isAdd = true;
                        }
                        period.Qualifier = "SPLP";
                        if (displayData.SplitPeriodFrom != null)
                        {
                            period.FromDate = displayData.SplitPeriodFrom.Value.ToString("yyyyMMdd");
                            if (displayData.SplitPeriodFrom.Value.ToString("HHmmss") != "000000")
                            {
                                period.FromTime = displayData.SplitPeriodFrom.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.FromTime = null;
                            }
                        }
                        else
                        {
                            period.FromTime = null;
                            period.FromDate = null;
                        }

                        if (displayData.SplitPeriodTo != null)
                        {
                            period.ToDate = displayData.SplitPeriodTo.Value.ToString("yyyyMMdd");
                            if (displayData.SplitPeriodTo.Value.ToString("HHmmss") != "000000")
                            {
                                period.ToTime = displayData.SplitPeriodTo.Value.ToString("HHmmss");
                            }
                            else
                            {
                                period.ToTime = null;
                            }
                        }
                        else
                        {
                            period.ToTime = null;
                            period.ToDate = null;
                        }

                        if (displayData.SplitPeriodFromDateCode != null)
                        {
                            period.DateCode = displayData.SplitPeriodFromDateCode;
                        }
                        else if (displayData.SplitPeriodToDateCode != null)
                        {
                            period.DateCode = displayData.SplitPeriodToDateCode;
                        }
                        else
                        {
                            period.DateCode = null;
                        }
                        if (isAdd)
                        {
                            mt564.MessageData.CorporateActionDetails.Period.Add(period);
                        }
                    }
                    else
                    {
                        MPeriod period = mt564.MessageData.CorporateActionDetails.Period.FirstOrDefault(x => x.Qualifier == "SPLP");

                        if (period != null)
                        {
                            period.DateCode = null;
                            period.FromDate = null;
                            period.FromTime = null;
                            period.ToDate = null;
                            period.ToTime = null;
                        }
                    }




                    if (mt564.MessageData.CorporateActionOptions == null)
                    {
                        mt564.MessageData.CorporateActionOptions = new List<MCorporateActionOption>();
                    }
                    foreach (CAOptions option in displayData.Options)
                    {
                        MCorporateActionOption mCorporateActionOption = mt564.MessageData.CorporateActionOptions.FirstOrDefault(x => x != null ? x.CaoptionNumber.NumberId == option.CaOptOptionNumber : false);
                        Boolean isOptionAdd = false;
                        if (mCorporateActionOption == null)
                        {
                            mCorporateActionOption = new MCorporateActionOption();
                            isOptionAdd = true;
                        }

                        //11A
                        mCorporateActionOption.Currency = option.CaOptCurrencyOption;
                        //13A
                        if (option.CaOptOptionNumber == null)
                        {
                            mCorporateActionOption.CaoptionNumber = new MCAOptionNumber();
                            List<Int64> numbers = mt564.MessageData.CorporateActionOptions.Select(x => Int64.Parse(x.CaoptionNumber.NumberId)).ToList();
                            Int64 MaxNumber = numbers.Max();
                            if (MaxNumber != 999)
                            {
                                mCorporateActionOption.CaoptionNumber.NumberId = (MaxNumber + 1).ToString("000");
                            }
                            else
                            {
                                MaxNumber = numbers.Where(x => x < MaxNumber).Max();
                                mCorporateActionOption.CaoptionNumber.NumberId = (MaxNumber + 1).ToString("000");
                            }

                            mCorporateActionOption.CaoptionNumber.Qualifier = "CAON";

                        }
                        else if (option.CaOptOptionNumber != null)
                        {
                            if (mCorporateActionOption.CaoptionNumber == null)
                            {
                                mCorporateActionOption.CaoptionNumber = new MCAOptionNumber();
                            }
                            mCorporateActionOption.CaoptionNumber.NumberId = option.CaOptOptionNumber;
                            mCorporateActionOption.CaoptionNumber.Qualifier = "CAON";
                        }

                        //17B
                        if (mCorporateActionOption.Flag == null)
                        {
                            mCorporateActionOption.Flag = new List<MFlag>();
                        }
                        if (option.CaOptCertificationBreakdown != null && option.CaOptCertificationBreakdown != "NA")
                        {
                            MFlag mFlag = mCorporateActionOption.Flag.FirstOrDefault(x => x.Qualifier == "CERT");
                            Boolean isAdd = false;
                            if (mFlag == null)
                            {
                                mFlag = new MFlag();
                                isAdd = true;
                            }
                            mFlag.Qualifier = "CERT";
                            mFlag.Flag = option.CaOptCertificationBreakdown;
                            if (isAdd)
                            {
                                mCorporateActionOption.Flag.Add(mFlag);
                            }
                        }
                        else
                        {
                            MFlag mFlag = mCorporateActionOption.Flag.FirstOrDefault(x => x.Qualifier == "CERT");
                            if (mFlag != null)
                            {
                                mFlag.Flag = null;
                            }
                        }

                        if (option.CaOptChangeAllowed != null && option.CaOptChangeAllowed != "NA")
                        {
                            MFlag mFlag = mCorporateActionOption.Flag.FirstOrDefault(x => x.Qualifier == "CHAN");
                            Boolean isAdd = false;
                            if (mFlag == null)
                            {
                                mFlag = new MFlag();
                                isAdd = true;
                            }
                            mFlag.Qualifier = "CHAN";
                            mFlag.Flag = option.CaOptChangeAllowed;
                            if (isAdd)
                            {
                                mCorporateActionOption.Flag.Add(mFlag);
                            }
                        }
                        else
                        {
                            MFlag mFlag = mCorporateActionOption.Flag.FirstOrDefault(x => x.Qualifier == "CHAN");
                            if (mFlag != null)
                            {
                                mFlag.Flag = null;
                            }
                        }


                        if (option.CaOptDefaultOption != null && option.CaOptDefaultOption != "NA")
                        {
                            MFlag mFlag = mCorporateActionOption.Flag.FirstOrDefault(x => x.Qualifier == "DFLT");
                            Boolean isAdd = false;
                            if (mFlag == null)
                            {
                                mFlag = new MFlag();
                                isAdd = true;
                            }
                            mFlag.Qualifier = "DFLT";
                            mFlag.Flag = option.CaOptDefaultOption;
                            if (isAdd)
                            {
                                mCorporateActionOption.Flag.Add(mFlag);
                            }
                        }
                        else
                        {
                            MFlag mFlag = mCorporateActionOption.Flag.FirstOrDefault(x => x.Qualifier == "DFLT");
                            if (mFlag != null)
                            {
                                mFlag.Flag = null;
                            }
                        }


                        if (option.CaOptWithdrawalAllowed != null && option.CaOptWithdrawalAllowed != "NA")
                        {
                            MFlag mFlag = mCorporateActionOption.Flag.FirstOrDefault(x => x.Qualifier == "WTHD");
                            Boolean isAdd = false;
                            if (mFlag == null)
                            {
                                mFlag = new MFlag();
                                isAdd = true;
                            }
                            mFlag.Qualifier = "WTHD";
                            mFlag.Flag = option.CaOptWithdrawalAllowed;
                            if (isAdd)
                            {
                                mCorporateActionOption.Flag.Add(mFlag);
                            }
                        }
                        else
                        {
                            MFlag mFlag = mCorporateActionOption.Flag.FirstOrDefault(x => x.Qualifier == "WTHD");
                            if (mFlag != null)
                            {
                                mFlag.Flag = null;
                            }
                        }

                        //35B
                        Boolean isOptionFIAdd = false;
                        if (mCorporateActionOption.FinancialInstrument == null)
                        {
                            mCorporateActionOption.FinancialInstrument = new MFinancialInstrument();
                        }

                        if (option.CaOptSecurityID != null || option.CaOptSecurityIDType != null
                        || option.CaOptSecurityDescription != null)
                        {
                            isOptionFIAdd = true;
                            mCorporateActionOption.FinancialInstrument.SecurityValue = option.CaOptSecurityID;
                            mCorporateActionOption.FinancialInstrument.SecurityType = option.CaOptSecurityIDType != "NA" ? option.CaOptSecurityIDType : null;
                            mCorporateActionOption.FinancialInstrument.SecurityDescription = string.IsNullOrEmpty(option.CaOptSecurityDescription) ? null : option.CaOptSecurityDescription;
                        }

                        if (isOptionFIAdd == false)
                        {
                            mCorporateActionOption.FinancialInstrument = null;
                        }

                        if (mCorporateActionOption.Narrative == null)
                        {
                            mCorporateActionOption.Narrative = new List<MNarrative>();
                        }

                        //70E
                        if (!string.IsNullOrEmpty(option.CaOptDisclaimer))
                        {
                            MNarrative mNarrative = mCorporateActionOption.Narrative.FirstOrDefault(x => x.Qualifier == "DISC");
                            Boolean isAdd = false;
                            if (mNarrative == null)
                            {
                                mNarrative = new MNarrative();
                                isAdd = true;
                            }

                            mNarrative.Qualifier = "DISC";
                            mNarrative.Narrative = option.CaOptDisclaimer;
                            if (isAdd)
                            {
                                mCorporateActionOption.Narrative.Add(mNarrative);
                            }
                        }
                        else
                        {
                            MNarrative mNarrative = mCorporateActionOption.Narrative.FirstOrDefault(x => x.Qualifier == "DISC");
                            if (mNarrative != null)
                            {
                                mNarrative.Narrative = null;
                            }
                        }


                        if (!string.IsNullOrEmpty(option.CaOptInformationConditions))
                        {
                            MNarrative mNarrative = mCorporateActionOption.Narrative.FirstOrDefault(x => x.Qualifier == "INCO");
                            Boolean isAdd = false;
                            if (mNarrative == null)
                            {
                                mNarrative = new MNarrative();
                                isAdd = true;
                            }
                            mNarrative.Qualifier = "INCO";
                            mNarrative.Narrative = option.CaOptInformationConditions;
                            if (isAdd)
                            {
                                mCorporateActionOption.Narrative.Add(mNarrative);
                            }
                        }
                        else
                        {
                            MNarrative mNarrative = mCorporateActionOption.Narrative.FirstOrDefault(x => x.Qualifier == "INCO");
                            if (mNarrative != null)
                            {
                                mNarrative.Narrative = null;
                            }
                        }


                        if (!string.IsNullOrEmpty(option.CaOptInformationtobeCompliedWith))
                        {
                            MNarrative mNarrative = mCorporateActionOption.Narrative.FirstOrDefault(x => x.Qualifier == "COMP");
                            Boolean isAdd = false;
                            if (mNarrative == null)
                            {
                                mNarrative = new MNarrative();
                                isAdd = true;
                            }
                            mNarrative.Qualifier = "COMP";
                            mNarrative.Narrative = option.CaOptInformationtobeCompliedWith;
                            if (isAdd)
                            {
                                mCorporateActionOption.Narrative.Add(mNarrative);
                            }
                        }
                        else
                        {
                            MNarrative mNarrative = mCorporateActionOption.Narrative.FirstOrDefault(x => x.Qualifier == "COMP");
                            if (mNarrative != null)
                            {
                                mNarrative.Narrative = null;
                            }
                        }

                        if (!string.IsNullOrEmpty(option.CaOptOptionComments))
                        {
                            MNarrative mNarrative = mCorporateActionOption.Narrative.FirstOrDefault(x => x.Qualifier == "ADTX");
                            Boolean isAdd = false;
                            if (mNarrative == null)
                            {
                                mNarrative = new MNarrative();
                                isAdd = true;
                            }
                            mNarrative.Qualifier = "ADTX";
                            mNarrative.Narrative = option.CaOptOptionComments;
                            if (isAdd)
                            {
                                mCorporateActionOption.Narrative.Add(mNarrative);
                            }
                        }
                        else
                        {
                            MNarrative mNarrative = mCorporateActionOption.Narrative.FirstOrDefault(x => x.Qualifier == "ADTX");
                            if (mNarrative != null)
                            {
                                mNarrative.Narrative = null;
                            }
                        }

                        //36a
                        if (mCorporateActionOption.QuantityOfInstrument == null)
                        {
                            mCorporateActionOption.QuantityOfInstrument = new List<MQuantityOfInstrument>();
                        }

                        if (option.CaOptBackEndOddLotQuantityCode != "NA" && (option.CaOptBackEndOddLotQuantity != null || option.CaOptBackEndOddLotQuantityTypeCode != null || option.CaOptBackEndOddLotQuantityCode != null))
                        {
                            MQuantityOfInstrument mQuantityOfInstrument = mCorporateActionOption.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "BOLQ");
                            Boolean isAdd = false;
                            if (mQuantityOfInstrument == null)
                            {
                                mQuantityOfInstrument = new MQuantityOfInstrument();
                                isAdd = true;
                            }
                            mQuantityOfInstrument.Qualifier = "BOLQ";
                            mQuantityOfInstrument.Quantity = option.CaOptBackEndOddLotQuantity;
                            mQuantityOfInstrument.QuantityTypeCode = option.CaOptBackEndOddLotQuantityTypeCode;
                            mQuantityOfInstrument.QuantityCode = option.CaOptBackEndOddLotQuantityCode;
                            if (isAdd)
                            {
                                mCorporateActionOption.QuantityOfInstrument.Add(mQuantityOfInstrument);
                            }
                        }
                        else
                        {
                            MQuantityOfInstrument mQuantityOfInstrument = mCorporateActionOption.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "BOLQ");
                            if (mQuantityOfInstrument != null)
                            {
                                mQuantityOfInstrument.Quantity = null;
                                mQuantityOfInstrument.QuantityTypeCode = null;
                                mQuantityOfInstrument.QuantityCode = null;
                            }
                        }

                        if (option.CaOptFrontEndOddLotQuantityCode != "NA" && (option.CaOptFrontEndOddLotQuantity != null || option.CaOptFrontEndOddLotQuantityTypeCode != null || option.CaOptFrontEndOddLotQuantityCode != null))
                        {
                            MQuantityOfInstrument mQuantityOfInstrument = mCorporateActionOption.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "FOLQ");
                            Boolean isAdd = false;
                            if (mQuantityOfInstrument == null)
                            {
                                mQuantityOfInstrument = new MQuantityOfInstrument();
                                isAdd = true;
                            }
                            mQuantityOfInstrument.Qualifier = "FOLQ";
                            mQuantityOfInstrument.Quantity = option.CaOptFrontEndOddLotQuantity;
                            mQuantityOfInstrument.QuantityTypeCode = option.CaOptFrontEndOddLotQuantityTypeCode;
                            mQuantityOfInstrument.QuantityCode = option.CaOptFrontEndOddLotQuantityCode;
                            if (isAdd)
                            {
                                mCorporateActionOption.QuantityOfInstrument.Add(mQuantityOfInstrument);
                            }
                        }
                        else
                        {
                            MQuantityOfInstrument mQuantityOfInstrument = mCorporateActionOption.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "FOLQ");
                            if (mQuantityOfInstrument != null)
                            {
                                mQuantityOfInstrument.Quantity = null;
                                mQuantityOfInstrument.QuantityTypeCode = null;
                                mQuantityOfInstrument.QuantityCode = null;
                            }
                        }

                        if (option.CaOptMaximumExercisableQuantityCode != "NA" && (option.CaOptMaximumExercisableQuantity != null || option.CaOptMaximumExercisableQuantityTypeCode != null || option.CaOptMaximumExercisableQuantityCode != null))
                        {
                            MQuantityOfInstrument mQuantityOfInstrument = mCorporateActionOption.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "MAEX");
                            Boolean isAdd = false;
                            if (mQuantityOfInstrument == null)
                            {
                                mQuantityOfInstrument = new MQuantityOfInstrument();
                                isAdd = true;
                            }
                            mQuantityOfInstrument.Qualifier = "MAEX";
                            mQuantityOfInstrument.Quantity = option.CaOptMaximumExercisableQuantity;
                            mQuantityOfInstrument.QuantityTypeCode = option.CaOptMaximumExercisableQuantityTypeCode;
                            mQuantityOfInstrument.QuantityCode = option.CaOptMaximumExercisableQuantityCode;
                            if (isAdd)
                            {
                                mCorporateActionOption.QuantityOfInstrument.Add(mQuantityOfInstrument);
                            }
                        }
                        else
                        {
                            MQuantityOfInstrument mQuantityOfInstrument = mCorporateActionOption.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "MAEX");
                            if (mQuantityOfInstrument != null)
                            {
                                mQuantityOfInstrument.Quantity = null;
                                mQuantityOfInstrument.QuantityTypeCode = null;
                                mQuantityOfInstrument.QuantityCode = null;
                            }
                        }

                        if (option.CaOptMinimumExercisableMultipleQuantityCode != "NA" && (option.CaOptMinimumExercisableMultipleQuantity != null || option.CaOptMinimumExercisableMultipleQuantityTypeCode != null || option.CaOptMinimumExercisableMultipleQuantityCode != null))
                        {
                            MQuantityOfInstrument mQuantityOfInstrument = mCorporateActionOption.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "MILT");
                            Boolean isAdd = false;
                            if (mQuantityOfInstrument == null)
                            {
                                mQuantityOfInstrument = new MQuantityOfInstrument();
                                isAdd = true;
                            }
                            mQuantityOfInstrument.Qualifier = "MILT";
                            mQuantityOfInstrument.Quantity = option.CaOptMinimumExercisableMultipleQuantity;
                            mQuantityOfInstrument.QuantityTypeCode = option.CaOptMinimumExercisableMultipleQuantityTypeCode;
                            mQuantityOfInstrument.QuantityCode = option.CaOptMinimumExercisableMultipleQuantityCode;
                            if (isAdd)
                            {
                                mCorporateActionOption.QuantityOfInstrument.Add(mQuantityOfInstrument);
                            }
                        }
                        else
                        {
                            MQuantityOfInstrument mQuantityOfInstrument = mCorporateActionOption.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "MILT");
                            if (mQuantityOfInstrument != null)
                            {
                                mQuantityOfInstrument.Quantity = null;
                                mQuantityOfInstrument.QuantityTypeCode = null;
                                mQuantityOfInstrument.QuantityCode = null;
                            }
                        }

                        if (option.CaOptMinimumExercisableQuantityCode != "NA" && (option.CaOptMinimumExercisableQuantity != null || option.CaOptMinimumExercisableQuantityTypeCode != null || option.CaOptMinimumExercisableQuantityCode != null))
                        {
                            MQuantityOfInstrument mQuantityOfInstrument = mCorporateActionOption.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "MIEX");
                            Boolean isAdd = false;
                            if (mQuantityOfInstrument == null)
                            {
                                mQuantityOfInstrument = new MQuantityOfInstrument();
                                isAdd = true;
                            }
                            mQuantityOfInstrument.Qualifier = "MIEX";
                            mQuantityOfInstrument.Quantity = option.CaOptMinimumExercisableQuantity;
                            mQuantityOfInstrument.QuantityTypeCode = option.CaOptMinimumExercisableQuantityTypeCode;
                            mQuantityOfInstrument.QuantityCode = option.CaOptMinimumExercisableQuantityCode;
                            if (isAdd)
                            {
                                mCorporateActionOption.QuantityOfInstrument.Add(mQuantityOfInstrument);
                            }
                        }
                        else
                        {
                            MQuantityOfInstrument mQuantityOfInstrument = mCorporateActionOption.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "MIEX");
                            if (mQuantityOfInstrument != null)
                            {
                                mQuantityOfInstrument.Quantity = null;
                                mQuantityOfInstrument.QuantityTypeCode = null;
                                mQuantityOfInstrument.QuantityCode = null;
                            }
                        }


                        if (option.CaOptNewDenominationQuantityCode != "NA" && (option.CaOptNewDenominationQuantity != null || option.CaOptNewDenominationQuantityTypeCode != null || option.CaOptNewDenominationQuantityCode != null))
                        {
                            MQuantityOfInstrument mQuantityOfInstrument = mCorporateActionOption.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "NEWD");
                            Boolean isAdd = false;
                            if (mQuantityOfInstrument == null)
                            {
                                mQuantityOfInstrument = new MQuantityOfInstrument();
                                isAdd = true;
                            }
                            mQuantityOfInstrument.Qualifier = "NEWD";
                            mQuantityOfInstrument.Quantity = option.CaOptNewDenominationQuantity;
                            mQuantityOfInstrument.QuantityTypeCode = option.CaOptNewDenominationQuantityTypeCode;
                            mQuantityOfInstrument.QuantityCode = option.CaOptNewDenominationQuantity;
                            if (isAdd)
                            {
                                mCorporateActionOption.QuantityOfInstrument.Add(mQuantityOfInstrument);
                            }
                        }
                        else
                        {
                            MQuantityOfInstrument mQuantityOfInstrument = mCorporateActionOption.QuantityOfInstrument.FirstOrDefault(x => x.Qualifier == "NEWD");
                            if (mQuantityOfInstrument != null)
                            {
                                mQuantityOfInstrument.Quantity = null;
                                mQuantityOfInstrument.QuantityTypeCode = null;
                                mQuantityOfInstrument.QuantityCode = null;
                            }
                        }

                        //90a
                        if (mCorporateActionOption.Price == null)
                        {
                            mCorporateActionOption.Price = new List<MPrice>();
                        }

                        if (option.CaOptCashinLieuofSharesPriceCode != "NA" && (option.CaOptCashinLieuofSharesPrice != null ||
                        option.CaOptCashinLieuofSharesPriceAmountTypeCode != null ||
                        option.CaOptCashinLieuofSharesPriceCurrencyCode != null ||
                        option.CaOptCashinLieuofSharesPriceCode != null))
                        {
                            MPrice price = mCorporateActionOption.Price.FirstOrDefault(x => x.Qualifier == "CINL");
                            Boolean isAdd = false;
                            if (price == null)
                            {
                                price = new MPrice();
                                isAdd = true;
                            }

                            price.Price = option.CaOptCashinLieuofSharesPrice;
                            price.Qualifier = "CINL";
                            price.AmountTypeCode = option.CaOptCashinLieuofSharesPriceAmountTypeCode;
                            price.CurrencyCode = option.CaOptCashinLieuofSharesPriceCurrencyCode;
                            price.PriceCode = option.CaOptCashinLieuofSharesPriceCode;

                            if (isAdd)
                            {
                                mCorporateActionOption.Price.Add(price);
                            }

                        }
                        else
                        {
                            MPrice price = mCorporateActionOption.Price.FirstOrDefault(x => x.Qualifier == "CINL");
                            if (price != null)
                            {
                                price.Price = null;
                                price.AmountTypeCode = null;
                                price.CurrencyCode = null;
                                price.PriceCode = null;
                            }
                        }

                        if (option.CaOptOversubscriptionPriceCode != "NA" && (option.CaOptOversubscriptionPrice != null ||
                        option.CaOptOversubscriptionPriceAmountTypeCode != null ||
                        option.CaOptOversubscriptionPriceCurrencyCode != null ||
                        option.CaOptOversubscriptionPriceCode != null))
                        {
                            MPrice price = mCorporateActionOption.Price.FirstOrDefault(x => x.Qualifier == "OSUB");
                            Boolean isAdd = false;
                            if (price == null)
                            {
                                price = new MPrice();
                                isAdd = true;
                            }

                            price.Price = option.CaOptOversubscriptionPrice;
                            price.Qualifier = "OSUB";
                            price.AmountTypeCode = option.CaOptOversubscriptionPriceAmountTypeCode;
                            price.CurrencyCode = option.CaOptOversubscriptionPriceCurrencyCode;
                            price.PriceCode = option.CaOptOversubscriptionPriceCode;

                            if (isAdd)
                            {
                                mCorporateActionOption.Price.Add(price);
                            }

                        }
                        else
                        {
                            MPrice price = mCorporateActionOption.Price.FirstOrDefault(x => x.Qualifier == "OSUB");
                            if (price != null)
                            {
                                price.Price = null;
                                price.AmountTypeCode = null;
                                price.CurrencyCode = null;
                                price.PriceCode = null;
                            }
                        }

                        if (option.CaOptMaximumPriceCode != "NA" && (option.CaOptMaximumPrice != null ||
                        option.CaOptMaximumPriceAmountTypeCode != null ||
                        option.CaOptMaximumPriceCurrencyCode != null ||
                        option.CaOptMaximumPriceCode != null))
                        {
                            MPrice price = mCorporateActionOption.Price.FirstOrDefault(x => x.Qualifier == "MAXP");
                            Boolean isAdd = false;
                            if (price == null)
                            {
                                price = new MPrice();
                                isAdd = true;
                            }

                            price.Price = option.CaOptMaximumPrice;
                            price.Qualifier = "MAXP";
                            price.AmountTypeCode = option.CaOptMaximumPriceAmountTypeCode;
                            price.CurrencyCode = option.CaOptMaximumPriceCurrencyCode;
                            price.PriceCode = option.CaOptMaximumPriceCode;

                            if (isAdd)
                            {
                                mCorporateActionOption.Price.Add(price);
                            }

                        }
                        else
                        {
                            MPrice price = mCorporateActionOption.Price.FirstOrDefault(x => x.Qualifier == "MAXP");
                            if (price != null)
                            {
                                price.Price = null;
                                price.AmountTypeCode = null;
                                price.CurrencyCode = null;
                                price.PriceCode = null;
                            }
                        }

                        if (option.CaOptMinimumPriceCode != "NA" && (option.CaOptMinimumPrice != null ||
                        option.CaOptMinimumPriceAmountTypeCode != null ||
                        option.CaOptMinimumPriceCurrencyCode != null ||
                        option.CaOptMinimumPriceCode != null))
                        {
                            MPrice price = mCorporateActionOption.Price.FirstOrDefault(x => x.Qualifier == "MINP");
                            Boolean isAdd = false;
                            if (price == null)
                            {
                                price = new MPrice();
                                isAdd = true;
                            }

                            price.Price = option.CaOptMinimumPrice;
                            price.Qualifier = "MINP";
                            price.AmountTypeCode = option.CaOptMinimumPriceAmountTypeCode;
                            price.CurrencyCode = option.CaOptMinimumPriceCurrencyCode;
                            price.PriceCode = option.CaOptMinimumPriceCode;

                            if (isAdd)
                            {
                                mCorporateActionOption.Price.Add(price);
                            }

                        }
                        else
                        {
                            MPrice price = mCorporateActionOption.Price.FirstOrDefault(x => x.Qualifier == "MINP");
                            if (price != null)
                            {
                                price.Price = null;
                                price.AmountTypeCode = null;
                                price.CurrencyCode = null;
                                price.PriceCode = null;
                            }
                        }

                        //94C
                        if (mCorporateActionOption.Place == null)
                        {
                            mCorporateActionOption.Place = new List<CaapsLinqToDB.DBModels.MPlace>();
                        }
                        if (option.CaOptCountryofDomicileValidity != null)
                        {
                            CaapsLinqToDB.DBModels.MPlace mPlace = mCorporateActionOption.Place.FirstOrDefault(x => x.Qualifier == "DOMI");
                            Boolean isAdd = false;
                            if (mPlace == null)
                            {
                                mPlace = new CaapsLinqToDB.DBModels.MPlace();
                                isAdd = true;

                            }
                            mPlace.Qualifier = "DOMI";
                            mPlace.CountryCode = option.CaOptCountryofDomicileValidity;
                            if (isAdd)
                            {
                                mCorporateActionOption.Place.Add(mPlace);
                            }
                        }
                        else
                        {
                            CaapsLinqToDB.DBModels.MPlace mPlace = mCorporateActionOption.Place.FirstOrDefault(x => x.Qualifier == "DOMI");
                            if (mPlace != null)
                            {
                                mPlace.CountryCode = null;
                            }
                        }

                        if (option.CaOptCountryofNONDomicile != null)
                        {
                            CaapsLinqToDB.DBModels.MPlace mPlace = mCorporateActionOption.Place.FirstOrDefault(x => x.Qualifier == "NDOM");
                            Boolean isAdd = false;
                            if (mPlace == null)
                            {
                                mPlace = new CaapsLinqToDB.DBModels.MPlace();
                                isAdd = true;

                            }
                            mPlace.Qualifier = "NDOM";
                            mPlace.CountryCode = option.CaOptCountryofNONDomicile;
                            if (isAdd)
                            {
                                mCorporateActionOption.Place.Add(mPlace);
                            }
                        }
                        else
                        {
                            CaapsLinqToDB.DBModels.MPlace mPlace = mCorporateActionOption.Place.FirstOrDefault(x => x.Qualifier == "NDOM");
                            if (mPlace != null)
                            {
                                mPlace.CountryCode = null;
                            }
                        }

                        //98a
                        if (mCorporateActionOption.DateTime == null)
                        {
                            mCorporateActionOption.DateTime = new List<MDateTime>();
                        }
                        if (option.CaOptCoverExpirationDateCode != "NA" && (option.CaOptCoverExpirationDate != null || option.CaOptCoverExpirationDateCode != null))
                        {
                            MDateTime dateTime = mCorporateActionOption.DateTime.FirstOrDefault(x => x.Qualifier == "CVPR");
                            Boolean isAdd = false;

                            if (dateTime == null)
                            {
                                dateTime = new MDateTime();
                                isAdd = true;
                            }

                            dateTime.Qualifier = "CVPR";
                            dateTime.Utcindicator = null;
                            if (option.CaOptCoverExpirationDate != null)
                            {
                                dateTime.Date = option.CaOptCoverExpirationDate.Value.ToString("yyyyMMdd");
                                if (option.CaOptCoverExpirationDate.Value.ToString("HHmmss") != "000000")
                                {
                                    dateTime.Time = option.CaOptCoverExpirationDate.Value.ToString("HHmmss");
                                    dateTime.Utcindicator = GetSwiftFormatForUTC(option.CaOptCoverExpirationDate);
                                }
                                else
                                {
                                    dateTime.Time = null;
                                }
                            }
                            else
                            {
                                dateTime.Date = null;
                                dateTime.Time = null;
                            }
                            dateTime.DateCode = option.CaOptCoverExpirationDateCode;
                            if (isAdd)
                            {
                                mCorporateActionOption.DateTime.Add(dateTime);
                            }
                        }
                        else
                        {
                            MDateTime dateTime = mCorporateActionOption.DateTime.FirstOrDefault(x => x.Qualifier == "CVPR");
                            if (dateTime != null)
                            {
                                dateTime.Date = null;
                                dateTime.Time = null;
                                dateTime.DateCode = null;
                                dateTime.Utcindicator = null;
                                dateTime.Decimals = null;
                            }
                        }
                        if (option.CaOptDepositoryCoverExpirationDateCode != "NA" && (option.CaOptDepositoryCoverExpirationDate != null || option.CaOptDepositoryCoverExpirationDateCode != null))
                        {
                            MDateTime dateTime = mCorporateActionOption.DateTime.FirstOrDefault(x => x.Qualifier == "DVCP");
                            Boolean isAdd = false;

                            if (dateTime == null)
                            {
                                dateTime = new MDateTime();
                                isAdd = true;
                            }
                            dateTime.Qualifier = "DVCP";
                            dateTime.Utcindicator = null;
                            if (option.CaOptDepositoryCoverExpirationDate != null)
                            {
                                dateTime.Date = option.CaOptDepositoryCoverExpirationDate.Value.ToString("yyyyMMdd");
                                if (option.CaOptDepositoryCoverExpirationDate.Value.ToString("HHmmss") != "000000")
                                {
                                    dateTime.Time = option.CaOptDepositoryCoverExpirationDate.Value.ToString("HHmmss");
                                    dateTime.Utcindicator = GetSwiftFormatForUTC(option.CaOptDepositoryCoverExpirationDate);
                                }
                                else
                                {
                                    dateTime.Time = null;
                                }
                            }
                            else
                            {
                                dateTime.Date = null;
                                dateTime.Time = null;
                            }
                            dateTime.DateCode = option.CaOptDepositoryCoverExpirationDateCode;
                            if (isAdd)
                            {
                                mCorporateActionOption.DateTime.Add(dateTime);
                            }
                        }
                        else
                        {
                            MDateTime dateTime = mCorporateActionOption.DateTime.FirstOrDefault(x => x.Qualifier == "DVCP");
                            if (dateTime != null)
                            {
                                dateTime.Date = null;
                                dateTime.Time = null;
                                dateTime.DateCode = null;
                                dateTime.Utcindicator = null;
                                dateTime.Decimals = null;
                            }
                        }
                        if (option.CaOptEarlyResponseDeadlineDateCode != "NA" && (option.CaOptEarlyResponseDeadlineDate != null || option.CaOptEarlyResponseDeadlineDateCode != null))
                        {
                            MDateTime dateTime = mCorporateActionOption.DateTime.FirstOrDefault(x => x.Qualifier == "EARD");
                            Boolean isAdd = false;

                            if (dateTime == null)
                            {
                                dateTime = new MDateTime();
                                isAdd = true;
                            }
                            dateTime.Qualifier = "EARD";
                            dateTime.Utcindicator = null;
                            if (option.CaOptEarlyResponseDeadlineDate != null)
                            {
                                dateTime.Date = option.CaOptEarlyResponseDeadlineDate.Value.ToString("yyyyMMdd");
                                if (option.CaOptEarlyResponseDeadlineDate.Value.ToString("HHmmss") != "000000")
                                {
                                    dateTime.Time = option.CaOptEarlyResponseDeadlineDate.Value.ToString("HHmmss");
                                    dateTime.Utcindicator = GetSwiftFormatForUTC(option.CaOptEarlyResponseDeadlineDate);
                                }
                                else
                                {
                                    dateTime.Time = null;
                                }
                                
                            }
                            else
                            {
                                dateTime.Date = null;
                                dateTime.Time = null;
                            }
                            dateTime.DateCode = option.CaOptEarlyResponseDeadlineDateCode;
                            if (isAdd)
                            {
                                mCorporateActionOption.DateTime.Add(dateTime);
                            }
                        }
                        else
                        {
                            MDateTime dateTime = mCorporateActionOption.DateTime.FirstOrDefault(x => x.Qualifier == "EARD");
                            if (dateTime != null)
                            {
                                dateTime.Date = null;
                                dateTime.Time = null;
                                dateTime.DateCode = null;
                                dateTime.Utcindicator = null;
                                dateTime.Decimals = null;
                            }
                        }

                        if (option.CaOptExpiryDateCode != "NA" && (option.CaOptExpiryDate != null || option.CaOptExpiryDateCode != null))
                        {
                            MDateTime dateTime = mCorporateActionOption.DateTime.FirstOrDefault(x => x.Qualifier == "EXPI");
                            Boolean isAdd = false;

                            if (dateTime == null)
                            {
                                dateTime = new MDateTime();
                                isAdd = true;
                            }
                            dateTime.Qualifier = "EXPI";
                            dateTime.Utcindicator = null;
                            if (option.CaOptExpiryDate != null)
                            {
                                dateTime.Date = option.CaOptExpiryDate.Value.ToString("yyyyMMdd");
                                if (option.CaOptExpiryDate.Value.ToString("HHmmss") != "000000")
                                {
                                    dateTime.Time = option.CaOptExpiryDate.Value.ToString("HHmmss");
                                    dateTime.Utcindicator = GetSwiftFormatForUTC(option.CaOptExpiryDate);
                                }
                                else
                                {
                                    dateTime.Time = null;
                                }
                            }
                            else
                            {
                                dateTime.Date = null;
                                dateTime.Time = null;
                            }
                            dateTime.DateCode = option.CaOptExpiryDateCode;
                            if (isAdd)
                            {
                                mCorporateActionOption.DateTime.Add(dateTime);
                            }
                        }
                        else
                        {
                            MDateTime dateTime = mCorporateActionOption.DateTime.FirstOrDefault(x => x.Qualifier == "EXPI");
                            if (dateTime != null)
                            {
                                dateTime.Date = null;
                                dateTime.Time = null;
                                dateTime.DateCode = null;
                                dateTime.Utcindicator = null;
                                dateTime.Decimals = null;
                            }
                        }
                        if (option.CaOptMarketDeadlineDateCode != "NA" && (option.CaOptMarketDeadlineDate != null || option.CaOptMarketDeadlineDateCode != null))
                        {
                            MDateTime dateTime = mCorporateActionOption.DateTime.FirstOrDefault(x => x.Qualifier == "MKDT");
                            Boolean isAdd = false;

                            if (dateTime == null)
                            {
                                dateTime = new MDateTime();
                                isAdd = true;
                            }
                            dateTime.Qualifier = "MKDT";
                            dateTime.Utcindicator = null;
                            if (option.CaOptMarketDeadlineDate != null)
                            {
                                dateTime.Date = option.CaOptMarketDeadlineDate.Value.ToString("yyyyMMdd");
                                if (option.CaOptMarketDeadlineDate.Value.ToString("HHmmss") != "000000")
                                {
                                    dateTime.Time = option.CaOptMarketDeadlineDate.Value.ToString("HHmmss");
                                    dateTime.Utcindicator = GetSwiftFormatForUTC(option.CaOptMarketDeadlineDate);
                                }
                                else
                                {
                                    dateTime.Time = null;
                                }
                            }
                            else
                            {
                                dateTime.Date = null;
                                dateTime.Time = null;
                            }
                            dateTime.DateCode = option.CaOptMarketDeadlineDateCode;
                            if (isAdd)
                            {
                                mCorporateActionOption.DateTime.Add(dateTime);
                            }
                        }
                        else
                        {
                            MDateTime dateTime = mCorporateActionOption.DateTime.FirstOrDefault(x => x.Qualifier == "MKDT");
                            if (dateTime != null)
                            {
                                dateTime.Date = null;
                                dateTime.Time = null;
                                dateTime.DateCode = null;
                                dateTime.Utcindicator = null;
                                dateTime.Decimals = null;
                            }
                        }
                        if (option.CaOptProtectDateCode != "NA" && (option.CaOptProtectDate != null || option.CaOptProtectDateCode != null))
                        {
                            MDateTime dateTime = mCorporateActionOption.DateTime.FirstOrDefault(x => x.Qualifier == "PODT");
                            Boolean isAdd = false;

                            if (dateTime == null)
                            {
                                dateTime = new MDateTime();
                                isAdd = true;
                            }
                            dateTime.Qualifier = "PODT";
                            dateTime.Utcindicator = null;
                            if (option.CaOptProtectDate != null)
                            {
                                dateTime.Date = option.CaOptProtectDate.Value.ToString("yyyyMMdd");
                                if (option.CaOptProtectDate.Value.ToString("HHmmss") != "000000")
                                {
                                    dateTime.Time = option.CaOptProtectDate.Value.ToString("HHmmss");
                                    dateTime.Utcindicator = GetSwiftFormatForUTC(option.CaOptProtectDate);
                                }
                                else
                                {
                                    dateTime.Time = null;
                                }
                            }
                            else
                            {
                                dateTime.Date = null;
                                dateTime.Time = null;
                            }
                            dateTime.DateCode = option.CaOptProtectDateCode;
                            if (isAdd)
                            {
                                mCorporateActionOption.DateTime.Add(dateTime);
                            }
                        }
                        else
                        {
                            MDateTime dateTime = mCorporateActionOption.DateTime.FirstOrDefault(x => x.Qualifier == "PODT");
                            if (dateTime != null)
                            {
                                dateTime.Date = null;
                                dateTime.Time = null;
                                dateTime.DateCode = null;
                                dateTime.Utcindicator = null;
                                dateTime.Decimals = null;
                            }
                        }
                        if (option.CaOptResponseDeadlineDateCode != "NA" && (option.CaOptResponseDeadlineDate != null || option.CaOptResponseDeadlineDateCode != null))
                        {
                            MDateTime dateTime = mCorporateActionOption.DateTime.FirstOrDefault(x => x.Qualifier == "RDDT");
                            Boolean isAdd = false;

                            if (dateTime == null)
                            {
                                dateTime = new MDateTime();
                                isAdd = true;
                            }
                            dateTime.Qualifier = "RDDT";
                            dateTime.Utcindicator = null;
                            if (option.CaOptResponseDeadlineDate != null)
                            {
                                dateTime.Date = option.CaOptResponseDeadlineDate.Value.ToString("yyyyMMdd");
                                if (option.CaOptResponseDeadlineDate.Value.ToString("HHmmss") != "000000")
                                {
                                    dateTime.Time = option.CaOptResponseDeadlineDate.Value.ToString("HHmmss");
                                    dateTime.Utcindicator = GetSwiftFormatForUTC(option.CaOptResponseDeadlineDate);
                                }
                                else
                                {
                                    dateTime.Time = null;
                                }
                            }
                            else
                            {
                                dateTime.Date = null;
                                dateTime.Time = null;
                            }
                            dateTime.DateCode = option.CaOptResponseDeadlineDateCode; 
                            if (isAdd)
                            {
                                mCorporateActionOption.DateTime.Add(dateTime);
                            }
                        }
                        else
                        {
                            MDateTime dateTime = mCorporateActionOption.DateTime.FirstOrDefault(x => x.Qualifier == "RDDT");
                            if (dateTime != null)
                            {
                                dateTime.Date = null;
                                dateTime.Time = null;
                                dateTime.DateCode = null;
                                dateTime.Utcindicator = null;
                                dateTime.Decimals = null;
                            }
                        }
                        if (option.CaOptSubscriptionCostDebitDateCode != "NA" && (option.CaOptSubscriptionCostDebitDate != null || option.CaOptSubscriptionCostDebitDateCode != null))
                        {
                            MDateTime dateTime = mCorporateActionOption.DateTime.FirstOrDefault(x => x.Qualifier == "SUBS");
                            Boolean isAdd = false;

                            if (dateTime == null)
                            {
                                dateTime = new MDateTime();
                                isAdd = true;
                            }
                            dateTime.Qualifier = "SUBS";
                            if (option.CaOptSubscriptionCostDebitDate != null)
                            {
                                dateTime.Date = option.CaOptSubscriptionCostDebitDate.Value.ToString("yyyyMMdd");
                                if (option.CaOptSubscriptionCostDebitDate.Value.ToString("HHmmss") != "000000")
                                {
                                    dateTime.Time = option.CaOptSubscriptionCostDebitDate.Value.ToString("HHmmss");
                                }
                                else
                                {
                                    dateTime.Time = null;
                                }
                            }
                            else
                            {
                                dateTime.Date = null;
                                dateTime.Time = null;
                            }
                            dateTime.DateCode = option.CaOptSubscriptionCostDebitDateCode;
                            if (isAdd)
                            {
                                mCorporateActionOption.DateTime.Add(dateTime);
                            }
                        }
                        else
                        {
                            MDateTime dateTime = mCorporateActionOption.DateTime.FirstOrDefault(x => x.Qualifier == "SUBS");
                            if (dateTime != null)
                            {
                                dateTime.Date = null;
                                dateTime.Time = null;
                                dateTime.DateCode = null;
                            }
                        }

                        //92a
                        if (mCorporateActionOption.Rate == null)
                        {
                            mCorporateActionOption.Rate = new List<MRate>();
                        }

                        if (option.CaOptGrossDividendRateTypeCode != "NA" && (option.CaOptGrossDividendRate != null ||
                        option.CaOptGrossDividendRateTypeCode != null ||
                        option.CaOptGrossDividendRateCurrency != null))
                        {

                            MRate rate = mCorporateActionOption.Rate.FirstOrDefault(x => x.Qualifier == "GRSS");
                            Boolean isAdd = false;
                            if (rate == null)
                            {
                                rate = new MRate();
                                isAdd = true;
                            }

                            rate.Qualifier = "GRSS";
                            rate.Rate = option.CaOptGrossDividendRate;
                            rate.RateTypeCode = option.CaOptGrossDividendRateTypeCode;
                            rate.CurrencyCode = option.CaOptGrossDividendRateCurrency;

                            if (isAdd)
                            {
                                mCorporateActionOption.Rate.Add(rate);
                            }
                        }
                        else
                        {
                            MRate rate = mCorporateActionOption.Rate.FirstOrDefault(x => x.Qualifier == "GRSS");
                            if (rate != null)
                            {
                                rate.Rate = null;
                                rate.RateTypeCode = null;
                                rate.CurrencyCode = null;
                            }
                        }

                        if (option.CaOptInterestRateTypeCode != "NA" && (option.CaOptInterestRate != null ||
                        option.CaOptInterestRateTypeCode != null ||
                        option.CaOptInterestRateCurrency != null))
                        {

                            MRate rate = mCorporateActionOption.Rate.FirstOrDefault(x => x.Qualifier == "INTP");
                            Boolean isAdd = false;
                            if (rate == null)
                            {
                                rate = new MRate();
                                isAdd = true;
                            }

                            rate.Qualifier = "INTP";
                            rate.Rate = option.CaOptInterestRate;
                            rate.RateTypeCode = option.CaOptInterestRateTypeCode;
                            rate.CurrencyCode = option.CaOptInterestRateCurrency;

                            if (isAdd)
                            {
                                mCorporateActionOption.Rate.Add(rate);
                            }
                        }
                        else
                        {
                            MRate rate = mCorporateActionOption.Rate.FirstOrDefault(x => x.Qualifier == "INTP");
                            if (rate != null)
                            {
                                rate.Rate = null;
                                rate.RateTypeCode = null;
                                rate.CurrencyCode = null;
                            }
                        }

                        if (option.CaOptMaximumAllowedOversubscriptionRateTypeCode != "NA" && (option.CaOptMaximumAllowedOversubscriptionRate != null ||
                        option.CaOptMaximumAllowedOversubscriptionRateTypeCode != null ||
                        option.CaOptMaximumAllowedOversubscriptionRateCurrency != null))
                        {

                            MRate rate = mCorporateActionOption.Rate.FirstOrDefault(x => x.Qualifier == "OVEP");
                            Boolean isAdd = false;
                            if (rate == null)
                            {
                                rate = new MRate();
                                isAdd = true;
                            }

                            rate.Qualifier = "OVEP";
                            rate.Rate = option.CaOptMaximumAllowedOversubscriptionRate;
                            rate.RateTypeCode = option.CaOptMaximumAllowedOversubscriptionRateTypeCode;
                            rate.CurrencyCode = option.CaOptMaximumAllowedOversubscriptionRateCurrency;

                            if (isAdd)
                            {
                                mCorporateActionOption.Rate.Add(rate);
                            }
                        }
                        else
                        {
                            MRate rate = mCorporateActionOption.Rate.FirstOrDefault(x => x.Qualifier == "OVEP");
                            if (rate != null)
                            {
                                rate.Rate = null;
                                rate.RateTypeCode = null;
                                rate.CurrencyCode = null;
                            }
                        }

                        if (option.CaOptNetDividendRateTypeCode != "NA" && (option.CaOptNetDividendRate != null ||
                        option.CaOptNetDividendRateTypeCode != null ||
                        option.CaOptNetDividendRateCurrency != null))
                        {

                            MRate rate = mCorporateActionOption.Rate.FirstOrDefault(x => x.Qualifier == "NETT");
                            Boolean isAdd = false;
                            if (rate == null)
                            {
                                rate = new MRate();
                                isAdd = true;
                            }

                            rate.Qualifier = "NETT";
                            rate.Rate = option.CaOptNetDividendRate;
                            rate.RateTypeCode = option.CaOptNetDividendRateTypeCode;
                            rate.CurrencyCode = option.CaOptNetDividendRateCurrency;

                            if (isAdd)
                            {
                                mCorporateActionOption.Rate.Add(rate);
                            }
                        }
                        else
                        {
                            MRate rate = mCorporateActionOption.Rate.FirstOrDefault(x => x.Qualifier == "NETT");
                            if (rate != null)
                            {
                                rate.Rate = null;
                                rate.RateTypeCode = null;
                                rate.CurrencyCode = null;
                            }
                        }

                        if (option.CaOptTaxableIncomePerDividendShareTaxablePortionRateTypeCode != "NA" && (option.CaOptTaxableIncomePerDividendShareTaxablePortion != null ||
                        option.CaOptTaxableIncomePerDividendShareTaxablePortionRateTypeCode != null ||
                        option.CaOptTaxableIncomePerDividendShareTaxablePortionCurrency != null))
                        {

                            MRate rate = mCorporateActionOption.Rate.FirstOrDefault(x => x.Qualifier == "TDMT");
                            Boolean isAdd = false;
                            if (rate == null)
                            {
                                rate = new MRate();
                                isAdd = true;
                            }

                            rate.Qualifier = "TDMT";
                            rate.Rate = option.CaOptTaxableIncomePerDividendShareTaxablePortion;
                            rate.RateTypeCode = option.CaOptTaxableIncomePerDividendShareTaxablePortionRateTypeCode;
                            rate.CurrencyCode = option.CaOptTaxableIncomePerDividendShareTaxablePortionCurrency;

                            if (isAdd)
                            {
                                mCorporateActionOption.Rate.Add(rate);
                            }
                        }
                        else
                        {
                            MRate rate = mCorporateActionOption.Rate.FirstOrDefault(x => x.Qualifier == "TDMT");
                            if (rate != null)
                            {
                                rate.Rate = null;
                                rate.RateTypeCode = null;
                                rate.CurrencyCode = null;
                            }
                        }

                        if (option.CaOptProrationRateTypeCode != "NA" && (option.CaOptProrationRate != null ||
                        option.CaOptProrationRateTypeCode != null))
                        {

                            MRate rate = mCorporateActionOption.Rate.FirstOrDefault(x => x.Qualifier == "PROR");
                            Boolean isAdd = false;
                            if (rate == null)
                            {
                                rate = new MRate();
                                isAdd = true;
                            }

                            rate.Qualifier = "PROR";
                            rate.Rate = option.CaOptProrationRate;
                            rate.RateTypeCode = option.CaOptProrationRateTypeCode;

                            if (isAdd)
                            {
                                mCorporateActionOption.Rate.Add(rate);
                            }
                        }
                        else
                        {
                            MRate rate = mCorporateActionOption.Rate.FirstOrDefault(x => x.Qualifier == "PROR");
                            if (rate != null)
                            {
                                rate.Rate = null;
                                rate.RateTypeCode = null;
                            }
                        }

                        if (option.CaOptBidIntervalRateTypeCode != "NA" && (option.CaOptBidIntervalRate != null ||
                        option.CaOptBidIntervalRateCurrency != null ||
                        option.CaOptBidIntervalRateTypeCode != null))
                        {

                            MRate rate = mCorporateActionOption.Rate.FirstOrDefault(x => x.Qualifier == "BIDI");
                            Boolean isAdd = false;
                            if (rate == null)
                            {
                                rate = new MRate();
                                isAdd = true;
                            }

                            rate.Qualifier = "BIDI";
                            rate.Rate = option.CaOptBidIntervalRate;
                            rate.RateTypeCode = option.CaOptBidIntervalRateTypeCode;
                            rate.CurrencyCode = option.CaOptBidIntervalRateCurrency;

                            if (isAdd)
                            {
                                mCorporateActionOption.Rate.Add(rate);
                            }
                        }
                        else
                        {
                            MRate rate = mCorporateActionOption.Rate.FirstOrDefault(x => x.Qualifier == "BIDI");
                            if (rate != null)
                            {
                                rate.Rate = null;
                                rate.RateTypeCode = null;
                                rate.CurrencyCode = null;
                            }
                        }

                        //69a
                        if (mCorporateActionOption.Period == null)
                        {
                            mCorporateActionOption.Period = new List<MPeriod>();
                        }

                        if ((option.CaOptAccountServicerRevocabilityPeriodFromDateCode != "NA" &&
                            option.CaOptAccountServicerRevocabilityPeriodToDateCode != "NA") && (option.CaOptAccountServicerRevocabilityPeriodFrom != null ||
                            option.CaOptAccountServicerRevocabilityPeriodTo != null ||
                            option.CaOptAccountServicerRevocabilityPeriodFromDateCode != null ||
                            option.CaOptAccountServicerRevocabilityPeriodToDateCode != null
                            ))
                        {
                            MPeriod mPeriod = mCorporateActionOption.Period.FirstOrDefault(x => x.Qualifier == "AREV");
                            Boolean isAdd = false;
                            if (mPeriod == null)
                            {
                                mPeriod = new MPeriod();
                                isAdd = true;
                            }
                            mPeriod.Qualifier = "AREV";

                            if (option.CaOptAccountServicerRevocabilityPeriodFrom != null)
                            {
                                mPeriod.FromDate = option.CaOptAccountServicerRevocabilityPeriodFrom.Value.ToString("yyyyMMdd");
                                if (option.CaOptAccountServicerRevocabilityPeriodFrom.Value.ToString("HHmmss") != "000000")
                                {
                                    mPeriod.FromTime = option.CaOptAccountServicerRevocabilityPeriodFrom.Value.ToString("HHmmss");
                                }
                                else
                                {
                                    mPeriod.FromTime = null;
                                }
                            }
                            else
                            {
                                mPeriod.FromDate = null;
                                mPeriod.FromTime = null;
                            }

                            if (option.CaOptAccountServicerRevocabilityPeriodTo != null)
                            {
                                mPeriod.ToDate = option.CaOptAccountServicerRevocabilityPeriodTo.Value.ToString("yyyyMMdd");
                                if (option.CaOptAccountServicerRevocabilityPeriodTo.Value.ToString("HHmmss") != "000000")
                                {
                                    mPeriod.ToTime = option.CaOptAccountServicerRevocabilityPeriodTo.Value.ToString("HHmmss");
                                }
                                else
                                {
                                    mPeriod.ToTime = null;
                                }
                            }
                            else
                            {
                                mPeriod.ToDate = null;
                                mPeriod.ToTime = null;
                            }

                            if (option.CaOptAccountServicerRevocabilityPeriodFromDateCode != null)
                            {
                                mPeriod.DateCode = option.CaOptAccountServicerRevocabilityPeriodFromDateCode;
                            }
                            else if (option.CaOptAccountServicerRevocabilityPeriodToDateCode != null)
                            {
                                mPeriod.DateCode = option.CaOptAccountServicerRevocabilityPeriodToDateCode;
                            }
                            else
                            {
                                mPeriod.DateCode = null;
                            }

                            if (isAdd)
                            {
                                mCorporateActionOption.Period.Add(mPeriod);
                            }
                        }
                        else
                        {
                            MPeriod mPeriod = mCorporateActionOption.Period.FirstOrDefault(x => x.Qualifier == "AREV");
                            if (mPeriod != null)
                            {
                                mPeriod.FromDate = null;
                                mPeriod.FromTime = null;
                                mPeriod.ToDate = null;
                                mPeriod.ToTime = null;
                                mPeriod.DateCode = null;
                            }
                        }


                        if ((option.CaOptDepositorySuspensionPeriodforWithdrawalinStreetNameonOutturnSecurityFromDateCode != "NA" &&
                            option.CaOptDepositorySuspensionPeriodforWithdrawalinStreetNameonOutturnSecurityToDateCode != "NA") && (option.CaOptDepositorySuspensionPeriodforWithdrawalinStreetNameonOutturnSecurityFrom != null ||
                            option.CaOptDepositorySuspensionPeriodforWithdrawalinStreetNameonOutturnSecurityTo != null ||
                            option.CaOptDepositorySuspensionPeriodforWithdrawalinStreetNameonOutturnSecurityFromDateCode != null ||
                            option.CaOptDepositorySuspensionPeriodforWithdrawalinStreetNameonOutturnSecurityToDateCode != null
                            ))
                        {
                            MPeriod mPeriod = mCorporateActionOption.Period.FirstOrDefault(x => x.Qualifier == "DSWO");
                            Boolean isAdd = false;
                            if (mPeriod == null)
                            {
                                mPeriod = new MPeriod();
                                isAdd = true;
                            }
                            mPeriod.Qualifier = "DSWO";
                            if (option.CaOptDepositorySuspensionPeriodforWithdrawalinStreetNameonOutturnSecurityFrom != null)
                            {
                                mPeriod.FromDate = option.CaOptDepositorySuspensionPeriodforWithdrawalinStreetNameonOutturnSecurityFrom.Value.ToString("yyyyMMdd");
                                if (option.CaOptDepositorySuspensionPeriodforWithdrawalinStreetNameonOutturnSecurityFrom.Value.ToString("HHmmss") != "000000")
                                {
                                    mPeriod.FromTime = option.CaOptDepositorySuspensionPeriodforWithdrawalinStreetNameonOutturnSecurityFrom.Value.ToString("HHmmss");
                                }
                                else
                                {
                                    mPeriod.FromTime = null;
                                }
                            }
                            else
                            {
                                mPeriod.FromDate = null;
                                mPeriod.FromTime = null;
                            }

                            if (option.CaOptDepositorySuspensionPeriodforWithdrawalinStreetNameonOutturnSecurityTo != null)
                            {
                                mPeriod.ToDate = option.CaOptDepositorySuspensionPeriodforWithdrawalinStreetNameonOutturnSecurityTo.Value.ToString("yyyyMMdd");
                                if (option.CaOptDepositorySuspensionPeriodforWithdrawalinStreetNameonOutturnSecurityTo.Value.ToString("HHmmss") != "000000")
                                {
                                    mPeriod.ToTime = option.CaOptDepositorySuspensionPeriodforWithdrawalinStreetNameonOutturnSecurityTo.Value.ToString("HHmmss");
                                }
                                else
                                {
                                    mPeriod.ToTime = null;
                                }
                            }
                            else
                            {
                                mPeriod.ToDate = null;
                                mPeriod.ToTime = null;
                            }

                            if (option.CaOptDepositorySuspensionPeriodforWithdrawalinStreetNameonOutturnSecurityFromDateCode != null)
                            {
                                mPeriod.DateCode = option.CaOptDepositorySuspensionPeriodforWithdrawalinStreetNameonOutturnSecurityFromDateCode;
                            }
                            else if (option.CaOptDepositorySuspensionPeriodforWithdrawalinStreetNameonOutturnSecurityToDateCode != null)
                            {
                                mPeriod.DateCode = option.CaOptDepositorySuspensionPeriodforWithdrawalinStreetNameonOutturnSecurityToDateCode;
                            }
                            else
                            {
                                mPeriod.DateCode = null;
                            }

                            if (isAdd)
                            {
                                mCorporateActionOption.Period.Add(mPeriod);
                            }
                        }
                        else
                        {
                            MPeriod mPeriod = mCorporateActionOption.Period.FirstOrDefault(x => x.Qualifier == "DSWO");
                            if (mPeriod != null)
                            {
                                mPeriod.FromDate = null;
                                mPeriod.FromTime = null;
                                mPeriod.ToDate = null;
                                mPeriod.ToTime = null;
                                mPeriod.DateCode = null;
                            }
                        }


                        if ((option.CaOptPeriodofActionFromDateCode != "NA" &&
                            option.CaOptPeriodofActionToDateCode != "NA") && (option.CaOptPeriodofActionFrom != null ||
                            option.CaOptPeriodofActionTo != null ||
                            option.CaOptPeriodofActionFromDateCode != null ||
                            option.CaOptPeriodofActionToDateCode != null
                            ))
                        {
                            MPeriod mPeriod = mCorporateActionOption.Period.FirstOrDefault(x => x.Qualifier == "PWAL");
                            Boolean isAdd = false;
                            if (mPeriod == null)
                            {
                                mPeriod = new MPeriod();
                                isAdd = true;
                            }

                            mPeriod.Qualifier = "PWAL";
                            if (option.CaOptPeriodofActionFrom != null)
                            {
                                mPeriod.FromDate = option.CaOptPeriodofActionFrom.Value.ToString("yyyyMMdd");
                                if (option.CaOptPeriodofActionFrom.Value.ToString("HHmmss") != "000000")
                                {
                                    mPeriod.FromTime = option.CaOptPeriodofActionFrom.Value.ToString("HHmmss");
                                }
                                else
                                {
                                    mPeriod.FromTime = null;
                                }
                            }
                            else
                            {
                                mPeriod.FromDate = null;
                                mPeriod.FromTime = null;
                            }

                            if (option.CaOptPeriodofActionTo != null)
                            {
                                mPeriod.ToDate = option.CaOptPeriodofActionTo.Value.ToString("yyyyMMdd");
                                if (option.CaOptPeriodofActionTo.Value.ToString("HHmmss") != "000000")
                                {
                                    mPeriod.ToTime = option.CaOptPeriodofActionTo.Value.ToString("HHmmss");
                                }
                                else
                                {
                                    mPeriod.ToTime = null;
                                }
                            }
                            else
                            {
                                mPeriod.ToDate = null;
                                mPeriod.ToTime = null;
                            }

                            if (option.CaOptPeriodofActionFromDateCode != null)
                            {
                                mPeriod.DateCode = option.CaOptPeriodofActionFromDateCode;
                            }
                            else if (option.CaOptPeriodofActionToDateCode != null)
                            {
                                mPeriod.DateCode = option.CaOptPeriodofActionToDateCode;
                            }
                            else
                            {
                                mPeriod.DateCode = null;
                            }

                            if (isAdd)
                            {
                                mCorporateActionOption.Period.Add(mPeriod);
                            }
                        }
                        else
                        {
                            MPeriod mPeriod = mCorporateActionOption.Period.FirstOrDefault(x => x.Qualifier == "PWAL");
                            if (mPeriod != null)
                            {
                                mPeriod.FromDate = null;
                                mPeriod.FromTime = null;
                                mPeriod.ToDate = null;
                                mPeriod.ToTime = null;
                                mPeriod.DateCode = null;
                            }
                        }

                        if ((option.CaOptPriceCalculationPeriodFromDateCode != "NA" &&
                            option.CaOptPriceCalculationPeriodToDateCode != "NA") && (option.CaOptPriceCalculationPeriodFrom != null ||
                          option.CaOptPriceCalculationPeriodTo != null ||
                          option.CaOptPriceCalculationPeriodFromDateCode != null ||
                          option.CaOptPriceCalculationPeriodToDateCode != null
                          ))
                        {
                            MPeriod mPeriod = mCorporateActionOption.Period.FirstOrDefault(x => x.Qualifier == "PRIC");
                            Boolean isAdd = false;
                            if (mPeriod == null)
                            {
                                mPeriod = new MPeriod();
                                isAdd = true;
                            }
                            mPeriod.Qualifier = "PRIC";
                            if (option.CaOptPriceCalculationPeriodFrom != null)
                            {
                                mPeriod.FromDate = option.CaOptPriceCalculationPeriodFrom.Value.ToString("yyyyMMdd");
                                if (option.CaOptPriceCalculationPeriodFrom.Value.ToString("HHmmss") != "000000")
                                {
                                    mPeriod.FromTime = option.CaOptPriceCalculationPeriodFrom.Value.ToString("HHmmss");
                                }
                                else
                                {
                                    mPeriod.FromTime = null;
                                }
                            }
                            else
                            {
                                mPeriod.FromDate = null;
                                mPeriod.FromTime = null;
                            }

                            if (option.CaOptPriceCalculationPeriodTo != null)
                            {
                                mPeriod.ToDate = option.CaOptPriceCalculationPeriodTo.Value.ToString("yyyyMMdd");
                                if (option.CaOptPriceCalculationPeriodTo.Value.ToString("HHmmss") != "000000")
                                {
                                    mPeriod.ToTime = option.CaOptPriceCalculationPeriodTo.Value.ToString("HHmmss");
                                }
                                else
                                {
                                    mPeriod.ToTime = null;
                                }
                            }
                            else
                            {
                                mPeriod.ToDate = null;
                                mPeriod.ToTime = null;
                            }
                            if (option.CaOptPriceCalculationPeriodFromDateCode != null)
                            {
                                mPeriod.DateCode = option.CaOptPriceCalculationPeriodFromDateCode;
                            }
                            else if (option.CaOptPriceCalculationPeriodToDateCode != null)
                            {
                                mPeriod.DateCode = option.CaOptPriceCalculationPeriodToDateCode;
                            }
                            else
                            {
                                mPeriod.DateCode = null;
                            }
                            if (isAdd)
                            {
                                mCorporateActionOption.Period.Add(mPeriod);
                            }
                        }
                        else
                        {
                            MPeriod mPeriod = mCorporateActionOption.Period.FirstOrDefault(x => x.Qualifier == "PRIC");
                            if (mPeriod != null)
                            {
                                mPeriod.FromDate = null;
                                mPeriod.FromTime = null;
                                mPeriod.ToDate = null;
                                mPeriod.ToTime = null;
                                mPeriod.DateCode = null;
                            }
                        }

                        if ((option.CaOptRevocabilityPeriodFromDateCode != "NA" &&
                            option.CaOptRevocabilityPeriodToDateCode != "NA") && (option.CaOptRevocabilityPeriodFrom != null ||
                         option.CaOptRevocabilityPeriodTo != null ||
                         option.CaOptRevocabilityPeriodFromDateCode != null ||
                         option.CaOptRevocabilityPeriodToDateCode != null
                         ))
                        {
                            MPeriod mPeriod = mCorporateActionOption.Period.FirstOrDefault(x => x.Qualifier == "REVO");
                            Boolean isAdd = false;
                            if (mPeriod == null)
                            {
                                mPeriod = new MPeriod();
                                isAdd = true;
                            }
                            mPeriod.Qualifier = "REVO";
                            if (option.CaOptRevocabilityPeriodFrom != null)
                            {
                                mPeriod.FromDate = option.CaOptRevocabilityPeriodFrom.Value.ToString("yyyyMMdd");
                                if (option.CaOptRevocabilityPeriodFrom.Value.ToString("HHmmss") != "000000")
                                {
                                    mPeriod.FromTime = option.CaOptRevocabilityPeriodFrom.Value.ToString("HHmmss");
                                }
                                else
                                {
                                    mPeriod.FromTime = null;
                                }
                            }
                            else
                            {
                                mPeriod.FromDate = null;
                                mPeriod.FromTime = null;
                            }

                            if (option.CaOptRevocabilityPeriodTo != null)
                            {
                                mPeriod.ToDate = option.CaOptRevocabilityPeriodTo.Value.ToString("yyyyMMdd");
                                if (option.CaOptRevocabilityPeriodTo.Value.ToString("HHmmss") != "000000")
                                {
                                    mPeriod.ToTime = option.CaOptRevocabilityPeriodTo.Value.ToString("HHmmss");
                                }
                                else
                                {
                                    mPeriod.ToTime = null;
                                }
                            }
                            else
                            {
                                mPeriod.ToDate = null;
                                mPeriod.ToTime = null;
                            }

                            if (option.CaOptRevocabilityPeriodFromDateCode != null)
                            {
                                mPeriod.DateCode = option.CaOptRevocabilityPeriodFromDateCode;
                            }
                            else if (option.CaOptRevocabilityPeriodToDateCode != null)
                            {
                                mPeriod.DateCode = option.CaOptRevocabilityPeriodToDateCode;
                            }
                            else
                            {
                                mPeriod.DateCode = null;
                            }

                            if (isAdd)
                            {
                                mCorporateActionOption.Period.Add(mPeriod);
                            }
                        }
                        else
                        {
                            MPeriod mPeriod = mCorporateActionOption.Period.FirstOrDefault(x => x.Qualifier == "REVO");
                            if (mPeriod != null)
                            {
                                mPeriod.FromDate = null;
                                mPeriod.FromTime = null;
                                mPeriod.ToDate = null;
                                mPeriod.ToTime = null;
                                mPeriod.DateCode = null;
                            }
                        }

                        if ((option.CaOptSuspensionofPrivilegeFromDateCode != "NA" &&
                            option.CaOptSuspensionofPrivilegeToDateCode != "NA") && (option.CaOptSuspensionofPrivilegeFrom != null ||
                        option.CaOptSuspensionofPrivilegeTo != null ||
                        option.CaOptSuspensionofPrivilegeFromDateCode != null ||
                        option.CaOptSuspensionofPrivilegeToDateCode != null
                        ))
                        {
                            MPeriod mPeriod = mCorporateActionOption.Period.FirstOrDefault(x => x.Qualifier == "SUSP");
                            Boolean isAdd = false;
                            if (mPeriod == null)
                            {
                                mPeriod = new MPeriod();
                                isAdd = true;
                            }
                            mPeriod.Qualifier = "SUSP";
                            if (option.CaOptSuspensionofPrivilegeFrom != null)
                            {
                                mPeriod.FromDate = option.CaOptSuspensionofPrivilegeFrom.Value.ToString("yyyyMMdd");
                                if (option.CaOptSuspensionofPrivilegeFrom.Value.ToString("HHmmss") != "000000")
                                {
                                    mPeriod.FromTime = option.CaOptSuspensionofPrivilegeFrom.Value.ToString("HHmmss");
                                }
                                else
                                {
                                    mPeriod.FromTime = null;
                                }
                            }
                            else
                            {
                                mPeriod.FromDate = null;
                                mPeriod.FromTime = null;
                            }

                            if (option.CaOptSuspensionofPrivilegeTo != null)
                            {
                                mPeriod.ToDate = option.CaOptSuspensionofPrivilegeTo.Value.ToString("yyyyMMdd");
                                if (option.CaOptSuspensionofPrivilegeTo.Value.ToString("HHmmss") != "000000")
                                {
                                    mPeriod.ToTime = option.CaOptSuspensionofPrivilegeTo.Value.ToString("HHmmss");
                                }
                                else
                                {
                                    mPeriod.ToTime = null;
                                }
                            }
                            else
                            {
                                mPeriod.ToDate = null;
                                mPeriod.ToTime = null;
                            }

                            if (option.CaOptSuspensionofPrivilegeFromDateCode != null)
                            {
                                mPeriod.DateCode = option.CaOptSuspensionofPrivilegeFromDateCode;
                            }
                            else if (option.CaOptSuspensionofPrivilegeToDateCode != null)
                            {
                                mPeriod.DateCode = option.CaOptSuspensionofPrivilegeToDateCode;
                            }
                            else
                            {
                                mPeriod.DateCode = null;
                            }

                            if (isAdd)
                            {
                                mCorporateActionOption.Period.Add(mPeriod);
                            }
                        }
                        else
                        {
                            MPeriod mPeriod = mCorporateActionOption.Period.FirstOrDefault(x => x.Qualifier == "SUSP");
                            if (mPeriod != null)
                            {
                                mPeriod.FromDate = null;
                                mPeriod.FromTime = null;
                                mPeriod.ToDate = null;
                                mPeriod.ToTime = null;
                                mPeriod.DateCode = null;
                            }
                        }

                        //22F
                        if (mCorporateActionOption.Indicator == null)
                        {
                            mCorporateActionOption.Indicator = new List<MIndicator>();
                        }

                        if (option.CaOptOptionType != null && option.CaOptOptionType != "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "CAOP");
                            Boolean isAdd = false;
                            if (mIndicator == null)
                            {
                                mIndicator = new MIndicator();
                                isAdd = true;
                            }
                            mIndicator.Qualifier = "CAOP";
                            mIndicator.Indicator = option.CaOptOptionType;
                            if (isAdd)
                            {
                                mCorporateActionOption.Indicator.Add(mIndicator);
                            }
                        }
                        else if (option.CaOptOptionType == "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "CAOP");
                            if (mIndicator != null)
                            {
                                mIndicator.Indicator = null;
                            }
                        }
                        if (option.CaOptICSDParticipantBreakDown != null && option.CaOptICSDParticipantBreakDown != "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "CETI" && x.Indicator == "PABD");
                            Boolean isAdd = false;
                            if (mIndicator == null)
                            {
                                mIndicator = new MIndicator();
                                isAdd = true;
                            }
                            mIndicator.Qualifier = "CETI";
                            mIndicator.Indicator = option.CaOptICSDParticipantBreakDown;
                            if (isAdd)
                            {
                                mCorporateActionOption.Indicator.Add(mIndicator);
                            }
                        }
                        else if (option.CaOptICSDParticipantBreakDown == "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "CETI" && x.Indicator == "PABD");
                            if (mIndicator != null)
                            {
                                mIndicator.Indicator = null;
                            }
                        }
                        if (option.CaOptBeneficialOwnerSPaperwork != null && option.CaOptBeneficialOwnerSPaperwork != "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "CETI" && x.Indicator == "PAPW");
                            Boolean isAdd = false;
                            if (mIndicator == null)
                            {
                                mIndicator = new MIndicator();
                                isAdd = true;
                            }
                            mIndicator.Qualifier = "CETI";
                            mIndicator.Indicator = option.CaOptBeneficialOwnerSPaperwork;
                            if (isAdd)
                            {
                                mCorporateActionOption.Indicator.Add(mIndicator);
                            }
                        }
                        else if (option.CaOptBeneficialOwnerSPaperwork == "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "CETI" && x.Indicator == "PAPW");
                            if (mIndicator != null)
                            {
                                mIndicator.Indicator = null;
                            }
                        }
                        if (option.CaOptCountryofNONDomicile != null && option.CaOptCountryofNONDomicile != "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "CETI" && x.Indicator == "NDOM");
                            Boolean isAdd = false;
                            if (mIndicator == null)
                            {
                                mIndicator = new MIndicator();
                                isAdd = true;
                            }
                            mIndicator.Qualifier = "CETI";
                            mIndicator.Indicator = option.CaOptCountryofNONDomicile;
                            if (isAdd)
                            {
                                mCorporateActionOption.Indicator.Add(mIndicator);
                            }
                        }
                        else if (option.CaOptCountryofNONDomicile == "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "CETI" && x.Indicator == "NDOM");
                            if (mIndicator != null)
                            {
                                mIndicator.Indicator = null;
                            }
                        }
                        if (option.CaOptFractionBreakdown != null && option.CaOptFractionBreakdown != "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "CETI" && x.Indicator == "FRAC");
                            Boolean isAdd = false;
                            if (mIndicator == null)
                            {
                                mIndicator = new MIndicator();
                                isAdd = true;
                            }
                            mIndicator.Qualifier = "CETI";
                            mIndicator.Indicator = option.CaOptFractionBreakdown;
                            if (isAdd)
                            {
                                mCorporateActionOption.Indicator.Add(mIndicator);
                            }
                        }
                        else if (option.CaOptFractionBreakdown == "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "CETI" && x.Indicator == "FRAC");
                            if (mIndicator != null)
                            {
                                mIndicator.Indicator = null;
                            }
                        }
                        if (option.CaOptFullBeneficialOwnerBreakDown != null && option.CaOptFullBeneficialOwnerBreakDown != "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "CETI" && x.Indicator == "FULL");
                            Boolean isAdd = false;
                            if (mIndicator == null)
                            {
                                mIndicator = new MIndicator();
                                isAdd = true;
                            }
                            mIndicator.Qualifier = "CETI";
                            mIndicator.Indicator = option.CaOptFullBeneficialOwnerBreakDown;
                            if (isAdd)
                            {
                                mCorporateActionOption.Indicator.Add(mIndicator);
                            }
                        }
                        else if (option.CaOptFullBeneficialOwnerBreakDown == "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "CETI" && x.Indicator == "FULL");
                            if (mIndicator != null)
                            {
                                mIndicator.Indicator = null;
                            }
                        }
                        if (option.CaOptTaxRateBreakDown != null && option.CaOptTaxRateBreakDown != "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "TRBD");
                            Boolean isAdd = false;
                            if (mIndicator == null)
                            {
                                mIndicator = new MIndicator();
                                isAdd = true;
                            }
                            mIndicator.Qualifier = "TRBD";
                            mIndicator.Indicator = option.CaOptTaxRateBreakDown;
                            if (isAdd)
                            {
                                mCorporateActionOption.Indicator.Add(mIndicator);
                            }
                        }
                        else if (option.CaOptTaxRateBreakDown == "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "TRBD");
                            if (mIndicator != null)
                            {
                                mIndicator.Indicator = null;
                            }
                        }
                        if (option.CaOptDispositionofFractions != null && option.CaOptDispositionofFractions != "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "DISF");
                            Boolean isAdd = false;
                            if (mIndicator == null)
                            {
                                mIndicator = new MIndicator();
                                isAdd = true;
                            }
                            mIndicator.Qualifier = "DISF";
                            mIndicator.Indicator = option.CaOptDispositionofFractions;
                            if (isAdd)
                            {
                                mCorporateActionOption.Indicator.Add(mIndicator);
                            }
                        }
                        else if (option.CaOptDispositionofFractions == "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "DISF");
                            if (mIndicator != null)
                            {
                                mIndicator.Indicator = null;
                            }
                        }
                        if (option.CaOptAccountServicerOption != null && option.CaOptAccountServicerOption != "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "OPTF" && x.Indicator == "ASVO");
                            Boolean isAdd = false;
                            if (mIndicator == null)
                            {
                                mIndicator = new MIndicator();
                                isAdd = true;
                            }
                            mIndicator.Qualifier = "OPTF";
                            mIndicator.Indicator = option.CaOptAccountServicerOption;
                            if (isAdd)
                            {
                                mCorporateActionOption.Indicator.Add(mIndicator);
                            }
                        }
                        else if (option.CaOptAccountServicerOption == "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "OPTF" && x.Indicator == "ASVO");
                            if (mIndicator != null)
                            {
                                mIndicator.Indicator = null;
                            }
                        }
                        if (option.CaOptBeneficiaryOwnerInstruction != null && option.CaOptBeneficiaryOwnerInstruction != "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "OPTF" && x.Indicator == "BOIS");
                            Boolean isAdd = false;
                            if (mIndicator == null)
                            {
                                mIndicator = new MIndicator();
                                isAdd = true;
                            }
                            mIndicator.Qualifier = "OPTF";
                            mIndicator.Indicator = option.CaOptBeneficiaryOwnerInstruction;
                            if (isAdd)
                            {
                                mCorporateActionOption.Indicator.Add(mIndicator);
                            }
                        }
                        else if (option.CaOptBeneficiaryOwnerInstruction == "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "OPTF" && x.Indicator == "BOIS");
                            if (mIndicator != null)
                            {
                                mIndicator.Indicator = null;
                            }
                        }
                        if (option.CaOptConditional != null && option.CaOptConditional != "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "OPTF" && x.Indicator == "COND");
                            Boolean isAdd = false;
                            if (mIndicator == null)
                            {
                                mIndicator = new MIndicator();
                                isAdd = true;
                            }
                            mIndicator.Qualifier = "OPTF";
                            mIndicator.Indicator = option.CaOptConditional;
                            if (isAdd)
                            {
                                mCorporateActionOption.Indicator.Add(mIndicator);
                            }
                        }
                        else if (option.CaOptConditional == "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "OPTF" && x.Indicator == "COND");
                            if (mIndicator != null)
                            {
                                mIndicator.Indicator = null;
                            }
                        }
                        if (option.CaOptCorporateActionOptionApplicability != null && option.CaOptCorporateActionOptionApplicability != "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "OPTF" && x.Indicator == "CAOS");
                            Boolean isAdd = false;
                            if (mIndicator == null)
                            {
                                mIndicator = new MIndicator();
                                isAdd = true;
                            }
                            mIndicator.Qualifier = "OPTF";
                            mIndicator.Indicator = option.CaOptCorporateActionOptionApplicability;
                            if (isAdd)
                            {
                                mCorporateActionOption.Indicator.Add(mIndicator);
                            }
                        }
                        else if (option.CaOptCorporateActionOptionApplicability == "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "OPTF" && x.Indicator == "CAOS");
                            if (mIndicator != null)
                            {
                                mIndicator.Indicator = null;
                            }
                        }
                        if (option.CaOptNoServiceOffered != null && option.CaOptNoServiceOffered != "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "OPTF" && x.Indicator == "NOSE");
                            Boolean isAdd = false;
                            if (mIndicator == null)
                            {
                                mIndicator = new MIndicator();
                                isAdd = true;
                            }
                            mIndicator.Qualifier = "OPTF";
                            mIndicator.Indicator = option.CaOptNoServiceOffered;
                            if (isAdd)
                            {
                                mCorporateActionOption.Indicator.Add(mIndicator);
                            }
                        }
                        else if (option.CaOptNoServiceOffered == "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "OPTF" && x.Indicator == "NOSE");
                            if (mIndicator != null)
                            {
                                mIndicator.Indicator = null;
                            }
                        }
                        if (option.CaOptOddLotPreference != null && option.CaOptOddLotPreference != "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "OPTF" && x.Indicator == "OPLF");
                            Boolean isAdd = false;
                            if (mIndicator == null)
                            {
                                mIndicator = new MIndicator();
                                isAdd = true;
                            }
                            mIndicator.Qualifier = "OPTF";
                            mIndicator.Indicator = option.CaOptOddLotPreference;
                            if (isAdd)
                            {
                                mCorporateActionOption.Indicator.Add(mIndicator);
                            }
                        }
                        else if (option.CaOptOddLotPreference == "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "OPTF" && x.Indicator == "OPLF");
                            if (mIndicator != null)
                            {
                                mIndicator.Indicator = null;
                            }
                        }
                        if (option.CaOptProration != null && option.CaOptProration != "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "OPTF" && x.Indicator == "PROR");
                            Boolean isAdd = false;
                            if (mIndicator == null)
                            {
                                mIndicator = new MIndicator();
                                isAdd = true;
                            }
                            mIndicator.Qualifier = "OPTF";
                            mIndicator.Indicator = option.CaOptProration;
                            if (isAdd)
                            {
                                mCorporateActionOption.Indicator.Add(mIndicator);
                            }
                        }
                        else if (option.CaOptProration == "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "OPTF" && x.Indicator == "PROR");
                            if (mIndicator != null)
                            {
                                mIndicator.Indicator = null;
                            }
                        }
                        if (option.CaOptOptionStatus != null && option.CaOptOptionStatus != "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "OSTA");
                            Boolean isAdd = false;
                            if (mIndicator == null)
                            {
                                mIndicator = new MIndicator();
                                isAdd = true;
                            }
                            mIndicator.Qualifier = "OSTA";
                            mIndicator.Indicator = option.CaOptOptionStatus == "ACTV" ? null : option.CaOptOptionStatus;
                            if (isAdd)
                            {
                                mCorporateActionOption.Indicator.Add(mIndicator);
                            }
                        }
                        else if (option.CaOptOptionStatus == "NA")
                        {
                            MIndicator mIndicator = mCorporateActionOption.Indicator.FirstOrDefault(x => x.Qualifier == "OSTA");
                            if (mIndicator != null)
                            {
                                mIndicator.Indicator = null;
                            }
                        }

                        //====================== E1 - Security Movement START ===================================

                        if (mCorporateActionOption.SecurityMovement == null)
                        {
                            mCorporateActionOption.SecurityMovement = new List<MSecurityMovement>();
                        }
                        option.securityMovement.ForEach(securityMovement =>
                        {
                            MSecurityMovement mSecurityMovement = mCorporateActionOption.SecurityMovement.FirstOrDefault(x => x.NumberId == securityMovement.SMSecurityNumber);
                            Boolean isSecurityAdd = false;


                            if (mSecurityMovement == null)
                            {
                                mSecurityMovement = new MSecurityMovement();
                                isSecurityAdd = true;
                            }

                            if (mSecurityMovement.NumberId == null)
                            {
                                mSecurityMovement.NumberId = securityMovement.SMSecurityNumber;
                            }

                            if (securityMovement.SMDispositionOfFractions != null && securityMovement.SMDispositionOfFractions != "NA")
                            {
                                MIndicator mIndicator = mSecurityMovement.Indicator;
                                if (mIndicator == null)
                                {
                                    mIndicator = new MIndicator();
                                }
                                mIndicator.Qualifier = "DISF";
                                mIndicator.Indicator = securityMovement.SMDispositionOfFractions;
                                mSecurityMovement.Indicator = mIndicator;
                            }
                            else if (securityMovement.SMDispositionOfFractions == "NA")
                            {
                                MIndicator mIndicator = mSecurityMovement.Indicator;
                                if (mIndicator != null)
                                {
                                    mIndicator.Indicator = null;
                                }
                            }


                            if (mSecurityMovement.Indicators == null)
                            {
                                mSecurityMovement.Indicators = new List<MIndicator>();
                            }


                            if (securityMovement.SMCreditorDebit != null && securityMovement.SMCreditorDebit != "NA")
                            {
                                MIndicator mIndicator = mSecurityMovement.Indicators.FirstOrDefault(x => x.Qualifier == "CRDB");
                                Boolean isAdd = false;
                                if (mIndicator == null)
                                {
                                    mIndicator = new MIndicator();
                                    isAdd = true;
                                }
                                mIndicator.Qualifier = "CRDB";
                                mIndicator.Indicator = securityMovement.SMCreditorDebit;
                                if (isAdd)
                                {
                                    mSecurityMovement.Indicators.Add(mIndicator);
                                }
                            }
                            else if (securityMovement.SMCreditorDebit == "NA")
                            {
                                MIndicator mIndicator = mSecurityMovement.Indicators.FirstOrDefault(x => x.Qualifier == "CRDB");
                                if (mIndicator != null)
                                {
                                    mIndicator.Indicator = null;
                                }
                            }


                            if (securityMovement.SMIssuerOrOfferorTaxability != null && securityMovement.SMIssuerOrOfferorTaxability != "NA")
                            {
                                MIndicator mIndicator = mSecurityMovement.Indicators.FirstOrDefault(x => x.Qualifier == "TXAP");
                                Boolean isAdd = false;
                                if (mIndicator == null)
                                {
                                    mIndicator = new MIndicator();
                                    isAdd = true;
                                }
                                mIndicator.Qualifier = "TXAP";
                                mIndicator.Indicator = securityMovement.SMIssuerOrOfferorTaxability;
                                if (isAdd)
                                {
                                    mSecurityMovement.Indicators.Add(mIndicator);
                                }
                            }
                            else if (securityMovement.SMIssuerOrOfferorTaxability == "NA")
                            {
                                MIndicator mIndicator = mSecurityMovement.Indicators.FirstOrDefault(x => x.Qualifier == "TXAP");
                                if (mIndicator != null)
                                {
                                    mIndicator.Indicator = null;
                                }
                            }
                            if (securityMovement.SMNewSecuritiesIssuance != null && securityMovement.SMNewSecuritiesIssuance != "NA")
                            {
                                MIndicator mIndicator = mSecurityMovement.Indicators.FirstOrDefault(x => x.Qualifier == "NSIS");
                                Boolean isAdd = false;
                                if (mIndicator == null)
                                {
                                    mIndicator = new MIndicator();
                                    isAdd = true;
                                }
                                mIndicator.Qualifier = "NSIS";
                                mIndicator.Indicator = securityMovement.SMNewSecuritiesIssuance;
                                if (isAdd)
                                {
                                    mSecurityMovement.Indicators.Add(mIndicator);
                                }
                            }
                            else if (securityMovement.SMNewSecuritiesIssuance == "NA")
                            {
                                MIndicator mIndicator = mSecurityMovement.Indicators.FirstOrDefault(x => x.Qualifier == "NSIS");
                                if (mIndicator != null)
                                {
                                    mIndicator.Indicator = null;
                                }
                            }
                            if (securityMovement.SMNonEligibleProceeds != null && securityMovement.SMNonEligibleProceeds != "NA")
                            {
                                MIndicator mIndicator = mSecurityMovement.Indicators.FirstOrDefault(x => x.Qualifier == "NELP");
                                Boolean isAdd = false;
                                if (mIndicator == null)
                                {
                                    mIndicator = new MIndicator();
                                    isAdd = true;
                                }
                                mIndicator.Qualifier = "NELP";
                                mIndicator.Indicator = securityMovement.SMNonEligibleProceeds;
                                if (isAdd)
                                {
                                    mSecurityMovement.Indicators.Add(mIndicator);
                                }
                            }
                            else if (securityMovement.SMNonEligibleProceeds == "NA")
                            {
                                MIndicator mIndicator = mSecurityMovement.Indicators.FirstOrDefault(x => x.Qualifier == "NELP");
                                if (mIndicator != null)
                                {
                                    mIndicator.Indicator = null;
                                }
                            }
                            if (securityMovement.SMTemporarySecurity != null && securityMovement.SMTemporarySecurity != "NA")
                            {
                                MIndicator mIndicator = mSecurityMovement.Indicators.FirstOrDefault(x => x.Qualifier == "TEMP");
                                Boolean isAdd = false;
                                if (mIndicator == null)
                                {
                                    mIndicator = new MIndicator();
                                    isAdd = true;
                                }
                                mIndicator.Qualifier = "TEMP";
                                mIndicator.Indicator = securityMovement.SMTemporarySecurity;
                                if (isAdd)
                                {
                                    mSecurityMovement.Indicators.Add(mIndicator);
                                }
                            }
                            else if (securityMovement.SMTemporarySecurity == "NA")
                            {
                                MIndicator mIndicator = mSecurityMovement.Indicators.FirstOrDefault(x => x.Qualifier == "TEMP");
                                if (mIndicator != null)
                                {
                                    mIndicator.Indicator = null;
                                }
                            }
                            if (securityMovement.SMTypeOfIncome != null && securityMovement.SMTypeOfIncome != "NA")
                            {
                                MIndicator mIndicator = mSecurityMovement.Indicators.FirstOrDefault(x => x.Qualifier == "ITYP");
                                Boolean isAdd = false;
                                if (mIndicator == null)
                                {
                                    mIndicator = new MIndicator();
                                    isAdd = true;
                                }
                                mIndicator.Qualifier = "ITYP";
                                mIndicator.Indicator = securityMovement.SMTypeOfIncome;
                                if (isAdd)
                                {
                                    mSecurityMovement.Indicators.Add(mIndicator);
                                }
                            }
                            else if (securityMovement.SMTypeOfIncome == "NA")
                            {
                                MIndicator mIndicator = mSecurityMovement.Indicators.FirstOrDefault(x => x.Qualifier == "ITYP");
                                if (mIndicator != null)
                                {
                                    mIndicator.Indicator = null;
                                }
                            }
                            //35B
                            if (mSecurityMovement.FinancialInstrument == null)
                            {
                                mSecurityMovement.FinancialInstrument = new MFinancialInstrument();
                            }

                            if (securityMovement.SMCreditorDebit == "DEBT")
                            {
                                mSecurityMovement.FinancialInstrument.SecurityDescription = string.IsNullOrEmpty(securityMovement.SMNewDebitSecurityDescription) ? null : securityMovement.SMNewDebitSecurityDescription;
                                mSecurityMovement.FinancialInstrument.SecurityValue = securityMovement.SMNewDebitSecurityID;
                                mSecurityMovement.FinancialInstrument.SecurityType = securityMovement.SMNewDebitSecurityIDType;
                                mSecurityMovement.ActiveStatus = securityMovement.SMDebitStatus;
                            }
                            else
                            {
                                mSecurityMovement.FinancialInstrument.SecurityDescription = string.IsNullOrEmpty(securityMovement.SMNewSecurityDescription) ? null : securityMovement.SMNewSecurityDescription;
                                mSecurityMovement.FinancialInstrument.SecurityValue = securityMovement.SMNewSecurityID;
                                mSecurityMovement.FinancialInstrument.SecurityType = securityMovement.SMNewSecurityIDType;
                                mSecurityMovement.ActiveStatus = securityMovement.SMStatus;
                            }

                            //69a
                            Boolean isSMPeriodAdd = false;
                            if (mSecurityMovement.Period == null)
                            {
                                mSecurityMovement.Period = new MPeriod();
                            }
                            mSecurityMovement.Period.Qualifier = "TRDP";
                            if (securityMovement.SMTradingPeriodFrom != null || securityMovement.SMTradingPeriodFromDateCode != null)
                            {
                                isSMPeriodAdd = true;
                                mSecurityMovement.Period.FromDate = securityMovement.SMTradingPeriodFrom.Value.ToString("yyyyMMdd");
                                if (securityMovement.SMTradingPeriodFrom.Value.ToString("HHmmss") != "000000")
                                {
                                    mSecurityMovement.Period.FromTime = securityMovement.SMTradingPeriodFrom.Value.ToString("HHmmss");
                                }
                                else
                                {
                                    mSecurityMovement.Period.FromTime = null;
                                }
                            }
                            else
                            {
                                mSecurityMovement.Period.FromDate = null;
                                mSecurityMovement.Period.FromTime = null;
                            }
                            if (securityMovement.SMTradingPeriodTo != null || securityMovement.SMTradingPeriodToDateCode != null)
                            {
                                isSMPeriodAdd = true;
                                mSecurityMovement.Period.ToDate = securityMovement.SMTradingPeriodTo.Value.ToString("yyyyMMdd");
                                if (option.CaOptSuspensionofPrivilegeTo.Value.ToString("HHmmss") != "000000")
                                {
                                    mSecurityMovement.Period.ToTime = securityMovement.SMTradingPeriodTo.Value.ToString("HHmmss");
                                }
                                else
                                {
                                    mSecurityMovement.Period.ToTime = null;
                                }
                            }
                            else
                            {
                                mSecurityMovement.Period.ToDate = null;
                                mSecurityMovement.Period.ToTime = null;
                            }

                            if (securityMovement.SMTradingPeriodFromDateCode != null)
                            {
                                mSecurityMovement.Period.DateCode = securityMovement.SMTradingPeriodFromDateCode;
                            }
                            else if (securityMovement.SMTradingPeriodToDateCode != null)
                            {
                                mSecurityMovement.Period.DateCode = securityMovement.SMTradingPeriodToDateCode;
                            }
                            else
                            {
                                mSecurityMovement.Period.DateCode = null;
                            }

                            if (isSMPeriodAdd == false)
                            {
                                mSecurityMovement.Period = null;
                            }

                            //90a
                            if (mSecurityMovement.Prices == null)
                            {
                                mSecurityMovement.Prices = new List<MPrice>();
                            }

                            if (securityMovement.SMCashValueForTaxPriceCode != "NA" && (securityMovement.SMCashValueForTax != null
                            || securityMovement.SMCashValueForTaxAmountTypeCode != null
                            || securityMovement.SMCashValueForTaxCurrencyCode != null
                            || securityMovement.SMCashValueForTaxPriceCode != null))
                            {
                                MPrice mPrice = mSecurityMovement.Prices.FirstOrDefault(x => x.Qualifier == "CAVA");
                                Boolean isAdd = false;
                                if (mPrice == null)
                                {
                                    mPrice = new MPrice();
                                    isAdd = true;
                                }
                                mPrice.Qualifier = "CAVA";
                                mPrice.AmountTypeCode = securityMovement.SMCashValueForTaxAmountTypeCode;
                                mPrice.Price = securityMovement.SMCashValueForTax;
                                mPrice.CurrencyCode = securityMovement.SMCashValueForTaxCurrencyCode;
                                mPrice.PriceCode = securityMovement.SMCashValueForTaxPriceCode;
                                if (isAdd)
                                {
                                    mSecurityMovement.Prices.Add(mPrice);
                                }
                            }
                            else
                            {
                                MPrice mPrice = mSecurityMovement.Prices.FirstOrDefault(x => x.Qualifier == "CAVA");
                                if (mPrice != null)
                                {
                                    mPrice.AmountTypeCode = null;
                                    mPrice.Price = null;
                                    mPrice.CurrencyCode = null;
                                    mPrice.PriceCode = null;
                                }
                            }

                            if (securityMovement.SMIndicativePriceCode != "NA" && (securityMovement.SMIndicativePrice != null
                            || securityMovement.SMIndicativePriceAmountTypeCode != null
                            || securityMovement.SMIndicativePriceCurrencyCode != null
                            || securityMovement.SMIndicativePriceCode != null))
                            {
                                MPrice mPrice = mSecurityMovement.Prices.FirstOrDefault(x => x.Qualifier == "INDC");
                                Boolean isAdd = false;
                                if (mPrice == null)
                                {
                                    mPrice = new MPrice();
                                    isAdd = true;
                                }
                                mPrice.Qualifier = "INDC";
                                mPrice.Price = securityMovement.SMIndicativePrice;
                                mPrice.AmountTypeCode = securityMovement.SMIndicativePriceAmountTypeCode;
                                mPrice.CurrencyCode = securityMovement.SMIndicativePriceCurrencyCode;
                                mPrice.PriceCode = securityMovement.SMIndicativePriceCode;
                                if (isAdd)
                                {
                                    mSecurityMovement.Prices.Add(mPrice);
                                }
                            }
                            else
                            {
                                MPrice mPrice = mSecurityMovement.Prices.FirstOrDefault(x => x.Qualifier == "INDC");
                                if (mPrice != null)
                                {
                                    mPrice.AmountTypeCode = null;
                                    mPrice.Price = null;
                                    mPrice.CurrencyCode = null;
                                    mPrice.PriceCode = null;
                                }
                            }
                            if (securityMovement.SMCashInLieuPriceCode != "NA" && (securityMovement.SMCashInLieuPrice != null
                            || securityMovement.SMCashInLieuPriceAmountTypeCode != null
                            || securityMovement.SMCashInLieuPriceCurrencyCode != null
                            || securityMovement.SMCashInLieuPriceCode != null))
                            {
                                MPrice mPrice = mSecurityMovement.Prices.FirstOrDefault(x => x.Qualifier == "CINL");
                                Boolean isAdd = false;
                                if (mPrice == null)
                                {
                                    mPrice = new MPrice();
                                    isAdd = true;
                                }
                                mPrice.Qualifier = "CINL";
                                mPrice.Price = securityMovement.SMCashInLieuPrice;
                                mPrice.AmountTypeCode = securityMovement.SMCashInLieuPriceAmountTypeCode;
                                mPrice.CurrencyCode = securityMovement.SMCashInLieuPriceCurrencyCode;
                                mPrice.PriceCode = securityMovement.SMCashInLieuPriceCode;
                                if (isAdd)
                                {
                                    mSecurityMovement.Prices.Add(mPrice);
                                }
                            }
                            else
                            {
                                MPrice mPrice = mSecurityMovement.Prices.FirstOrDefault(x => x.Qualifier == "CINL");
                                if (mPrice != null)
                                {
                                    mPrice.AmountTypeCode = null;
                                    mPrice.Price = null;
                                    mPrice.CurrencyCode = null;
                                    mPrice.PriceCode = null;
                                }
                            }
                            if (securityMovement.SMPricePaidPriceCode != "NA" && (securityMovement.SMPricePaid != null
                            || securityMovement.SMPricePaidAmountTypeCode != null
                            || securityMovement.SMPricePaidCurrencyCode != null
                            || securityMovement.SMPricePaidPriceCode != null))
                            {
                                MPrice mPrice = mSecurityMovement.Prices.FirstOrDefault(x => x.Qualifier == "PRPP");
                                Boolean isAdd = false;
                                if (mPrice == null)
                                {
                                    mPrice = new MPrice();
                                    isAdd = true;
                                }
                                mPrice.Qualifier = "PRPP";
                                mPrice.Price = securityMovement.SMPricePaid;
                                mPrice.AmountTypeCode = securityMovement.SMPricePaidAmountTypeCode;
                                mPrice.CurrencyCode = securityMovement.SMPricePaidCurrencyCode;
                                mPrice.PriceCode = securityMovement.SMPricePaidPriceCode;
                                if (isAdd)
                                {
                                    mSecurityMovement.Prices.Add(mPrice);
                                }
                            }
                            else
                            {
                                MPrice mPrice = mSecurityMovement.Prices.FirstOrDefault(x => x.Qualifier == "PRPP");
                                if (mPrice != null)
                                {
                                    mPrice.AmountTypeCode = null;
                                    mPrice.Price = null;
                                    mPrice.CurrencyCode = null;
                                    mPrice.PriceCode = null;
                                }
                            }
                            if (securityMovement.SMPriceReceivedPriceCode != "NA" && (securityMovement.SMPriceReceived != null
                            || securityMovement.SMPriceReceivedAmountTypeCode != null
                            || securityMovement.SMPriceReceivedCurrencyCode != null
                            || securityMovement.SMPriceReceivedPriceCode != null))
                            {
                                MPrice mPrice = mSecurityMovement.Prices.FirstOrDefault(x => x.Qualifier == "OFFR");
                                Boolean isAdd = false;
                                if (mPrice == null)
                                {
                                    mPrice = new MPrice();
                                    isAdd = true;
                                }
                                mPrice.Qualifier = "OFFR";
                                mPrice.Price = securityMovement.SMPriceReceived;
                                mPrice.AmountTypeCode = securityMovement.SMPriceReceivedAmountTypeCode;
                                mPrice.CurrencyCode = securityMovement.SMPriceReceivedCurrencyCode;
                                mPrice.PriceCode = securityMovement.SMPriceReceivedPriceCode;
                                if (isAdd)
                                {
                                    mSecurityMovement.Prices.Add(mPrice);
                                }
                            }
                            else
                            {
                                MPrice mPrice = mSecurityMovement.Prices.FirstOrDefault(x => x.Qualifier == "OFFR");
                                if (mPrice != null)
                                {
                                    mPrice.AmountTypeCode = null;
                                    mPrice.Price = null;
                                    mPrice.CurrencyCode = null;
                                    mPrice.PriceCode = null;
                                }
                            }
                            //98a

                            if (mSecurityMovement.DateTimes == null)
                            {
                                mSecurityMovement.DateTimes = new List<MDateTime>();
                            }

                            if (securityMovement.SMAvailbleDateTimeForTradingDateCode != "NA" && (securityMovement.SMAvailbleDateTimeForTrading != null || securityMovement.SMAvailbleDateTimeForTradingDateCode != null))
                            {
                                MDateTime mDateTime = mSecurityMovement.DateTimes.FirstOrDefault(x => x.Qualifier == "AVAL");
                                Boolean isAdd = false;
                                if (mDateTime == null)
                                {
                                    mDateTime = new MDateTime();
                                    isAdd = true;
                                }
                                mDateTime.Qualifier = "AVAL";
                                if (securityMovement.SMAvailbleDateTimeForTrading != null)
                                {
                                    mDateTime.Date = securityMovement.SMAvailbleDateTimeForTrading.Value.ToString("yyyyMMdd");

                                    if (securityMovement.SMAvailbleDateTimeForTrading.Value.ToString("HHmmss") != "000000")
                                    {
                                        mDateTime.Time = securityMovement.SMAvailbleDateTimeForTrading.Value.ToString("HHmmss");
                                    }
                                    else
                                    {
                                        mDateTime.Time = null;
                                    }

                                }
                                else
                                {
                                    mDateTime.Date = null;
                                    mDateTime.Time = null;
                                }
                                mDateTime.DateCode = securityMovement.SMAvailbleDateTimeForTradingDateCode;
                                if (isAdd)
                                {
                                    mSecurityMovement.DateTimes.Add(mDateTime);
                                }
                            }
                            else
                            {
                                MDateTime mDateTime = mSecurityMovement.DateTimes.FirstOrDefault(x => x.Qualifier == "AVAL");
                                if (mDateTime != null)
                                {
                                    mDateTime.Time = null;
                                    mDateTime.Date = null;
                                    mDateTime.DateCode = null;
                                }
                            }

                            if (securityMovement.SMDividendRankingDateCode != "NA" && (securityMovement.SMDividendRankingDate != null || securityMovement.SMDividendRankingDateCode != null))
                            {
                                MDateTime mDateTime = mSecurityMovement.DateTimes.FirstOrDefault(x => x.Qualifier == "DIVR");
                                Boolean isAdd = false;
                                if (mDateTime == null)
                                {
                                    mDateTime = new MDateTime();
                                    isAdd = true;
                                }
                                mDateTime.Qualifier = "DIVR";
                                if (securityMovement.SMDividendRankingDate != null)
                                {
                                    mDateTime.Date = securityMovement.SMDividendRankingDate.Value.ToString("yyyyMMdd");

                                    if (securityMovement.SMDividendRankingDate.Value.ToString("HHmmss") != "000000")
                                    {
                                        mDateTime.Time = securityMovement.SMDividendRankingDate.Value.ToString("HHmmss");
                                    }
                                    else
                                    {
                                        mDateTime.Time = null;
                                    }

                                }
                                else
                                {
                                    mDateTime.Date = null;
                                    mDateTime.Time = null;
                                }
                                mDateTime.DateCode = securityMovement.SMDividendRankingDateCode;
                                if (isAdd)
                                {
                                    mSecurityMovement.DateTimes.Add(mDateTime);
                                }
                            }
                            else
                            {
                                MDateTime mDateTime = mSecurityMovement.DateTimes.FirstOrDefault(x => x.Qualifier == "DIVR");
                                if (mDateTime != null)
                                {
                                    mDateTime.Time = null;
                                    mDateTime.Date = null;
                                    mDateTime.DateCode = null;
                                }
                            }

                            if (securityMovement.SMEarliestPaymentDateCode != "NA" && (securityMovement.SMEarliestPaymentDate != null || securityMovement.SMEarliestPaymentDateCode != null))
                            {
                                MDateTime mDateTime = mSecurityMovement.DateTimes.FirstOrDefault(x => x.Qualifier == "EARL");
                                Boolean isAdd = false;
                                if (mDateTime == null)
                                {
                                    mDateTime = new MDateTime();
                                    isAdd = true;
                                }
                                mDateTime.Qualifier = "EARL";

                                if (securityMovement.SMEarliestPaymentDate != null)
                                {
                                    mDateTime.Date = securityMovement.SMEarliestPaymentDate.Value.ToString("yyyyMMdd");

                                    if (securityMovement.SMEarliestPaymentDate.Value.ToString("HHmmss") != "000000")
                                    {
                                        mDateTime.Time = securityMovement.SMEarliestPaymentDate.Value.ToString("HHmmss");
                                    }
                                    else
                                    {
                                        mDateTime.Time = null;
                                    }

                                }
                                else
                                {
                                    mDateTime.Date = null;
                                    mDateTime.Time = null;
                                }

                                mDateTime.DateCode = securityMovement.SMEarliestPaymentDateCode;
                                if (isAdd)
                                {
                                    mSecurityMovement.DateTimes.Add(mDateTime);
                                }
                            }
                            else
                            {
                                MDateTime mDateTime = mSecurityMovement.DateTimes.FirstOrDefault(x => x.Qualifier == "EARL");
                                if (mDateTime != null)
                                {
                                    mDateTime.Time = null;
                                    mDateTime.Date = null;
                                    mDateTime.DateCode = null;
                                }
                            }

                            if (securityMovement.SMLastTradingDateCode != "NA" && (securityMovement.SMLastTradingDate != null || securityMovement.SMLastTradingDateCode != null))
                            {
                                MDateTime mDateTime = mSecurityMovement.DateTimes.FirstOrDefault(x => x.Qualifier == "LTRD");
                                Boolean isAdd = false;
                                if (mDateTime == null)
                                {
                                    mDateTime = new MDateTime();
                                    isAdd = true;
                                }
                                mDateTime.Qualifier = "LTRD";
                                if (securityMovement.SMLastTradingDate != null)
                                {
                                    mDateTime.Date = securityMovement.SMLastTradingDate.Value.ToString("yyyyMMdd");

                                    if (securityMovement.SMLastTradingDate.Value.ToString("HHmmss") != "000000")
                                    {
                                        mDateTime.Time = securityMovement.SMLastTradingDate.Value.ToString("HHmmss");
                                    }
                                    else
                                    {
                                        mDateTime.Time = null;
                                    }

                                }
                                else
                                {
                                    mDateTime.Date = null;
                                    mDateTime.Time = null;
                                }
                                mDateTime.DateCode = securityMovement.SMLastTradingDateCode;
                                if (isAdd)
                                {
                                    mSecurityMovement.DateTimes.Add(mDateTime);
                                }
                            }
                            else
                            {
                                MDateTime mDateTime = mSecurityMovement.DateTimes.FirstOrDefault(x => x.Qualifier == "LTRD");
                                if (mDateTime != null)
                                {
                                    mDateTime.Time = null;
                                    mDateTime.Date = null;
                                    mDateTime.DateCode = null;
                                }
                            }

                            if (securityMovement.SMPariPassuDateCode != "NA" && (securityMovement.SMPariPassuDate != null || securityMovement.SMPariPassuDateCode != null))
                            {
                                MDateTime mDateTime = mSecurityMovement.DateTimes.FirstOrDefault(x => x.Qualifier == "PPDT");
                                Boolean isAdd = false;
                                if (mDateTime == null)
                                {
                                    mDateTime = new MDateTime();
                                    isAdd = true;
                                }
                                mDateTime.Qualifier = "PPDT";
                                if (securityMovement.SMPariPassuDate != null)
                                {
                                    mDateTime.Date = securityMovement.SMPariPassuDate.Value.ToString("yyyyMMdd");

                                    if (securityMovement.SMPariPassuDate.Value.ToString("HHmmss") != "000000")
                                    {
                                        mDateTime.Time = securityMovement.SMPariPassuDate.Value.ToString("HHmmss");
                                    }
                                    else
                                    {
                                        mDateTime.Time = null;
                                    }

                                }
                                else
                                {
                                    mDateTime.Date = null;
                                    mDateTime.Time = null;
                                }
                                mDateTime.DateCode = securityMovement.SMPariPassuDateCode;
                                if (isAdd)
                                {
                                    mSecurityMovement.DateTimes.Add(mDateTime);
                                }
                            }
                            else
                            {
                                MDateTime mDateTime = mSecurityMovement.DateTimes.FirstOrDefault(x => x.Qualifier == "PPDT");
                                if (mDateTime != null)
                                {
                                    mDateTime.Time = null;
                                    mDateTime.Date = null;
                                    mDateTime.DateCode = null;
                                }
                            }

                            if (securityMovement.SMCreditorDebit == "DEBT")
                            {
                                if (securityMovement.SMDebitPaymentDateCode != "NA" && (securityMovement.SMDebitPaymentDate != null || securityMovement.SMDebitPaymentDateCode != null))
                                {
                                    MDateTime mDateTime = mSecurityMovement.DateTimes.FirstOrDefault(x => x.Qualifier == "PAYD");
                                    Boolean isAdd = false;
                                    if (mDateTime == null)
                                    {
                                        mDateTime = new MDateTime();
                                        isAdd = true;
                                    }
                                    mDateTime.Qualifier = "PAYD";
                                    if (securityMovement.SMDebitPaymentDate != null)
                                    {
                                        mDateTime.Date = securityMovement.SMDebitPaymentDate.Value.ToString("yyyyMMdd");

                                        if (securityMovement.SMDebitPaymentDate.Value.ToString("HHmmss") != "000000")
                                        {
                                            mDateTime.Time = securityMovement.SMDebitPaymentDate.Value.ToString("HHmmss");
                                        }
                                        else
                                        {
                                            mDateTime.Time = null;
                                        }

                                    }
                                    else
                                    {
                                        mDateTime.Date = null;
                                        mDateTime.Time = null;
                                    }
                                    mDateTime.DateCode = securityMovement.SMDebitPaymentDateCode;
                                    if (isAdd)
                                    {
                                        mSecurityMovement.DateTimes.Add(mDateTime);
                                    }
                                }
                                else
                                {
                                    MDateTime mDateTime = mSecurityMovement.DateTimes.FirstOrDefault(x => x.Qualifier == "PAYD");
                                    if (mDateTime != null)
                                    {
                                        mDateTime.Time = null;
                                        mDateTime.Date = null;
                                        mDateTime.DateCode = null;
                                    }
                                }
                            }
                            else
                            {
                                if (securityMovement.SMPaymentDateCode != "NA" && (securityMovement.SMPaymentDate != null || securityMovement.SMPaymentDateCode != null))
                                {
                                    MDateTime mDateTime = mSecurityMovement.DateTimes.FirstOrDefault(x => x.Qualifier == "PAYD");
                                    Boolean isAdd = false;
                                    if (mDateTime == null)
                                    {
                                        mDateTime = new MDateTime();
                                        isAdd = true;
                                    }
                                    mDateTime.Qualifier = "PAYD";
                                    if (securityMovement.SMPaymentDate != null)
                                    {
                                        mDateTime.Date = securityMovement.SMPaymentDate.Value.ToString("yyyyMMdd");

                                        if (securityMovement.SMPaymentDate.Value.ToString("HHmmss") != "000000")
                                        {
                                            mDateTime.Time = securityMovement.SMPaymentDate.Value.ToString("HHmmss");
                                        }
                                        else
                                        {
                                            mDateTime.Time = null;
                                        }

                                    }
                                    else
                                    {
                                        mDateTime.Date = null;
                                        mDateTime.Time = null;
                                    }
                                    mDateTime.DateCode = securityMovement.SMPaymentDateCode;
                                    if (isAdd)
                                    {
                                        mSecurityMovement.DateTimes.Add(mDateTime);
                                    }
                                }
                                else
                                {
                                    MDateTime mDateTime = mSecurityMovement.DateTimes.FirstOrDefault(x => x.Qualifier == "PAYD");
                                    if (mDateTime != null)
                                    {
                                        mDateTime.Time = null;
                                        mDateTime.Date = null;
                                        mDateTime.DateCode = null;
                                    }
                                }
                            }

                            //92a
                            if (mSecurityMovement.Rates == null)
                            {
                                mSecurityMovement.Rates = new List<MRate>();
                            }

                            if (securityMovement.SMAdditionalSecuritiesRateTypeCode != "NA" && (securityMovement.SMAdditionalSecuritiesNewQuantity != null ||
                            securityMovement.SMAdditionalSecuritiesOldQuantity != null ||
                            securityMovement.SMAdditionalSecuritiesAmount != null
                            || securityMovement.SMAdditionalSecuritiesCurrencyCode != null
                            || securityMovement.SMAdditionalSecuritiesRateTypeCode != null
                            || securityMovement.SMAdditionalSecuritiesRateType != null))
                            {
                                MRate mRate = mSecurityMovement.Rates.FirstOrDefault(x => (x.Qualifier == "ADEX" || x.Qualifier == "ADSR" || x.Qualifier == "NEWO"));
                                Boolean isAdd = false;
                                if (mRate == null)
                                {
                                    mRate = new MRate();
                                    isAdd = true;
                                }

                                mRate.Quantity1 = securityMovement.SMAdditionalSecuritiesNewQuantity;
                                mRate.Quantity2 = securityMovement.SMAdditionalSecuritiesOldQuantity;
                                mRate.Amount = securityMovement.SMAdditionalSecuritiesAmount;
                                mRate.CurrencyCode = securityMovement.SMAdditionalSecuritiesCurrencyCode;
                                mRate.RateTypeCode = securityMovement.SMAdditionalSecuritiesRateTypeCode;
                                mRate.Qualifier = securityMovement.SMAdditionalSecuritiesRateType;
                                if (isAdd)
                                {
                                    mSecurityMovement.Rates.Add(mRate);
                                }
                            }
                            else
                            {
                                MRate mRate = mSecurityMovement.Rates.FirstOrDefault(x => (x.Qualifier == "ADEX" || x.Qualifier == "ADSR" || x.Qualifier == "NEWO"));
                                if (mRate != null)
                                {
                                    mRate.Quantity1 = null;
                                    mRate.Quantity2 = null;
                                    mRate.Amount = null;
                                    mRate.CurrencyCode = null;
                                    mRate.RateTypeCode = null;
                                }
                            }

                            // if (securityMovement.SMAdditionalForSubscribedNewQuantity != null ||
                            // securityMovement.SMAdditionalForSubscribedResultantSecuritiesOldQuantity != null
                            // || securityMovement.SMAdditionalForSubscribedResultantSecuritiesAmount != null
                            // || securityMovement.SMAdditionalForSubscribedResultantSecuritiesCurrencyCode != null
                            // || securityMovement.SMAdditionalForSubscribedResultantSecuritiesRateTypeCode != null)
                            // {

                            //     MRate mRate = mSecurityMovement.Rates.FirstOrDefault(x => x.Qualifier == "ADSR");
                            //     Boolean isAdd = false;
                            //     if (mRate == null)
                            //     {
                            //         mRate = new MRate();
                            //         isAdd = true;
                            //     }
                            //     mRate.Quantity1 = securityMovement.SMAdditionalForSubscribedNewQuantity;
                            //     mRate.Quantity2 = securityMovement.SMAdditionalForSubscribedResultantSecuritiesOldQuantity;
                            //     mRate.Amount = securityMovement.SMAdditionalForSubscribedResultantSecuritiesAmount;
                            //     mRate.CurrencyCode = securityMovement.SMAdditionalForSubscribedResultantSecuritiesCurrencyCode;
                            //     mRate.RateTypeCode = securityMovement.SMAdditionalForSubscribedResultantSecuritiesRateTypeCode;
                            //     mRate.Qualifier = "ADSR";
                            //     if (isAdd)
                            //     {
                            //         mSecurityMovement.Rates.Add(mRate);
                            //     }
                            // }

                            if (securityMovement.SMChargesOrFeesRateTypeCode != "NA" && (securityMovement.SMChargesOrFees != null
                            || securityMovement.SMChargesOrFeesCurrency != null
                            || securityMovement.SMChargesOrFeesRateTypeCode != null))
                            {
                                MRate mRate = mSecurityMovement.Rates.FirstOrDefault(x => x.Qualifier == "CHAR");
                                Boolean isAdd = false;
                                if (mRate == null)
                                {
                                    mRate = new MRate();
                                    isAdd = true;
                                }
                                mRate.Rate = securityMovement.SMChargesOrFees;
                                mRate.CurrencyCode = securityMovement.SMChargesOrFeesCurrency;
                                mRate.RateTypeCode = securityMovement.SMChargesOrFeesRateTypeCode;
                                mRate.Qualifier = "CHAR";
                                if (isAdd)
                                {
                                    mSecurityMovement.Rates.Add(mRate);
                                }
                            }
                            else
                            {
                                MRate mRate = mSecurityMovement.Rates.FirstOrDefault(x => x.Qualifier == "CHAR");
                                if (mRate != null)
                                {
                                    mRate.Amount = null;
                                    mRate.CurrencyCode = null;
                                    mRate.RateTypeCode = null;
                                }
                            }


                            if (securityMovement.SMFiscalStampRateTypeCode != "NA" && (securityMovement.SMFiscalStamp != null
                            || securityMovement.SMFiscalStampCurrency != null
                            || securityMovement.SMFiscalStampRateTypeCode != null))
                            {
                                MRate mRate = mSecurityMovement.Rates.FirstOrDefault(x => x.Qualifier == "FISC");
                                Boolean isAdd = false;
                                if (mRate == null)
                                {
                                    mRate = new MRate();
                                    isAdd = true;
                                }
                                mRate.Rate = securityMovement.SMFiscalStamp;
                                mRate.CurrencyCode = securityMovement.SMFiscalStampCurrency;
                                mRate.RateTypeCode = securityMovement.SMFiscalStampRateTypeCode;
                                mRate.Qualifier = "FISC";
                                if (isAdd)
                                {
                                    mSecurityMovement.Rates.Add(mRate);
                                }
                            }
                            else
                            {
                                MRate mRate = mSecurityMovement.Rates.FirstOrDefault(x => x.Qualifier == "FISC");
                                if (mRate != null)
                                {
                                    mRate.Amount = null;
                                    mRate.CurrencyCode = null;
                                    mRate.RateTypeCode = null;
                                }
                            }

                            // if (securityMovement.SMNewQuantity != null ||
                            // securityMovement.SMOldQuantity != null ||
                            // securityMovement.SMNewtoOldAmount != null ||
                            // securityMovement.SMNewtoOldCurrencyCode != null ||
                            // securityMovement.SMNewtoOldRateTypeCode != null)
                            // {
                            //     MRate mRate = mSecurityMovement.Rates.FirstOrDefault(x => x.Qualifier == "NEWO");
                            //     Boolean isAdd = false;
                            //     if (mRate == null)
                            //     {
                            //         mRate = new MRate();
                            //         isAdd = true;
                            //     }
                            //     mRate.Quantity1 = securityMovement.SMNewQuantity;
                            //     mRate.Quantity2 = securityMovement.SMOldQuantity;
                            //     mRate.Amount = securityMovement.SMNewtoOldAmount;
                            //     mRate.CurrencyCode = securityMovement.SMNewtoOldCurrencyCode;
                            //     mRate.RateTypeCode = securityMovement.SMNewtoOldRateTypeCode;
                            //     mRate.Qualifier = "NEWO";
                            //     if (isAdd)
                            //     {
                            //         mSecurityMovement.Rates.Add(mRate);
                            //     }
                            // }

                            if (securityMovement.SMFinancialTranscationTaxRateRateTypeCode != "NA" && (securityMovement.SMFinancialTranscationTaxRate != null ||
                            securityMovement.SMFinancialTranscationTaxRateRateTypeCode != null ||
                            securityMovement.SMFinancialTranscationTaxRateCurrency != null))
                            {
                                MRate mRate = mSecurityMovement.Rates.FirstOrDefault(x => x.Qualifier == "TRAX");
                                Boolean isAdd = false;
                                if (mRate == null)
                                {
                                    mRate = new MRate();
                                    isAdd = true;
                                }
                                mRate.Rate = securityMovement.SMFinancialTranscationTaxRate;
                                mRate.RateTypeCode = securityMovement.SMFinancialTranscationTaxRateRateTypeCode;
                                mRate.CurrencyCode = securityMovement.SMFinancialTranscationTaxRateCurrency;
                                mRate.Qualifier = "TRAX";
                                if (isAdd)
                                {
                                    mSecurityMovement.Rates.Add(mRate);
                                }
                            }
                            else
                            {
                                MRate mRate = mSecurityMovement.Rates.FirstOrDefault(x => x.Qualifier == "TRAX");
                                if (mRate != null)
                                {
                                    mRate.Amount = null;
                                    mRate.CurrencyCode = null;
                                    mRate.RateTypeCode = null;
                                }
                            }

                            //========== E1a - Finanicial Instrument attributes START =====================

                            Boolean isSMFIAAdd = false;
                            if (mSecurityMovement.FinancialInstrumentAttribute == null)
                            {
                                mSecurityMovement.FinancialInstrumentAttribute = new MFinancialInstrumentAttributes();
                            }
                            if (mSecurityMovement.FinancialInstrumentAttribute.Dates == null)
                            {
                                mSecurityMovement.FinancialInstrumentAttribute.Dates = new List<MDateTime>();
                            }
                            if (securityMovement.SMFIAMaturityDate != null)
                            {
                                isSMFIAAdd = true;
                                MDateTime mDateTime = mSecurityMovement.FinancialInstrumentAttribute.Dates.FirstOrDefault(x => x.Qualifier == "MATU");
                                Boolean isAdd = false;
                                if (mDateTime == null)
                                {
                                    mDateTime = new MDateTime();
                                    isAdd = true;
                                }
                                mDateTime.DateType = "MATU";
                                if (securityMovement.SMFIAMaturityDate != null)
                                {
                                    mDateTime.Date = securityMovement.SMFIAMaturityDate.Value.ToString("yyyyMMdd");

                                    if (securityMovement.SMFIAMaturityDate.Value.ToString("HHmmss") != "000000")
                                    {
                                        mDateTime.Time = securityMovement.SMFIAMaturityDate.Value.ToString("HHmmss");
                                    }
                                    else
                                    {
                                        mDateTime.Time = null;
                                    }

                                }
                                else
                                {
                                    mDateTime.Date = null;
                                    mDateTime.Time = null;
                                }
                                if (isAdd)
                                {
                                    mSecurityMovement.FinancialInstrumentAttribute.Dates.Add(mDateTime);
                                }
                            }
                            else
                            {
                                MDateTime mDateTime = mSecurityMovement.FinancialInstrumentAttribute.Dates.FirstOrDefault(x => x.Qualifier == "MATU");
                                if (mDateTime != null)
                                {
                                    isSMFIAAdd = true;
                                    mDateTime.Date = null;
                                    mDateTime.Time = null;
                                }

                            }
                            //========== E1a - Finanicial Instrument attributes END =====================

                            if (isSMFIAAdd == false)
                            {
                                mSecurityMovement.FinancialInstrumentAttribute = null;
                            }

                           

                            if (isSecurityAdd)
                            {
                                mCorporateActionOption.SecurityMovement.Add(mSecurityMovement);
                            }
                        });
                        //====================== E1 - Security Movement END ===================================

                        if (mCorporateActionOption.CashMovement == null)
                        {
                            mCorporateActionOption.CashMovement = new List<CaapsLinqToDB.DBModels.MCashMovement>();
                        }

                        option.cashMovements.ForEach(cashMovements =>
                        {
                            CaapsLinqToDB.DBModels.MCashMovement mCashMovement = mCorporateActionOption.CashMovement.FirstOrDefault(x => x.NumberId == cashMovements.CMCashNumber);
                            Boolean isCashAdd = false;
                            if (mCashMovement == null)
                            {
                                mCashMovement = new CaapsLinqToDB.DBModels.MCashMovement();
                                isCashAdd = true;
                            }

                            if (mCashMovement.NumberId == null)
                            {
                                mCashMovement.NumberId = cashMovements.CMCashNumber;
                            }

                            //22a
                            if (mCashMovement.Indicator == null)
                            {
                                mCashMovement.Indicator = new List<MIndicator>();
                            }

                            if (cashMovements.CMCreditOrDebit != null && cashMovements.CMCreditOrDebit != "NA")
                            {
                                MIndicator mIndicator = mCashMovement.Indicator.FirstOrDefault(x => x.Qualifier == "CRDB");
                                Boolean isAdd = false;
                                if (mIndicator == null)
                                {
                                    mIndicator = new MIndicator();
                                    isAdd = true;

                                }
                                mIndicator.Indicator = cashMovements.CMCreditOrDebit;
                                mIndicator.Qualifier = "CRDB";
                                if (isAdd)
                                {
                                    mCashMovement.Indicator.Add(mIndicator);
                                }
                            }
                            else if (cashMovements.CMCreditOrDebit == "NA")
                            {
                                MIndicator mIndicator = mCashMovement.Indicator.FirstOrDefault(x => x.Qualifier == "CRDB");
                                if (mIndicator != null)
                                {
                                    mIndicator.Indicator = null;
                                }
                            }
                            if (cashMovements.CMIssuerOrOfferorTaxability != null && cashMovements.CMIssuerOrOfferorTaxability != "NA")
                            {
                                MIndicator mIndicator = mCashMovement.Indicator.FirstOrDefault(x => x.Qualifier == "TXAP");
                                Boolean isAdd = false;
                                if (mIndicator == null)
                                {
                                    mIndicator = new MIndicator();
                                    isAdd = true;

                                }
                                mIndicator.Indicator = cashMovements.CMIssuerOrOfferorTaxability;
                                mIndicator.Qualifier = "TXAP";
                                if (isAdd)
                                {
                                    mCashMovement.Indicator.Add(mIndicator);
                                }
                            }
                            else if (cashMovements.CMIssuerOrOfferorTaxability == "NA")
                            {
                                MIndicator mIndicator = mCashMovement.Indicator.FirstOrDefault(x => x.Qualifier == "TXAP");
                                if (mIndicator != null)
                                {
                                    mIndicator.Indicator = null;
                                }
                            }
                            if (cashMovements.CMNonEligibleProceeds != null && cashMovements.CMNonEligibleProceeds != "NA")
                            {
                                MIndicator mIndicator = mCashMovement.Indicator.FirstOrDefault(x => x.Qualifier == "NELP");
                                Boolean isAdd = false;
                                if (mIndicator == null)
                                {
                                    mIndicator = new MIndicator();
                                    isAdd = true;

                                }
                                mIndicator.Indicator = cashMovements.CMNonEligibleProceeds;
                                mIndicator.Qualifier = "NELP";
                                if (isAdd)
                                {
                                    mCashMovement.Indicator.Add(mIndicator);
                                }
                            }
                            else if (cashMovements.CMNonEligibleProceeds == "NA")
                            {
                                MIndicator mIndicator = mCashMovement.Indicator.FirstOrDefault(x => x.Qualifier == "NELP");
                                if (mIndicator != null)
                                {
                                    mIndicator.Indicator = null;
                                }
                            }
                            if (cashMovements.CMTypeofIncome != null && cashMovements.CMTypeofIncome != "NA")
                            {
                                MIndicator mIndicator = mCashMovement.Indicator.FirstOrDefault(x => x.Qualifier == "ITYP");
                                Boolean isAdd = false;
                                if (mIndicator == null)
                                {
                                    mIndicator = new MIndicator();
                                    isAdd = true;

                                }
                                mIndicator.Indicator = cashMovements.CMTypeofIncome;
                                mIndicator.Qualifier = "ITYP";
                                if (isAdd)
                                {
                                    mCashMovement.Indicator.Add(mIndicator);
                                }
                            }
                            else if (cashMovements.CMTypeofIncome == "NA")
                            {
                                MIndicator mIndicator = mCashMovement.Indicator.FirstOrDefault(x => x.Qualifier == "ITYP");
                                if (mIndicator != null)
                                {
                                    mIndicator.Indicator = null;
                                }
                            }
                            //90a
                            if (mCashMovement.Price == null)
                            {
                                mCashMovement.Price = new List<MPrice>();
                            }
                            if (cashMovements.CMPricePaidPriceCode != "NA" && (cashMovements.CMPricePaid != null
                            || cashMovements.CMPricePaidAmountTypeCode != null
                            || cashMovements.CMPricePaidCurrencyCode != null
                            || cashMovements.CMPricePaidPriceCode != null))
                            {
                                MPrice mPrice = mCashMovement.Price.FirstOrDefault(x => x.Qualifier == "PRPP");
                                Boolean isAdd = false;
                                if (mPrice == null)
                                {
                                    mPrice = new MPrice();
                                    isAdd = true;

                                }
                                mPrice.Qualifier = "PRPP";
                                mPrice.Price = cashMovements.CMPricePaid;
                                mPrice.AmountTypeCode = cashMovements.CMPricePaidAmountTypeCode;
                                mPrice.CurrencyCode = cashMovements.CMPricePaidCurrencyCode;
                                mPrice.PriceCode = cashMovements.CMPricePaidPriceCode;
                                if (isAdd)
                                {
                                    mCashMovement.Price.Add(mPrice);
                                }
                            }
                            else
                            {
                                MPrice mPrice = mCashMovement.Price.FirstOrDefault(x => x.Qualifier == "PRPP");
                                if (mPrice != null)
                                {
                                    mPrice.Price = null;
                                    mPrice.AmountTypeCode = null;
                                    mPrice.CurrencyCode = null;
                                    mPrice.PriceCode = null;
                                }

                            }

                            if (cashMovements.CMPriceReceivedPriceCode != "NA" && (cashMovements.CMPriceReceived != null
                            || cashMovements.CMPriceReceivedAmountTypeCode != null
                            || cashMovements.CMPriceReceivedCurrencyCode != null
                            || cashMovements.CMPriceReceivedPriceCode != null))
                            {
                                MPrice mPrice = mCashMovement.Price.FirstOrDefault(x => x.Qualifier == "OFFR");
                                Boolean isAdd = false;
                                if (mPrice == null)
                                {
                                    mPrice = new MPrice();
                                    isAdd = true;

                                }
                                mPrice.Qualifier = "OFFR";
                                mPrice.Price = cashMovements.CMPriceReceived;
                                mPrice.AmountTypeCode = cashMovements.CMPriceReceivedAmountTypeCode;
                                mPrice.CurrencyCode = cashMovements.CMPriceReceivedCurrencyCode;
                                mPrice.PriceCode = cashMovements.CMPriceReceivedPriceCode;
                                if (isAdd)
                                {
                                    mCashMovement.Price.Add(mPrice);
                                }
                            }
                            else
                            {
                                MPrice mPrice = mCashMovement.Price.FirstOrDefault(x => x.Qualifier == "OFFR");
                                if (mPrice != null)
                                {
                                    mPrice.Price = null;
                                    mPrice.AmountTypeCode = null;
                                    mPrice.CurrencyCode = null;
                                    mPrice.PriceCode = null;
                                }

                            }

                            //98a
                            if (mCashMovement.DateTime == null)
                            {
                                mCashMovement.DateTime = new List<MDateTime>();
                            }

                            if (cashMovements.CMEarliestPaymentDateCode != "NA" && (cashMovements.CMEarliestPaymentDateTime != null || cashMovements.CMEarliestPaymentDateCode != null))
                            {
                                MDateTime mDateTime = mCashMovement.DateTime.FirstOrDefault(x => x.Qualifier == "EARL");
                                Boolean isAdd = false;
                                if (mDateTime == null)
                                {
                                    mDateTime = new MDateTime();
                                    isAdd = true;
                                }
                                mDateTime.Qualifier = "EARL";

                                if (cashMovements.CMEarliestPaymentDateTime != null)
                                {
                                    mDateTime.Date = cashMovements.CMEarliestPaymentDateTime.Value.ToString("yyyyMMdd");

                                    if (cashMovements.CMEarliestPaymentDateTime.Value.ToString("HHmmss") != "000000")
                                    {
                                        mDateTime.Time = cashMovements.CMEarliestPaymentDateTime.Value.ToString("HHmmss");
                                    }
                                    else
                                    {
                                        mDateTime.Time = null;
                                    }

                                }
                                else
                                {
                                    mDateTime.Time = null;
                                    mDateTime.Date = null;
                                }
                                mDateTime.DateCode = cashMovements.CMEarliestPaymentDateCode;
                                if (isAdd)
                                {
                                    mCashMovement.DateTime.Add(mDateTime);
                                }
                            }
                            else
                            {
                                MDateTime mDateTime = mCashMovement.DateTime.FirstOrDefault(x => x.Qualifier == "EARL");
                                if (mDateTime != null)
                                {
                                    mDateTime.Time = null;
                                    mDateTime.Date = null;
                                    mDateTime.DateCode = null;
                                }
                            }

                            if (cashMovements.CMPaymentDateCode != "NA" && (cashMovements.CMPaymentDateTime != null || cashMovements.CMPaymentDateCode != null))
                            {
                                MDateTime mDateTime = mCashMovement.DateTime.FirstOrDefault(x => x.Qualifier == "PAYD");
                                Boolean isAdd = false;
                                if (mDateTime == null)
                                {
                                    mDateTime = new MDateTime();
                                    isAdd = true;
                                }
                                mDateTime.Qualifier = "PAYD";

                                if (cashMovements.CMPaymentDateTime != null)
                                {
                                    mDateTime.Date = cashMovements.CMPaymentDateTime.Value.ToString("yyyyMMdd");

                                    if (cashMovements.CMPaymentDateTime.Value.ToString("HHmmss") != "000000")
                                    {
                                        mDateTime.Time = cashMovements.CMPaymentDateTime.Value.ToString("HHmmss");
                                    }
                                    else
                                    {
                                        mDateTime.Time = null;
                                    }

                                }
                                else
                                {
                                    mDateTime.Time = null;
                                    mDateTime.Date = null;
                                }
                                mDateTime.DateCode = cashMovements.CMPaymentDateCode;
                                if (isAdd)
                                {
                                    mCashMovement.DateTime.Add(mDateTime);
                                }
                            }
                            else
                            {
                                MDateTime mDateTime = mCashMovement.DateTime.FirstOrDefault(x => x.Qualifier == "PAYD");
                                if (mDateTime != null)
                                {
                                    mDateTime.Time = null;
                                    mDateTime.Date = null;
                                    mDateTime.DateCode = null;
                                }
                            }

                            if (mCashMovement.Rate == null)
                            {
                                mCashMovement.Rate = new List<MRate>();
                            }

                            if (cashMovements.CMChargesOrFeesRateTypeCode != "NA" && (cashMovements.CMChargesOrFees != null
                            || cashMovements.CMChargesOrFeesRateTypeCode != null
                            || cashMovements.CMChargesOrFeesCurrency != null))
                            {
                                MRate mRate = mCashMovement.Rate.FirstOrDefault(x => x.Qualifier == "CHAR");
                                Boolean isAdd = false;
                                if (mRate == null)
                                {
                                    mRate = new MRate();
                                    isAdd = true;
                                }
                                mRate.RateTypeCode = cashMovements.CMChargesOrFeesRateTypeCode;
                                mRate.Rate = cashMovements.CMChargesOrFees;
                                mRate.CurrencyCode = cashMovements.CMChargesOrFeesCurrency;
                                mRate.Qualifier = "CHAR";
                                if (isAdd)
                                {
                                    mCashMovement.Rate.Add(mRate);
                                }
                            }
                            else
                            {
                                MRate mRate = mCashMovement.Rate.FirstOrDefault(x => x.Qualifier == "CHAR");
                                if (mRate != null)
                                {
                                    mRate.RateTypeCode = null;
                                    mRate.Rate = null;
                                    mRate.CurrencyCode = null;
                                }
                            }


                            if (cashMovements.CMEarlySolicitationFeeRateTypeCode != "NA" && (cashMovements.CMEarlySolicitationFeeRate != null
                            || cashMovements.CMEarlySolicitationFeeRateTypeCode != null
                            || cashMovements.CMEarlySolicitationFeeRateCurrency != null))
                            {
                                MRate mRate = mCashMovement.Rate.FirstOrDefault(x => x.Qualifier == "ESOF");
                                Boolean isAdd = false;
                                if (mRate == null)
                                {
                                    mRate = new MRate();
                                    isAdd = true;
                                }
                                mRate.RateTypeCode = cashMovements.CMEarlySolicitationFeeRateTypeCode;
                                mRate.Rate = cashMovements.CMEarlySolicitationFeeRate;
                                mRate.CurrencyCode = cashMovements.CMEarlySolicitationFeeRateCurrency;
                                mRate.Qualifier = "ESOF";
                                if (isAdd)
                                {
                                    mCashMovement.Rate.Add(mRate);
                                }
                            }
                            else
                            {
                                MRate mRate = mCashMovement.Rate.FirstOrDefault(x => x.Qualifier == "ESOF");
                                if (mRate != null)
                                {
                                    mRate.RateTypeCode = null;
                                    mRate.Rate = null;
                                    mRate.CurrencyCode = null;
                                }
                            }

                            if (cashMovements.CMGrossDividendRateType != "NA" && (cashMovements.CMGrossDividendIndicativeRateFlag != null
                            || cashMovements.CMGrossDividendRate != null
                            || cashMovements.CMGrossDividendRateType != null
                            || cashMovements.CMGrossDividendRateCurrency != null))
                            {
                                MRate mRate = mCashMovement.Rate.FirstOrDefault(x => x.Qualifier == "GRSS");
                                Boolean isAdd = false;
                                if (mRate == null)
                                {
                                    mRate = new MRate();
                                    isAdd = true;
                                }
                                mRate.RateStatus = cashMovements.CMGrossDividendIndicativeRateFlag;
                                mRate.CurrencyCode = cashMovements.CMGrossDividendRateCurrency;
                                mRate.Rate = cashMovements.CMGrossDividendRate;
                                mRate.RateTypeCode = cashMovements.CMGrossDividendRateType;
                                mRate.Qualifier = "GRSS";
                                if (isAdd)
                                {
                                    mCashMovement.Rate.Add(mRate);
                                }
                            }
                            else
                            {
                                MRate mRate = mCashMovement.Rate.FirstOrDefault(x => x.Qualifier == "GRSS");
                                if (mRate != null)
                                {
                                    mRate.RateTypeCode = null;
                                    mRate.Rate = null;
                                    mRate.CurrencyCode = null;
                                    mRate.RateStatus = null;
                                }
                            }

                            if (cashMovements.CMInterestRateRateType != "NA" && (cashMovements.CMInterestRate != null
                            || cashMovements.CMInterestRateRateType != null
                            || cashMovements.CMInterestRateRateCurrency != null))
                            {
                                MRate mRate = mCashMovement.Rate.FirstOrDefault(x => x.Qualifier == "INTP");
                                Boolean isAdd = false;
                                if (mRate == null)
                                {
                                    mRate = new MRate();
                                    isAdd = true;
                                }
                                mRate.CurrencyCode = cashMovements.CMInterestRateRateCurrency;
                                mRate.Rate = cashMovements.CMInterestRate;
                                mRate.RateTypeCode = cashMovements.CMInterestRateRateType;
                                mRate.Qualifier = "INTP";
                                if (isAdd)
                                {
                                    mCashMovement.Rate.Add(mRate);
                                }
                            }
                            else
                            {
                                MRate mRate = mCashMovement.Rate.FirstOrDefault(x => x.Qualifier == "INTP");
                                if (mRate != null)
                                {
                                    mRate.RateTypeCode = null;
                                    mRate.Rate = null;
                                    mRate.CurrencyCode = null;
                                    mRate.RateStatus = null;
                                }
                            }

                            if (cashMovements.CMNetDividendRateType != "NA" && (cashMovements.CMNetDividendIndicativeRateFlag != null
                            || cashMovements.CMNetDividendRate != null
                            || cashMovements.CMNetDividendRateType != null
                            || cashMovements.CMNetDividendRateCurrency != null))
                            {
                                MRate mRate = mCashMovement.Rate.FirstOrDefault(x => x.Qualifier == "NETT");
                                Boolean isAdd = false;
                                if (mRate == null)
                                {
                                    mRate = new MRate();
                                    isAdd = true;
                                }
                                mRate.RateStatus = cashMovements.CMNetDividendIndicativeRateFlag;
                                mRate.CurrencyCode = cashMovements.CMNetDividendRateCurrency;
                                mRate.Rate = cashMovements.CMNetDividendRate;
                                mRate.RateTypeCode = cashMovements.CMNetDividendRateType;
                                mRate.Qualifier = "NETT";
                                if (isAdd)
                                {
                                    mCashMovement.Rate.Add(mRate);
                                }
                            }
                            else
                            {
                                MRate mRate = mCashMovement.Rate.FirstOrDefault(x => x.Qualifier == "NETT");
                                if (mRate != null)
                                {
                                    mRate.RateTypeCode = null;
                                    mRate.Rate = null;
                                    mRate.CurrencyCode = null;
                                    mRate.RateStatus = null;
                                }
                            }

                            if (cashMovements.CMApplicableRateTypeCode != "NA" && (cashMovements.CMApplicableRate != null
                            || cashMovements.CMApplicableRateTypeCode != null))
                            {
                                MRate mRate = mCashMovement.Rate.FirstOrDefault(x => x.Qualifier == "RATE");
                                Boolean isAdd = false;
                                if (mRate == null)
                                {
                                    mRate = new MRate();
                                    isAdd = true;
                                }
                                mRate.Rate = cashMovements.CMApplicableRate;
                                mRate.RateTypeCode = cashMovements.CMApplicableRateTypeCode;
                                mRate.Qualifier = "RATE";
                                if (isAdd)
                                {
                                    mCashMovement.Rate.Add(mRate);
                                }
                            }
                            else
                            {
                                MRate mRate = mCashMovement.Rate.FirstOrDefault(x => x.Qualifier == "RATE");
                                if (mRate != null)
                                {
                                    mRate.RateTypeCode = null;
                                    mRate.Rate = null;
                                }
                            }
                            if (cashMovements.CMSolicitationFeeRateTypeCode != "NA" && (cashMovements.CMSolicitationFeeRate != null
                            || cashMovements.CMSolicitationFeeRateCurrency != null
                            || cashMovements.CMSolicitationFeeRateTypeCode != null))
                            {
                                MRate mRate = mCashMovement.Rate.FirstOrDefault(x => x.Qualifier == "SOFE");
                                Boolean isAdd = false;
                                if (mRate == null)
                                {
                                    mRate = new MRate();
                                    isAdd = true;
                                }
                                mRate.CurrencyCode = cashMovements.CMSolicitationFeeRateCurrency;
                                mRate.RateTypeCode = cashMovements.CMSolicitationFeeRateTypeCode;
                                mRate.Rate = cashMovements.CMSolicitationFeeRate;
                                mRate.Qualifier = "SOFE";
                                if (isAdd)
                                {
                                    mCashMovement.Rate.Add(mRate);
                                }
                            }
                            else
                            {
                                MRate mRate = mCashMovement.Rate.FirstOrDefault(x => x.Qualifier == "SOFE");
                                if (mRate != null)
                                {
                                    mRate.RateTypeCode = null;
                                    mRate.Rate = null;
                                    mRate.CurrencyCode = null;
                                }
                            }
                            if (cashMovements.CMTaxCreditRateType != "NA" && (cashMovements.CMTaxCreditRateIndicativeRateFlag != null
                            || cashMovements.CMTaxCreditRateCurrency != null
                            || cashMovements.CMTaxCreditRate != null
                            || cashMovements.CMTaxCreditRateType != null))
                            {
                                MRate mRate = mCashMovement.Rate.FirstOrDefault(x => x.Qualifier == "TAXC");
                                Boolean isAdd = false;
                                if (mRate == null)
                                {
                                    mRate = new MRate();
                                    isAdd = true;
                                }
                                mRate.RateStatus = cashMovements.CMTaxCreditRateIndicativeRateFlag;
                                mRate.CurrencyCode = cashMovements.CMTaxCreditRateCurrency;
                                mRate.Rate = cashMovements.CMTaxCreditRate;
                                mRate.RateTypeCode = cashMovements.CMTaxCreditRateType;
                                mRate.Qualifier = "TAXC";
                                if (isAdd)
                                {
                                    mCashMovement.Rate.Add(mRate);
                                }
                            }
                            else
                            {
                                MRate mRate = mCashMovement.Rate.FirstOrDefault(x => x.Qualifier == "TAXC");
                                if (mRate != null)
                                {
                                    mRate.RateTypeCode = null;
                                    mRate.Rate = null;
                                    mRate.CurrencyCode = null;
                                }
                            }
                            if (cashMovements.CMWithHoldingTaxRateType != "NA" && (cashMovements.CMWithHoldingTaxRateCurrency != null
                            || cashMovements.CMWithHoldingTaxRate != null
                            || cashMovements.CMWithHoldingTaxRateType != null))
                            {
                                MRate mRate = mCashMovement.Rate.FirstOrDefault(x => x.Qualifier == "TAXR");
                                Boolean isAdd = false;
                                if (mRate == null)
                                {
                                    mRate = new MRate();
                                    isAdd = true;
                                }
                                mRate.CurrencyCode = cashMovements.CMWithHoldingTaxRateCurrency;
                                mRate.Rate = cashMovements.CMWithHoldingTaxRate;
                                mRate.RateTypeCode = cashMovements.CMWithHoldingTaxRateType;
                                mRate.Qualifier = "TAXR";
                                if (isAdd)
                                {
                                    mCashMovement.Rate.Add(mRate);
                                }
                            }
                            else
                            {
                                MRate mRate = mCashMovement.Rate.FirstOrDefault(x => x.Qualifier == "TAXR");
                                if (mRate != null)
                                {
                                    mRate.RateTypeCode = null;
                                    mRate.Rate = null;
                                    mRate.CurrencyCode = null;
                                }
                            }
                            if (cashMovements.CMSecondLevelTaxType != "NA" && (cashMovements.CMSecondLevelTax != null
                            || cashMovements.CMSecondLevelTaxCurrency != null
                            || cashMovements.CMSecondLevelTaxType != null))
                            {
                                MRate mRate = mCashMovement.Rate.FirstOrDefault(x => x.Qualifier == "WITL");
                                Boolean isAdd = false;
                                if (mRate == null)
                                {
                                    mRate = new MRate();
                                    isAdd = true;
                                }
                                mRate.CurrencyCode = cashMovements.CMSecondLevelTaxCurrency;
                                mRate.Rate = cashMovements.CMSecondLevelTax;
                                mRate.RateTypeCode = cashMovements.CMSecondLevelTaxType;
                                mRate.Qualifier = "WITL";
                                if (isAdd)
                                {
                                    mCashMovement.Rate.Add(mRate);
                                }
                            }
                            else
                            {
                                MRate mRate = mCashMovement.Rate.FirstOrDefault(x => x.Qualifier == "WITL");
                                if (mRate != null)
                                {
                                    mRate.RateTypeCode = null;
                                    mRate.Rate = null;
                                    mRate.CurrencyCode = null;
                                }
                            }

                            mCashMovement.ActiveStatus = cashMovements.CMStatus;

                            if (isCashAdd)
                            {
                                mCorporateActionOption.CashMovement.Add(mCashMovement);
                            }
                            //===================== E2 - Cash Movement END ========================================
                        });


                        if (isOptionAdd)
                        {
                            mt564.MessageData.CorporateActionOptions.Add(mCorporateActionOption);
                        }
                    }

                    /***==========Corporate Action Option Details fields END============***/

                    /***========== Additional Information ==========================****/
                    Boolean isAIAdd = false;
                    if (mt564.MessageData.AdditionalInformation == null)
                    {
                        mt564.MessageData.AdditionalInformation = new MAdditionalInformation();
                    }

                    if (mt564.MessageData.AdditionalInformation.Narrative == null)
                    {
                        mt564.MessageData.AdditionalInformation.Narrative = new List<MNarrative>();
                    }

                    if (!string.IsNullOrEmpty(displayData.Disclaimer))
                    {
                        isAIAdd = true;
                        MNarrative narrative = mt564.MessageData.AdditionalInformation.Narrative.FirstOrDefault(x => x.Qualifier == "DISC");
                        Boolean isAdd = false;
                        if (narrative == null)
                        {
                            narrative = new MNarrative();
                            isAdd = true;
                        }

                        narrative.Qualifier = "DISC";
                        narrative.Narrative = displayData.Disclaimer;

                        if (isAdd)
                        {
                            mt564.MessageData.AdditionalInformation.Narrative.Add(narrative);
                        }
                    }
                    else
                    {
                        MNarrative narrative = mt564.MessageData.AdditionalInformation.Narrative.FirstOrDefault(x => x.Qualifier == "DISC");
                        if (narrative != null)
                        {
                            isAIAdd = true;
                            narrative.Narrative = null;
                        }
                    }

                    if (!string.IsNullOrEmpty(displayData.AddInfoInformationtobeCompliedWith))
                    {
                        isAIAdd = true;
                        MNarrative narrative = mt564.MessageData.AdditionalInformation.Narrative.FirstOrDefault(x => x.Qualifier == "COMP");
                        Boolean isAdd = false;
                        if (narrative == null)
                        {
                            narrative = new MNarrative();
                            isAdd = true;
                        }

                        narrative.Qualifier = "COMP";
                        narrative.Narrative = displayData.AddInfoInformationtobeCompliedWith;

                        if (isAdd)
                        {
                            mt564.MessageData.AdditionalInformation.Narrative.Add(narrative);
                        }
                    }
                    else
                    {
                        MNarrative narrative = mt564.MessageData.AdditionalInformation.Narrative.FirstOrDefault(x => x.Qualifier == "COMP");
                        if (narrative != null)
                        {
                            isAIAdd = true;
                            narrative.Narrative = null;
                        }
                    }

                    if (!string.IsNullOrEmpty(displayData.ExternalComments))
                    {
                        isAIAdd = true;
                        MNarrative narrative = mt564.MessageData.AdditionalInformation.Narrative.FirstOrDefault(x => x.Qualifier == "ADTX");
                        Boolean isAdd = false;
                        if (narrative == null)
                        {
                            narrative = new MNarrative();
                            isAdd = true;
                        }

                        narrative.Qualifier = "ADTX";
                        narrative.Narrative = displayData.ExternalComments;

                        if (isAdd)
                        {
                            mt564.MessageData.AdditionalInformation.Narrative.Add(narrative);
                        }
                    }
                    else
                    {
                        MNarrative narrative = mt564.MessageData.AdditionalInformation.Narrative.FirstOrDefault(x => x.Qualifier == "ADTX");
                        if (narrative != null)
                        {
                            isAIAdd = true;
                            narrative.Narrative = null;
                        }
                    }

                    if (!string.IsNullOrEmpty(displayData.PartyContactNarrative))
                    {
                        isAIAdd = true;
                        MNarrative narrative = mt564.MessageData.AdditionalInformation.Narrative.FirstOrDefault(x => x.Qualifier == "PACO");
                        Boolean isAdd = false;
                        if (narrative == null)
                        {
                            narrative = new MNarrative();
                            isAdd = true;
                        }

                        narrative.Qualifier = "PACO";
                        narrative.Narrative = displayData.PartyContactNarrative;

                        if (isAdd)
                        {
                            mt564.MessageData.AdditionalInformation.Narrative.Add(narrative);
                        }
                    }
                    else
                    {
                        MNarrative narrative = mt564.MessageData.AdditionalInformation.Narrative.FirstOrDefault(x => x.Qualifier == "PACO");
                        if (narrative != null)
                        {
                            isAIAdd = true;
                            narrative.Narrative = null;
                        }
                    }


                    if (mt564.MessageData.AdditionalInformation.Party == null)
                    {
                        mt564.MessageData.AdditionalInformation.Party = new List<MParty>();
                    }

                    if (displayData.DropAgentBIC != null || displayData.DropAgentNameAndAddress != null)
                    {
                        isAIAdd = true;
                        MParty party = mt564.MessageData.AdditionalInformation.Party.FirstOrDefault(x => x.Qualifier == "DROP");
                        Boolean isAdd = false;
                        if (party == null)
                        {
                            party = new MParty();
                            isAdd = true;
                        }

                        party.Qualifier = "DROP";
                        party.IdentifierCode = displayData.DropAgentBIC;
                        party.NameAndAddress = displayData.DropAgentNameAndAddress;

                        if (isAdd)
                        {
                            mt564.MessageData.AdditionalInformation.Party.Add(party);
                        }
                    }
                    else
                    {
                        MParty party = mt564.MessageData.AdditionalInformation.Party.FirstOrDefault(x => x.Qualifier == "DROP");
                        if (party != null)
                        {
                            isAIAdd = true;
                            party.IdentifierCode = null;
                            party.NameAndAddress = null;
                        }
                    }

                    if (displayData.InformationAgentBIC != null || displayData.InformationAgentNameAndAddress != null)
                    {
                        isAIAdd = true;
                        MParty party = mt564.MessageData.AdditionalInformation.Party.FirstOrDefault(x => x.Qualifier == "INFA");
                        Boolean isAdd = false;
                        if (party == null)
                        {
                            party = new MParty();
                            isAdd = true;
                        }

                        party.Qualifier = "INFA";
                        party.IdentifierCode = displayData.InformationAgentBIC;
                        party.NameAndAddress = displayData.InformationAgentNameAndAddress;

                        if (isAdd)
                        {
                            mt564.MessageData.AdditionalInformation.Party.Add(party);
                        }
                    }
                    else
                    {
                        MParty party = mt564.MessageData.AdditionalInformation.Party.FirstOrDefault(x => x.Qualifier == "INFA");
                        if (party != null)
                        {
                            isAIAdd = true;
                            party.IdentifierCode = null;
                            party.NameAndAddress = null;
                        }
                    }

                    if (displayData.IssuerAgentBIC != null || displayData.IssuerAgentNameAndAddress != null)
                    {
                        isAIAdd = true;
                        MParty party = mt564.MessageData.AdditionalInformation.Party.FirstOrDefault(x => x.Qualifier == "ISAG");
                        Boolean isAdd = false;
                        if (party == null)
                        {
                            party = new MParty();
                            isAdd = true;
                        }

                        party.Qualifier = "ISAG";
                        party.IdentifierCode = displayData.IssuerAgentBIC;
                        party.NameAndAddress = displayData.IssuerAgentNameAndAddress;

                        if (isAdd)
                        {
                            mt564.MessageData.AdditionalInformation.Party.Add(party);
                        }
                    }
                    else
                    {
                        MParty party = mt564.MessageData.AdditionalInformation.Party.FirstOrDefault(x => x.Qualifier == "ISAG");
                        if (party != null)
                        {
                            isAIAdd = true;
                            party.IdentifierCode = null;
                            party.NameAndAddress = null;
                        }
                    }

                    if (displayData.PayingAgentBIC != null || displayData.PayingAgentNameAndAddress != null)
                    {
                        isAIAdd = true;
                        MParty party = mt564.MessageData.AdditionalInformation.Party.FirstOrDefault(x => x.Qualifier == "PAYA");
                        Boolean isAdd = false;
                        if (party == null)
                        {
                            party = new MParty();
                            isAdd = true;
                        }

                        party.Qualifier = "PAYA";
                        party.IdentifierCode = displayData.PayingAgentBIC;
                        party.NameAndAddress = displayData.PayingAgentNameAndAddress;

                        if (isAdd)
                        {
                            mt564.MessageData.AdditionalInformation.Party.Add(party);
                        }
                    }
                    else
                    {
                        MParty party = mt564.MessageData.AdditionalInformation.Party.FirstOrDefault(x => x.Qualifier == "PAYA");
                        if (party != null)
                        {
                            isAIAdd = true;
                            party.IdentifierCode = null;
                            party.NameAndAddress = null;
                        }
                    }

                    if (displayData.PhysicalSecuritiesAgentBIC != null || displayData.PhysicalSecuritiesAgentNameAndAddress != null)
                    {
                        isAIAdd = true;
                        MParty party = mt564.MessageData.AdditionalInformation.Party.FirstOrDefault(x => x.Qualifier == "PSAG");
                        Boolean isAdd = false;
                        if (party == null)
                        {
                            party = new MParty();
                            isAdd = true;
                        }

                        party.Qualifier = "PSAG";
                        party.IdentifierCode = displayData.PhysicalSecuritiesAgentBIC;
                        party.NameAndAddress = displayData.PhysicalSecuritiesAgentNameAndAddress;

                        if (isAdd)
                        {
                            mt564.MessageData.AdditionalInformation.Party.Add(party);
                        }
                    }
                    else
                    {
                        MParty party = mt564.MessageData.AdditionalInformation.Party.FirstOrDefault(x => x.Qualifier == "PSAG");
                        if (party != null)
                        {
                            isAIAdd = true;
                            party.IdentifierCode = null;
                            party.NameAndAddress = null;
                        }
                    }

                    if (displayData.RegistrarAgentBIC != null || displayData.RegistrarAgentNameAndAddress != null)
                    {
                        isAIAdd = true;
                        MParty party = mt564.MessageData.AdditionalInformation.Party.FirstOrDefault(x => x.Qualifier == "REGR");
                        Boolean isAdd = false;
                        if (party == null)
                        {
                            party = new MParty();
                            isAdd = true;
                        }

                        party.Qualifier = "REGR";
                        party.IdentifierCode = displayData.DropAgentBIC;
                        party.NameAndAddress = displayData.DropAgentNameAndAddress;

                        if (isAdd)
                        {
                            mt564.MessageData.AdditionalInformation.Party.Add(party);
                        }
                    }
                    else
                    {
                        MParty party = mt564.MessageData.AdditionalInformation.Party.FirstOrDefault(x => x.Qualifier == "REGR");
                        if (party != null)
                        {
                            isAIAdd = true;
                            party.IdentifierCode = null;
                            party.NameAndAddress = null;
                        }
                    }

                    if (displayData.ResellingAgentBIC != null || displayData.ResellingAgentNameAndAddress != null)
                    {
                        isAIAdd = true;
                        MParty party = mt564.MessageData.AdditionalInformation.Party.FirstOrDefault(x => x.Qualifier == "RESA");
                        Boolean isAdd = false;
                        if (party == null)
                        {
                            party = new MParty();
                            isAdd = true;
                        }

                        party.Qualifier = "RESA";
                        party.IdentifierCode = displayData.ResellingAgentBIC;
                        party.NameAndAddress = displayData.ResellingAgentNameAndAddress;

                        if (isAdd)
                        {
                            mt564.MessageData.AdditionalInformation.Party.Add(party);
                        }
                    }
                    else
                    {
                        MParty party = mt564.MessageData.AdditionalInformation.Party.FirstOrDefault(x => x.Qualifier == "RESA");
                        if (party != null)
                        {
                            isAIAdd = true;
                            party.IdentifierCode = null;
                            party.NameAndAddress = null;
                        }
                    }

                    if (displayData.SolicitationAgentBIC != null || displayData.SolicitationAgentNameAndAddress != null)
                    {
                        isAIAdd = true;
                        MParty party = mt564.MessageData.AdditionalInformation.Party.FirstOrDefault(x => x.Qualifier == "SOLA");
                        Boolean isAdd = false;
                        if (party == null)
                        {
                            party = new MParty();
                            isAdd = true;
                        }

                        party.Qualifier = "SOLA";
                        party.IdentifierCode = displayData.SolicitationAgentBIC;
                        party.NameAndAddress = displayData.SolicitationAgentNameAndAddress;

                        if (isAdd)
                        {
                            mt564.MessageData.AdditionalInformation.Party.Add(party);
                        }
                    }
                    else
                    {
                        MParty party = mt564.MessageData.AdditionalInformation.Party.FirstOrDefault(x => x.Qualifier == "SOLA");
                        if (party != null)
                        {
                            isAIAdd = true;
                            party.IdentifierCode = null;
                            party.NameAndAddress = null;
                        }
                    }

                    if (displayData.SubPayingAgentBIC != null || displayData.SubPayingAgentNameAndAddress != null)
                    {
                        isAIAdd = true;
                        MParty party = mt564.MessageData.AdditionalInformation.Party.FirstOrDefault(x => x.Qualifier == "CODO");
                        Boolean isAdd = false;
                        if (party == null)
                        {
                            party = new MParty();
                            isAdd = true;
                        }

                        party.Qualifier = "CODO";
                        party.IdentifierCode = displayData.SubPayingAgentBIC;
                        party.NameAndAddress = displayData.SubPayingAgentNameAndAddress;

                        if (isAdd)
                        {
                            mt564.MessageData.AdditionalInformation.Party.Add(party);
                        }
                    }
                    else
                    {
                        MParty party = mt564.MessageData.AdditionalInformation.Party.FirstOrDefault(x => x.Qualifier == "CODO");
                        if (party != null)
                        {
                            isAIAdd = true;
                            party.IdentifierCode = null;
                            party.NameAndAddress = null;
                        }
                    }

                    if (isAIAdd == false)
                    {
                        mt564.MessageData.AdditionalInformation = null;
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            return mt564;
        }

        public AdditionalInfoFlags CheckAdditionInfoFlags(MT564Message mt564)
        {
            //70E
            AdditionalInfoFlags flagStatus = new AdditionalInfoFlags();
            try
            {
                if (mt564.MessageData.AdditionalInformation != null && mt564.MessageData.AdditionalInformation.Narrative != null)
                {
                    mt564.MessageData.AdditionalInformation.Narrative.ToList().ForEach(narrative =>
                    {
                        if (narrative.Qualifier == "TXNR")
                        {
                            flagStatus.IsNarrativeVersionUpdated = true;
                        }
                        else if (narrative.Qualifier == "TAXE")
                        {
                            flagStatus.IsTaxationConditionUpdated = true;
                        }
                        else if (narrative.Qualifier == "ADTX")
                        {
                            flagStatus.IsAdditionTextUpdated = true;
                        }
                        else if (narrative.Qualifier == "INCO")
                        {
                            flagStatus.IsInformationConditionsUpdated = true;
                        }
                        else if (narrative.Qualifier == "COMP")
                        {
                            flagStatus.IsInformationToComplyUpdated = true;
                        }
                    });
                }

                if (mt564.MessageData.CorporateActionOptions != null)
                {
                    mt564.MessageData.CorporateActionOptions.ToList().ForEach(option =>
                    {

                        if (option.DateTime != null)
                        {
                            option.DateTime.ToList().ForEach(dateTime =>
                            {
                                Nullable<DateTime> finalDate = null;
                                if (!String.IsNullOrEmpty(dateTime.Date))
                                {
                                    if (!String.IsNullOrEmpty(dateTime.Time))
                                    {
                                        finalDate = DateTime.ParseExact(dateTime.Date + dateTime.Time, "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
                                    }
                                    else
                                    {
                                        finalDate = DateTime.ParseExact(dateTime.Date, "yyyyMMdd", CultureInfo.InvariantCulture);
                                    }
                                }

                                if (dateTime.Qualifier == "EARD")
                                {
                                    if (finalDate != null && (flagStatus.EarlyResponseDeadline == null ||
                                    DateTime.Compare((DateTime)finalDate, (DateTime)flagStatus.EarlyResponseDeadline) < 0))
                                    {
                                        flagStatus.EarlyResponseDeadline = finalDate;
                                    }
                                }
                                else if (dateTime.Qualifier == "RDDT")
                                {
                                    if (finalDate != null && (flagStatus.ResponseDeadline == null ||
                                    DateTime.Compare((DateTime)finalDate, (DateTime)flagStatus.ResponseDeadline) < 0))
                                    {
                                        flagStatus.ResponseDeadline = finalDate;
                                    }
                                }
                                else if (dateTime.Qualifier == "MKDT")
                                {
                                    if (finalDate != null && (flagStatus.MarketDeadline == null ||
                                    DateTime.Compare((DateTime)finalDate, (DateTime)flagStatus.MarketDeadline) < 0))
                                    {
                                        flagStatus.MarketDeadline = finalDate;
                                    }
                                }
                                else if (dateTime.Qualifier == "PODT")
                                {
                                    if (finalDate != null && (flagStatus.ProtectDate == null ||
                                    DateTime.Compare((DateTime)finalDate, (DateTime)flagStatus.ProtectDate) < 0))
                                    {
                                        flagStatus.ProtectDate = finalDate;
                                    }
                                }
                                else if (dateTime.Qualifier == "EXPI")
                                {
                                    if (finalDate != null && (flagStatus.ISOExpiryDate == null ||
                                    DateTime.Compare((DateTime)finalDate, (DateTime)flagStatus.ISOExpiryDate) < 0))
                                    {
                                        flagStatus.ISOExpiryDate = finalDate;
                                    }
                                }

                            });
                        }

                    });
                }

                if (mt564.MessageData.CorporateActionDetails.Indicator != null)
                {
                    mt564.MessageData.CorporateActionDetails.Indicator.ToList().ForEach(indicator =>
                    {

                        if (indicator.Qualifier == "CHAN")
                        {
                            flagStatus.ISOChangeType = indicator.Indicator;
                        }

                    });
                }

                if (mt564.MessageData.CorporateActionDetails.Narrative != null)
                {
                    mt564.MessageData.CorporateActionDetails.Narrative.ToList().ForEach(narrative =>
                    {

                        if (narrative.Qualifier == "OFFO")
                        {
                            flagStatus.ISOOfferor = narrative.Narrative;
                        }

                    });
                }

                // if (mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes != null)
                // {
                //     if (mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes.Dates != null)
                //     {
                //         mt564.MessageData.UnderlyingSecurities.FinancialInstrumentAttributes.Dates.ForEach(date =>
                //         {
                //             if (date.DateType == "EXPI")
                //             {
                //                 if (!String.IsNullOrEmpty(date.Date))
                //                 {
                //                     flagStatus.ISOExpiryDate = DateTime.ParseExact(date.Date, "yyyyMMdd", CultureInfo.InvariantCulture);
                //                 }
                //             }
                //         });
                //     }
                // }

                if (mt564.MessageData.CorporateActionDetails.DateTime != null)
                {
                    mt564.MessageData.CorporateActionDetails.DateTime.ToList().ForEach(dateTime =>
                    {
                        if (dateTime.Qualifier == "RDTE")
                        {
                            if (!String.IsNullOrEmpty(dateTime.Date))
                            {
                                if (!String.IsNullOrEmpty(dateTime.Time))
                                {
                                    flagStatus.ISORecordDate = DateTime.ParseExact(dateTime.Date + dateTime.Time, "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
                                }
                                else
                                {
                                    flagStatus.ISORecordDate = DateTime.ParseExact(dateTime.Date, "yyyyMMdd", CultureInfo.InvariantCulture);
                                }
                            }
                        }
                        else if (dateTime.Qualifier == "EFFD")
                        {
                            if (!String.IsNullOrEmpty(dateTime.Date))
                            {
                                if (!String.IsNullOrEmpty(dateTime.Time))
                                {
                                    flagStatus.ISOEffectiveDate = DateTime.ParseExact(dateTime.Date + dateTime.Time, "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
                                }
                                else
                                {
                                    flagStatus.ISOEffectiveDate = DateTime.ParseExact(dateTime.Date, "yyyyMMdd", CultureInfo.InvariantCulture);
                                }
                            }
                        }
                        else if (dateTime.Qualifier == "XDTE")
                        {
                            if (!String.IsNullOrEmpty(dateTime.Date))
                            {
                                if (!String.IsNullOrEmpty(dateTime.Time))
                                {
                                    flagStatus.ISOExDividendDate = DateTime.ParseExact(dateTime.Date + dateTime.Time, "yyyyMMddHHmmss", CultureInfo.InvariantCulture);
                                }
                                else
                                {
                                    flagStatus.ISOExDividendDate = DateTime.ParseExact(dateTime.Date, "yyyyMMdd", CultureInfo.InvariantCulture);
                                }
                            }
                        }
                    });
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return flagStatus;
        }

        public string GetSwiftFormatForUTC(DateTime? dt)
        {
            DateTime dtTemp;
            Logger.Log("Inside GetSwiftFormatForUTC");
            try
            {
                if (dt != null)
                {
                    dtTemp = dt.Value; // Extract the DateTime from the nullable DateTime?
                    dtTemp = new DateTime(dtTemp.Ticks, DateTimeKind.Unspecified);
                    TimeZoneInfo cst = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
                    TimeSpan offset = cst.GetUtcOffset(dtTemp);
                    string offsetStr = offset.ToString();
                    Console.WriteLine(offsetStr);

                    string ans = string.Empty;

                    if (offset.Hours < 0)
                    {
                        ans = "N" + (-offset.Hours).ToString("D2") + offset.Minutes.ToString("D2");
                    }
                    else
                    {
                        ans = offset.Hours.ToString("D2") + offset.Minutes.ToString("D2");
                    }

                    return ans;
                }
                return "";
            }
            catch (Exception ex)
            {
                dynamic logs = new ExpandoObject();
                logs.StackTrace = ex.StackTrace;
                logs.Data = "Inside GetSwiftFormatForUTC";
                Logger.LogException(ex, LogType.Error, logs);

                return "";
            }
        }

    }
}
