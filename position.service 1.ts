import { Injectable } from '@nestjs/common';
import { PositionTrackingService } from 'dinodbops/data';
import { DinoLogService } from 'dinologservice/data';
import moment = require('moment');
import * as _ from 'underscore';
import { applicationName, productDetails, productName, serverIp, webServerInfo } from '../config';

@Injectable()
export class PositionService {
  constructor(
    private readonly positionTrackingService: PositionTrackingService,
    private readonly logService: DinoLogService,
  ) {
    // this.processSecurityPortfolio(false, new Date(2023,10,14), new Date(2023,10,14));
    //this.processSecurityTraderbook(false, new Date('2023-02-01'), new Date('2023-02-08'));
    // let tranactions = [
    //   {
    //     "security_id": 275305,
    //     "effective_date": "2023-02-07 06:21:51",
    //     "traderbook_id": 33,
    //     "tradedatestr": "20230207",
    //     "trade_date": "2023-02-07 06:21:51",
    //     "trade_currency": "USD",
    //     "credit_debit_mark": "CR",
    //     "is_buy": 1,
    //     "actualqty": 2000,
    //     "qty": 2000,
    //     "price": 99.25,
    //     "trade_price_multiplier": 1,
    //     "trade_quantity_multiplier": 1
    //   },
    //   {
    //     "security_id": 275305,
    //     "effective_date": "2023-02-07 06:30:38",
    //     "traderbook_id": 33,
    //     "tradedatestr": "20230207",
    //     "trade_date": "2023-02-07 06:30:38",
    //     "trade_currency": "USD",
    //     "credit_debit_mark": "DR",
    //     "is_buy": 0,
    //     "actualqty": 2000,
    //     "qty": 2000,
    //     "price": 100.75,
    //     "trade_price_multiplier": 1,
    //     "trade_quantity_multiplier": 1
    //   },
    //   {
    //     "security_id": 275305,
    //     "effective_date": "2023-02-08 09:37:08",
    //     "traderbook_id": 33,
    //     "tradedatestr": "20230208",
    //     "trade_date": "2023-02-08 09:37:08",
    //     "trade_currency": "USD",
    //     "credit_debit_mark": "CR",
    //     "is_buy": 1,
    //     "actualqty": 1300,
    //     "qty": 1300,
    //     "price": 98.153846153846,
    //     "trade_price_multiplier": 1,
    //     "trade_quantity_multiplier": 1
    //   },
    //   {
    //     "security_id": 275305,
    //     "effective_date": "2023-02-08 09:40:34",
    //     "traderbook_id": 33,
    //     "tradedatestr": "20230208",
    //     "trade_date": "2023-02-08 09:40:34",
    //     "trade_currency": "USD",
    //     "credit_debit_mark": "DR",
    //     "is_buy": 0,
    //     "actualqty": 1300,
    //     "qty": 1300,
    //     "price": 100.769230769231,
    //     "trade_price_multiplier": 1,
    //     "trade_quantity_multiplier": 1
    //   },
    //   {
    //     "security_id": 275305,
    //     "effective_date": "2023-02-10 04:44:50",
    //     "traderbook_id": 33,
    //     "tradedatestr": "20230210",
    //     "trade_date": "2023-02-10 04:44:50",
    //     "trade_currency": "USD",
    //     "credit_debit_mark": "CR",
    //     "is_buy": 1,
    //     "actualqty": 1000,
    //     "qty": 1000,
    //     "price": 99,
    //     "trade_price_multiplier": 1,
    //     "trade_quantity_multiplier": 1
    //   },
    //   {
    //     "security_id": 275305,
    //     "effective_date": "2023-02-10 04:46:48",
    //     "traderbook_id": 33,
    //     "tradedatestr": "20230210",
    //     "trade_date": "2023-02-10 04:46:48",
    //     "trade_currency": "USD",
    //     "credit_debit_mark": "DR",
    //     "is_buy": 0,
    //     "actualqty": 1000,
    //     "qty": 1000,
    //     "price": 101,
    //     "trade_price_multiplier": 1,
    //     "trade_quantity_multiplier": 1
    //   }
    // ];
    // let returns = this.calculatePosition({}, tranactions);
    // console.log(returns);
  }

  public async getCreateOpeningPositionFromPreviousPosition(date = new Date()) {
    this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
      'position.service.ts', 'getCreateOpeningPositionFromPreviousPosition', 0, 'NA', new Date(), '',
      'NA', 'NA', 'NA',
      'date=' + date, productDetails);

    await this.positionTrackingService.getCreateOpeningPositionFromPreviousPosition(date);
  }

  public async processSecurityPortfolio(isSettlement: boolean, fromDate: Date, endDate: Date) {
    try {

      const minDateDetails = await this.positionTrackingService.getMinDateByType('portfolio');

      this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
        'position.service.ts', 'processSecurityPortfolio', 0, `NA`, new Date(), `Portfolio Min Date to start Position Tracking : ${JSON.stringify(minDateDetails)}`,
        'NA', 'NA', 'NA',
        `Portfolio Min Date to start Position Tracking : ${JSON.stringify(minDateDetails)}`, productDetails);

      let start_date = moment(moment(minDateDetails[0]['min_position_date']).add(5, 'hours').add(30, 'minutes').format('YYYY-MM-DD'));
      let current_date = moment(moment().format('YYYY-MM-DD'));
      //let start_date = moment('2023-02-01');
      let temp_start_date = moment(start_date).startOf('month');
      let temp_current_date = moment(current_date).startOf('month');

      // let start_month = moment(minDateDetails[0]['min_position_date']).month();
      // let current_month = moment().month();
      let month_difference = temp_current_date.diff(temp_start_date, 'months', true);
      month_difference = Math.ceil(month_difference) + 1;
      let count = 0;

      this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
        'position.service.ts', 'processSecurityPortfolio', 0, `NA`, new Date(), `Total Month to process : ${month_difference} , start_date = ${start_date.format('YYYY-MM-DD')} , current date = ${current_date.format('YYYY-MM-DD')}`,
        'NA', 'NA', 'NA',
        `Total Month to process : ${month_difference} , start_date = ${start_date.format('YYYY-MM-DD')} , current date = ${current_date.format('YYYY-MM-DD')}`, productDetails);

      while (count < month_difference) {
        /* 1.Get portfolio group based on is process 0 sec,proid,cur,mindate
         2.Based on portfolio - min-date to current-date select pending transaction and calculate
        */
        let start_date_of_month = moment(start_date).startOf('month');
        let end_date_of_month = moment(start_date).endOf('month');

        if (moment(end_date_of_month.format('YYYY-MM-DD') + 'T00:00:00').isSameOrAfter(moment(moment().format('YYYY-MM-DD') + 'T00:00:00'))) {
          end_date_of_month = moment(moment().format('YYYY-MM-DD'));
        }

      /*   this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
          'position.service.ts', 'processSecurityPortfolio', 0, `NA`, new Date(), `Month started to process : start_date = ${start_date_of_month.format('YYYY-MM-DD')} , end date = ${end_date_of_month.format('YYYY-MM-DD')}`,
          'NA', 'NA', 'NA',
          `Month started to process : start_date = ${start_date_of_month.format('YYYY-MM-DD')} , end date = ${end_date_of_month.format('YYYY-MM-DD')}`, productDetails);
 */
        let pendingPortfolios = await this.positionTrackingService.getMinDatePortfolioWise(isSettlement ? 1 : 0, start_date_of_month.format('YYYY-MM-DD'), end_date_of_month.format('YYYY-MM-DD'));
        let existingPositionsSubmitted = await this.positionTrackingService.getPortfolioDailySummary(start_date_of_month.format('YYYY-MM-DD'), end_date_of_month.format('YYYY-MM-DD'), pendingPortfolios.map(x => x.portfolio_id).join(','), null as any);
        let existingPositionsSubmittedMap = new Map();

        existingPositionsSubmitted.forEach(position => {
          existingPositionsSubmittedMap.set(position.identifier_id + '-' + position.security_id + '-' + moment(position.as_on_date).format('YYYY-MM-DD') + '-' + position.currency, position);
        });

        for (let index = 0; index < pendingPortfolios.length; index++) {

          const pendingPortfolio = pendingPortfolios[index];

          /* this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
            'position.service.ts', 'processSecurityPortfolio', 0, `NA`, new Date(), `portfolio started to process : ${JSON.stringify(pendingPortfolio)}`,
            'NA', 'NA', 'NA',
            `portfolio started to process : ${JSON.stringify(pendingPortfolio)}, Loop ${index} of ${pendingPortfolios.length}`, productDetails);
 */
          let initial_start_date = start_date_of_month;
          let initial_end_date = end_date_of_month

          /* this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
            'position.service.ts', 'processSecurityPortfolio', 0, `NA`, new Date(), `portfolio process start date : ${initial_start_date.format('YYYY-MM-DD')} end date : ${initial_end_date.format('YYYY-MM-DD')}`,
            'NA', 'NA', 'NA',
            `portfolio process start date : ${initial_start_date.format('YYYY-MM-DD')} end date : ${initial_end_date.format('YYYY-MM-DD')}`, productDetails);
 */
          const previousDate = moment(initial_start_date.format('YYYY-MM-DD')).subtract(1, 'days').format('YYYY-MM-DD');
          let lastOpenPosition = await this.getOpenPositionForSecurityPortfolio(pendingPortfolio, previousDate, isSettlement);
          let pendingTransactions = await this.positionTrackingService.getPendingPositionTransactionPortfolioWise(
            isSettlement ? 1 : 0, initial_start_date.format('YYYY-MM-DD'), pendingPortfolio.security_id, pendingPortfolio.portfolio_id,
            pendingPortfolio.trade_currency, initial_end_date.format('YYYY-MM-DD'));

          /* this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
            'position.service.ts', 'processSecurityPortfolio', 0, `NA`, new Date(), `last open position : ${JSON.stringify(lastOpenPosition ? lastOpenPosition : {})}`,
            'NA', 'NA', 'NA',
            `last open position : ${JSON.stringify(lastOpenPosition ? lastOpenPosition : {})}`, productDetails);

          this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
            'position.service.ts', 'processSecurityPortfolio', 0, `NA`, new Date(), `pending position transaction : ${JSON.stringify(pendingTransactions)}`,
            'NA', 'NA', 'NA',
            `pending position transaction : ${JSON.stringify(pendingTransactions)}`, productDetails); */

          if (pendingTransactions && pendingTransactions.length > 0) {

            this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
              'position.service.ts', 'processSecurityPortfolio', 0, `NA`, new Date(), `portfolio started to process : ${JSON.stringify(pendingPortfolio)}`,
              'NA', 'NA', 'NA',
              `portfolio started to process : ${JSON.stringify(pendingPortfolio)}, Loop ${index} of ${pendingPortfolios.length}`, productDetails);
  
            //security portfolio wise calculation
            await this.calculatePosition(lastOpenPosition, pendingTransactions);

            this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
              'position.service.ts', 'processSecurityPortfolio', 0, `NA`, new Date(), `calculated transaction : ${JSON.stringify(pendingTransactions)}`,
              'NA', 'NA', 'NA',
              `calculated transaction`, productDetails);


            await this.submitClosePositionForSecurityPortfolio(pendingPortfolio, lastOpenPosition,
              pendingTransactions, initial_start_date.format('YYYY-MM-DD'), initial_end_date.format('YYYY-MM-DD'), isSettlement, existingPositionsSubmittedMap);
          }
          else {
            await this.submitClosePositionForSecurityPortfolio(pendingPortfolio, lastOpenPosition,
              pendingTransactions, initial_start_date.format('YYYY-MM-DD'), initial_end_date.format('YYYY-MM-DD'), isSettlement, existingPositionsSubmittedMap);
          }
        }

        await this.positionTrackingService.updateLNPositionMonthlyStatus('portfolio', String(Number(moment(start_date).month() + 1)), String(moment(start_date).year()), 'Processed', 1, 999999);

        start_date.add(1, 'months');
        count++;
      }

    } catch (error) {
      this.logService.Error(serverIp, webServerInfo, productName, applicationName,
        'event.service.ts', 'processSecurityPortfolio', 0, 'NA', new Date(), 'Error in processing security position for portfolio',
        'NA', 'NA', 'NA',
        'Error in processing security position for portfolio', productDetails, error);
    }
  }

  public async processSecurityTraderbook(isSettlement: boolean, fromDate: Date, endDate: Date) {
    try {

      const minDateDetails = await this.positionTrackingService.getMinDateByType('traderbook');

      this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
        'position.service.ts', 'processSecurityTraderbook', 0, `NA`, new Date(), `Traderbook Min Date to start Position Tracking : ${JSON.stringify(minDateDetails)}`,
        'NA', 'NA', 'NA',
        `Traderbook Min Date to start Position Tracking : ${JSON.stringify(minDateDetails)}`, productDetails);


      let start_date = moment(moment(minDateDetails[0]['min_position_date']).add(5, 'hours').add(30, 'minutes').format('YYYY-MM-DD'));
      //console.log(start_date.format('YYYY-MM-DD'));
      let current_date = moment(moment().format('YYYY-MM-DD'));
      //let start_date = moment('2023-02-01');
      let temp_start_date = moment(start_date).startOf('month');
      let temp_current_date = moment(current_date).startOf('month');

      // let start_month = moment(minDateDetails[0]['min_position_date']).month();
      // let current_month = moment().month();
      let month_difference = temp_current_date.diff(temp_start_date, 'months', true);
      month_difference = Math.ceil(month_difference) + 1;
      let count = 0;

      this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
        'position.service.ts', 'processSecurityTraderbook', 0, `NA`, new Date(), `Total Month to process : ${month_difference} , start_date = ${start_date.format('YYYY-MM-DD')} , current date = ${current_date.format('YYYY-MM-DD')}`,
        'NA', 'NA', 'NA',
        `Total Month to process : ${month_difference} , start_date = ${start_date.format('YYYY-MM-DD')} , current date = ${current_date.format('YYYY-MM-DD')}`, productDetails);



      while (count < month_difference) {
        /* 1.Get portfolio group based on is process 0 sec,proid,cur,mindate
         2.Based on portfolio - min-date to current-date select pending transaction and calculate
        */
        let start_date_of_month = moment(start_date).startOf('month');
        let end_date_of_month = moment(start_date).endOf('month');
        if (moment(end_date_of_month.format('YYYY-MM-DD') + 'T00:00:00').isSameOrAfter(moment(moment().format('YYYY-MM-DD') + 'T00:00:00'))) {
          end_date_of_month = moment(moment().format('YYYY-MM-DD'));
        }

        this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
          'position.service.ts', 'processSecurityTraderbook', 0, `NA`, new Date(), `Month started to process : start_date = ${start_date_of_month.format('YYYY-MM-DD')} , end date = ${end_date_of_month.format('YYYY-MM-DD')}`,
          'NA', 'NA', 'NA',
          `Month started to process : start_date = ${start_date_of_month.format('YYYY-MM-DD')} , end date = ${end_date_of_month.format('YYYY-MM-DD')}`, productDetails);



        // console.log(start_date_of_month.format('YYYY-MM-DD'));
        // console.log(end_date_of_month.format('YYYY-MM-DD'));
        let pendingTraderbook = await this.positionTrackingService.getMinDateTraderbookWise(isSettlement ? 1 : 0, start_date_of_month.format('YYYY-MM-DD'), end_date_of_month.format('YYYY-MM-DD'));
        let existingPositionsSubmitted = await this.positionTrackingService.getTraderBookDailySummary(start_date_of_month.format('YYYY-MM-DD'), end_date_of_month.format('YYYY-MM-DD'), pendingTraderbook.map(x => x.traderbook_id).join(','), null as any);
        let existingPositionsSubmittedMap = new Map();

        existingPositionsSubmitted.forEach(position => {
          existingPositionsSubmittedMap.set(position.identifier_id + '-' + position.security_id + '-' + moment(position.as_on_date).format('YYYY-MM-DD') + '-' + position.currency, position);
        });

        // pendingPortfolios = [{
        //   security_id: 587683,
        //   traderbook_id: '93',
        //   trade_currency: 'USD',
        //   min_date: '2023-02-06T18:30:00.000Z'
        // }]
        //console.log(pendingPortfolios);
        for (let index = 0; index < pendingTraderbook.length; index++) {

          const pendingPortfolio = pendingTraderbook[index];

           
          let initial_start_date = start_date_of_month;
          let initial_end_date = end_date_of_month

          const previousDate = moment(initial_start_date.format('YYYY-MM-DD')).subtract(1, 'days').format('YYYY-MM-DD');
          let lastOpenPosition = await this.getOpenPositionForSecurityTraderbook(pendingPortfolio, previousDate, isSettlement);
          let pendingTransactions = await this.positionTrackingService.getPendingPositionTransactionTraderBookWise(
            isSettlement ? 1 : 0, initial_start_date.format('YYYY-MM-DD'), pendingPortfolio.traderbook_id, pendingPortfolio.security_id,
            pendingPortfolio.trade_currency, initial_end_date.format('YYYY-MM-DD'));

         /*  this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
            'position.service.ts', 'processSecurityTraderbook', 0, `NA`, new Date(), `last open position : ${JSON.stringify(lastOpenPosition ? lastOpenPosition : {})}`,
            'NA', 'NA', 'NA',
            `last open position : ${JSON.stringify(lastOpenPosition ? lastOpenPosition : {})}`, productDetails);

          this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
            'position.service.ts', 'processSecurityTraderbook', 0, `NA`, new Date(), `pending position transaction : ${JSON.stringify(pendingTransactions)}`,
            'NA', 'NA', 'NA',
            `pending position transaction : ${JSON.stringify(pendingTransactions)}`, productDetails);
 */
          if (pendingTransactions && pendingTransactions.length > 0) {

            this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
              'position.service.ts', 'processSecurityTraderbook', 0, `NA`, new Date(), `traderbook started to process : ${JSON.stringify(pendingPortfolio)}`,
              'NA', 'NA', 'NA',
              `traderbook started to process : ${JSON.stringify(pendingPortfolio)} Loop ${index} of ${pendingTraderbook.length}`, productDetails);
   
            //security portfolio wise calculation
            await this.calculatePosition(lastOpenPosition, pendingTransactions);
            // console.log('calculated details');
            // console.log(pendingTransactions);
            this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
              'position.service.ts', 'processSecurityTraderbook', 0, `NA`, new Date(), `calculated transaction : ${JSON.stringify(pendingTransactions)}`,
              'NA', 'NA', 'NA',
              `calculated transaction : ${JSON.stringify(pendingTransactions)}`, productDetails);

            await this.submitClosePositionForSecurityTraderBook(pendingPortfolio, lastOpenPosition,
              pendingTransactions, initial_start_date.format('YYYY-MM-DD'), initial_end_date.format('YYYY-MM-DD'), isSettlement, existingPositionsSubmittedMap);
          }
          else {
            await this.submitClosePositionForSecurityTraderBook(pendingPortfolio, lastOpenPosition,
              pendingTransactions, initial_start_date.format('YYYY-MM-DD'), initial_end_date.format('YYYY-MM-DD'), isSettlement, existingPositionsSubmittedMap);
          }
        }

        await this.positionTrackingService.updateLNPositionMonthlyStatus('traderbook', String(Number(moment(start_date).month() + 1)), String(moment(start_date).year()), 'Processed', 1, 999999);

        start_date.add(1, 'months');
        count++;
      }
    } catch (error) {
      this.logService.Error(serverIp, webServerInfo, productName, applicationName,
        'event.service.ts', 'processSecurityTraderbook', 0, 'NA', new Date(), 'Error in processing security position for traderbook',
        'NA', 'NA', 'NA',
        'Error in processing security position for traderbook', productDetails, error);
    }
  }

  public async processSecurityCustodian(isSettlement: boolean, fromDate: Date, endDate: Date) {
    try {

      const minDateDetails = await this.positionTrackingService.getMinDateByType('custodian');
      //console.log(minDateDetails);
      let start_date = moment(moment(minDateDetails[0]['min_position_date']).add(5, 'hours').add(30, 'minutes').format('YYYY-MM-DD'));
      let current_date = moment(moment().format('YYYY-MM-DD'));
      //let start_date = moment('2023-02-01');
      let temp_start_date = moment(start_date).startOf('month');
      let temp_current_date = moment(current_date).startOf('month');

      // let start_month = moment(minDateDetails[0]['min_position_date']).month();
      // let current_month = moment().month();
      let month_difference = temp_current_date.diff(temp_start_date, 'months', true);
      month_difference = Math.ceil(month_difference) + 1;
      let count = 0;

      //console.log(month_difference);
      while (count < month_difference) {
        /* 1.Get portfolio group based on is process 0 sec,proid,cur,mindate
         2.Based on portfolio - min-date to current-date select pending transaction and calculate
        */
        let start_date_of_month = moment(start_date).startOf('month');
        let end_date_of_month = moment(start_date).endOf('month');
        if (moment(end_date_of_month.format('YYYY-MM-DD') + 'T00:00:00').isSameOrAfter(moment(moment().format('YYYY-MM-DD') + 'T00:00:00'))) {
          end_date_of_month = moment(moment().format('YYYY-MM-DD'));
        }
        let pendingPortfolios = await this.positionTrackingService.getMinDateCustodianWise(isSettlement ? 1 : 0, start_date_of_month.format('YYYY-MM-DD'), end_date_of_month.format('YYYY-MM-DD'));

        for (let index = 0; index < pendingPortfolios.length; index++) {

          const pendingPortfolio = pendingPortfolios[index];

          this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
            'position.service.ts', 'processSecurityCustodian', 0, `NA`, new Date(), `custodian started to process : ${JSON.stringify(pendingPortfolio)}`,
            'NA', 'NA', 'NA',
            `custodian started to process : ${JSON.stringify(pendingPortfolio)} Loop ${index} of ${pendingPortfolios.length}`, productDetails);

          let initial_start_date = start_date_of_month;
          let initial_end_date = end_date_of_month

          const previousDate = moment(initial_start_date.format('YYYY-MM-DD')).subtract(1, 'days').format('YYYY-MM-DD');

          let lastOpenPosition = await this.getOpenPositionForSecurityCustodian(pendingPortfolio, previousDate, isSettlement);
          let pendingTransactions = await this.positionTrackingService.getPendingPositionTransactionCustodianWise(
            isSettlement ? 1 : 0, initial_start_date.format('YYYY-MM-DD'), pendingPortfolio.custodian_id, pendingPortfolio.security_id, pendingPortfolio.custodian_security_account,
            pendingPortfolio.trade_currency, initial_end_date.format('YYYY-MM-DD'));

          if (pendingTransactions && pendingTransactions.length > 0) {
            //security portfolio wise calculation
            await this.calculatePosition(lastOpenPosition, pendingTransactions);
            await this.submitClosePositionForSecurityCustodian(pendingPortfolio, lastOpenPosition,
              pendingTransactions, initial_start_date.format('YYYY-MM-DD'), initial_end_date.format('YYYY-MM-DD'), isSettlement);
          }
          else {
            await this.submitClosePositionForSecurityCustodian(pendingPortfolio, lastOpenPosition,
              pendingTransactions, initial_start_date.format('YYYY-MM-DD'), initial_end_date.format('YYYY-MM-DD'), isSettlement);
          }
        }

        await this.positionTrackingService.updateLNPositionMonthlyStatus('custodian', String(Number(moment(start_date).month() + 1)), String(moment(start_date).year()), 'Processed', 1, 999999);

        start_date.add(1, 'months');
        count++;
      }
    } catch (error) {
      this.logService.Error(serverIp, webServerInfo, productName, applicationName,
        'event.service.ts', 'processSecurityCustodian', 0, 'NA', new Date(), 'Error in processing security position for custodian',
        'NA', 'NA', 'NA',
        'Error in processing security position for custodian', productDetails, error);
    }
  }

  private calculatePosition(lastOpenPosition: any, transactions: any) {

    try {
      var pnl = 0;
      var buyStack: any = [];
      var sellStack: any = [];
      var buyFOPposition = 0;
      var sellFOPPosition = 0;


      if (lastOpenPosition && lastOpenPosition.qty)
        lastOpenPosition.qty = Math.abs(Number(lastOpenPosition.qty));

      if (lastOpenPosition && lastOpenPosition.qty > 0) {
        if (lastOpenPosition.is_buy == "1" && lastOpenPosition.price == 0) {
          buyFOPposition += Number(lastOpenPosition.qty);
          var fopMin = Math.min(buyFOPposition, sellFOPPosition);
          buyFOPposition -= fopMin;
          sellFOPPosition -= fopMin;
        } else if (lastOpenPosition.is_buy != "1" && lastOpenPosition.price == 0) {
          sellFOPPosition += Number(lastOpenPosition.qty);
          var fopMin = Math.min(buyFOPposition, sellFOPPosition);
          buyFOPposition -= fopMin;
          sellFOPPosition -= fopMin;
        } else if (lastOpenPosition.is_buy == "1") {
          buyStack.push(lastOpenPosition);
        }
        else {
          sellStack.push(lastOpenPosition);
        }
      }

      for (let index = 0; index < transactions.length; index++) {
        // const prevElement = transactions[index - 1];
        const element = transactions[index];
        element.trade_pnl = 0;
        //Add in buy or sell stack
        if (element.is_buy == "1" && element.price == 0) {
          buyFOPposition += Number(element.qty);
          var fopMin = Math.min(buyFOPposition, sellFOPPosition);
          buyFOPposition -= fopMin;
          sellFOPPosition -= fopMin;
        } else if (element.is_buy != "1" && element.price == 0) {
          sellFOPPosition += Number(element.qty);
          var fopMin = Math.min(buyFOPposition, sellFOPPosition);
          buyFOPposition -= fopMin;
          sellFOPPosition -= fopMin;
        } else if (element.is_buy == "1") {
          buyStack.push(element);
        } else {
          sellStack.push(element);
        }

        //Setting up total qty
        element.total = element.actualqty * element.price * (element.is_buy == "1" ? -1 : 1);

        //Give impact of buy sell on stack
        if (element.price != 0) {
          if (element.is_buy == "1" && sellStack.length > 0) {
            let transactionQty = element.qty;
            let profit = 0;

            while (transactionQty > 0 && sellStack.length > 0) {
              var topSellOrder = sellStack[0];
              const curAmount = Math.min(transactionQty, topSellOrder.qty);

              sellStack[0].qty -= curAmount;
              transactionQty -= curAmount;

              profit += (curAmount * topSellOrder.price) - (curAmount * element.price);

              if (transactionQty >= topSellOrder.qty) {
                sellStack.shift();
              }
            }

            var currentElement = buyStack.pop();
            if (transactionQty > 0) {
              currentElement.qty = transactionQty;
              buyStack.push(currentElement);
            }
            element.pnl = profit;
            element.trade_pnl = (element.trade_pnl ? element.trade_pnl : 0) + profit;
            pnl += profit;

          } else if (element.is_buy == "0" && buyStack.length > 0) {
            let transactionQty = element.qty;
            let profit = 0;

            while (transactionQty > 0 && buyStack.length > 0) {
              var topBuyOrder = buyStack[0];
              const curAmount = Math.min(transactionQty, topBuyOrder.qty);

              buyStack[0].qty -= curAmount;
              transactionQty -= curAmount;

              profit += (curAmount * element.price) - (curAmount * topBuyOrder.price);

              if (transactionQty >= topBuyOrder.qty) {
                buyStack.shift();
              }
            }

            var currentElement = sellStack.pop();
            if (transactionQty > 0) {
              currentElement.qty = transactionQty;
              sellStack.push(currentElement);
            }
            element.pnl = profit;
            element.trade_pnl = (element.trade_pnl ? element.trade_pnl : 0) + profit;
            pnl += profit;
          }
        }

        element.open_position = 0;
        element.position_cost = 0;
        for (let index = 0; index < buyStack.length; index++) {
          const buyOrder = buyStack[index];
          element.open_position = (element.open_position || 0) + parseFloat(buyOrder.qty);
          element.position_cost = (element.position_cost || 0) + ((buyOrder.qty * buyOrder.price));// + (element.pnl || 0));
        }

        for (let index = 0; index < sellStack.length; index++) {
          const sellOrder = sellStack[index];
          element.open_position = (element.open_position || 0) - sellOrder.qty;
          element.position_cost = (element.position_cost || 0) - ((sellOrder.qty * sellOrder.price));// + (element.pnl || 0));
        }

        element.cost_price = element.open_position == 0 ? 0 : ((element.position_cost / element.open_position) || 0);
        element.pnl = pnl;
        element.open_position = element.open_position + buyFOPposition - sellFOPPosition;
        //element.open_position = ((prevElement && prevElement.open_position) ? prevElement.open_position : 0) + (element.is_buy == "1" ? +element.actualqty : -element.actualqty);
        //element.position_cost = (((prevElement && prevElement.position_cost) ? prevElement.position_cost : 0) + (element.actualqty * element.price * (element.is_buy == "1" ? 1 : -1))) + (element.pnl || 0);
        //Setting up cost price
        //element.cost_price = element.open_position == 0 ? 0 : ((element.position_cost / element.open_position) || 0);
      };

      return transactions;

    } catch (error) {
      console.log(error);
      this.logService.Error(serverIp, webServerInfo, productName, applicationName,
        'event.service.ts', 'calculatePosition', 0, 'NA', new Date(), 'Error in processing position calculation',
        'NA', 'NA', 'NA',
        'Error in processing security position calculation', productDetails, error);
    }
  }

  private async getOpenPositionForSecurityPortfolio(data: any, effective_date, isSettlement: boolean) {
    try {
      var openPosition = await this.positionTrackingService.getOpeningPositionPortfolioWise(effective_date, isSettlement ? 1 : 0,
        data.security_id, data.portfolio_id, data.trade_currency);
      var position = { price: 0, qty: 0, is_buy: '1', actualqty: 0, cost_price: 0 };
      if (openPosition && openPosition.length > 0) {
        position.price = openPosition[0].closing_price;
        position.cost_price = openPosition[0].closing_price;
        position.qty = openPosition[0].closing_position;
        position.actualqty = openPosition[0].closing_position;
        position.is_buy = openPosition[0].closing_position > 0 ? '1' : '0';
      }
      return position;
    } catch (error) {
      this.logService.Error(serverIp, webServerInfo, productName, applicationName,
        'event.service.ts', 'getOpenPositionForSecurityPortfolio', 0, 'NA', new Date(), 'error calculating open position for portfolio',
        'NA', 'NA', 'NA',
        'error calculating open position for portfolio', productDetails, error);
    }
    return null;

  }

  private async submitClosePositionForSecurityPortfolio(pendingPortfolio: any, lastMonthOpenPosition: any,
    positionDataWithPnL: any, start_date: string, end_date: string, isSettlement: boolean, existingPositionsSubmittedMap: Map<string, any>) {
    try {

      let dataDateWise = _.groupBy(positionDataWithPnL, (ele) => { return moment(ele['effective_date']).format('YYYY-MM-DD') });

      let startDate = moment(start_date);
      let endDate = moment(end_date);

      let finalSubmissionData: any[] = [];
      let finalSubmissionIndex = -1;

      if (lastMonthOpenPosition) {

        let finalData: any = {};
        let pnlData = dataDateWise[startDate.format('YYYY-MM-DD')];
        finalData.security_id = pendingPortfolio.security_id;
        finalData.portfolio_id = pendingPortfolio.portfolio_id;
        finalData.as_on_date = startDate.format('YYYY-MM-DD');
        finalData.currency = pendingPortfolio.trade_currency;
        finalData.is_active = 1;
        finalData.entry_by = 999999;

        finalData.transaction_type = isSettlement ? 1 : 0;
        finalData.pnl = pnlData && pnlData.length > 0 ? _.reduce((_.map(pnlData, (ele) => { return ele.trade_pnl })), (sum, ele) => { return (sum + ele) }) : 0;
        finalData.opening_position = lastMonthOpenPosition.actualqty;
        finalData.opening_price = lastMonthOpenPosition.price;
        finalData.closing_position = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['open_position'] : (lastMonthOpenPosition.actualqty || 0) //(isContainTransaction ? closePosition.open_position : (closePosition.actualqty || 0));
        finalData.closing_price = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['cost_price'] : (lastMonthOpenPosition.cost_price || 0) //data.closing_position ? closePosition.cost_price : 0;
        finalData.settlement_opening_position = lastMonthOpenPosition.actualqty;
        finalData.settlement_opening_price = lastMonthOpenPosition.price;
        finalData.settlement_closing_position = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['open_position'] : (lastMonthOpenPosition.actualqty || 0) //(isContainTransaction ? closePosition.open_position : (closePosition.actualqty || 0));
        finalData.settlement_closing_price = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['cost_price'] : (lastMonthOpenPosition.cost_price || 0) //data.closing_position ? closePosition.cost_price : 0;
        finalSubmissionData.push(finalData);
        finalSubmissionIndex++;
        startDate.add(1, 'days');

      }

      while (startDate.isSameOrBefore(endDate)) {

        let finalData: any = {};
        let pnlData = dataDateWise[startDate.format('YYYY-MM-DD')];
        let lastDayPosition = finalSubmissionIndex > -1 ? finalSubmissionData[finalSubmissionIndex] : null;
        finalData.security_id = pendingPortfolio.security_id;
        finalData.portfolio_id = pendingPortfolio.portfolio_id;
        finalData.as_on_date = startDate.format('YYYY-MM-DD');
        finalData.currency = pendingPortfolio.trade_currency;
        finalData.is_active = 1;
        finalData.entry_by = 999999;

        finalData.transaction_type = isSettlement ? 1 : 0;
        finalData.pnl = pnlData && pnlData.length > 0 ? _.reduce((_.map(pnlData, (ele) => { return ele.trade_pnl })), (sum, ele) => { return (sum + ele) }) : 0;
        finalData.opening_position = lastDayPosition ? lastDayPosition.closing_position : 0;
        finalData.opening_price = lastDayPosition ? lastDayPosition.closing_price : 0;
        finalData.closing_position = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['open_position'] : (lastDayPosition ? lastDayPosition.closing_position : 0) //(isContainTransaction ? closePosition.open_position : (closePosition.actualqty || 0));
        finalData.closing_price = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['cost_price'] : (lastDayPosition ? lastDayPosition.closing_price : 0) //data.closing_position ? closePosition.cost_price : 0;
        finalData.settlement_opening_position = lastDayPosition ? lastDayPosition.closing_position : 0;
        finalData.settlement_opening_price = lastDayPosition ? lastDayPosition.closing_price : 0;
        finalData.settlement_closing_position = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['open_position'] : (lastDayPosition ? lastDayPosition.closing_position : 0) //(isContainTransaction ? closePosition.open_position : (closePosition.actualqty || 0));
        finalData.settlement_closing_price = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['cost_price'] : (lastDayPosition ? lastDayPosition.closing_price : 0) //data.closing_position ? closePosition.cost_price : 0;

        finalSubmissionData.push(finalData);
        finalSubmissionIndex++;
        startDate.add(1, 'days');
      }

      for (let index = 0; index < finalSubmissionData.length; index++) {
        const positionToSubmit = finalSubmissionData[index];
        // const existingPosition = existingPositionsSubmittedMap.get(positionToSubmit.portfolio_id + '-' + positionToSubmit.security_id + '-' + positionToSubmit.as_on_date + '-' + positionToSubmit.currency);
        // if (!existingPosition || this.checkPositionObjectDifference(positionToSubmit, existingPosition)) {
        if (true) {
          await this.positionTrackingService.SubmitPortfolioPositionDailySummary(positionToSubmit);
        }
      }

    } catch (error) {
      this.logService.Error(serverIp, webServerInfo, productName, applicationName,
        'event.service.ts', 'submitClosePositionForSecurityPortfolio', 0, 'NA', new Date(), 'error calculating closing position for portfolio',
        'NA', 'NA', 'NA',
        'error calculating closing position for portfolio', productDetails, error);
    }

  }

  private async getOpenPositionForSecurityTraderbook(data: any, effective_date, isSettlement: boolean) {
    try {
      var openPosition = await this.positionTrackingService.getOpeningPositionTraderBookWise(effective_date, isSettlement ? 1 : 0,
        data.traderbook_id, data.security_id, data.trade_currency);
      var position = { price: 0, qty: 0, is_buy: '1', actualqty: 0, cost_price: 0 };
      if (openPosition && openPosition.length > 0) {
        position.price = openPosition[0].closing_price;
        position.cost_price = openPosition[0].closing_price;
        position.qty = openPosition[0].closing_position;
        position.actualqty = openPosition[0].closing_position;
        position.is_buy = openPosition[0].closing_position > 0 ? '1' : '0';
      }
      return position;
    } catch (error) {
      this.logService.Error(serverIp, webServerInfo, productName, applicationName,
        'event.service.ts', 'getOpenPositionForSecurityTraderbook', 0, 'NA', new Date(), 'error calculating closing position for traderbook',
        'NA', 'NA', 'NA',
        'error calculating closing position for portfolio', productDetails, error);
      return null;
    }
  }

  private async submitClosePositionForSecurityTraderBook(pendingPortfolio: any, lastMonthOpenPosition: any,
    positionDataWithPnL: any, start_date: string, end_date: string, isSettlement: boolean, existingPositionsSubmittedMap: Map<string, any>) {
    try {

      let dataDateWise = _.groupBy(positionDataWithPnL, (ele) => { return moment(ele['effective_date']).format('YYYY-MM-DD') });

      let startDate = moment(start_date);
      let endDate = moment(end_date);

      // console.log('startDate = ', startDate.format('YYYY-MM-DD'));
      // console.log('end Date = ', endDate.format('YYYY-MM-DD'));

      let finalSubmissionData: any[] = [];
      let finalSubmissionIndex = -1;

      if (lastMonthOpenPosition) {

        let finalData: any = {};
        let pnlData = dataDateWise[startDate.format('YYYY-MM-DD')];
        finalData.security_id = pendingPortfolio.security_id;
        finalData.traderbook_id = pendingPortfolio.traderbook_id;
        finalData.as_on_date = startDate.format('YYYY-MM-DD');
        finalData.currency = pendingPortfolio.trade_currency;
        finalData.is_active = 1;
        finalData.entry_by = 999999;

        finalData.transaction_type = isSettlement ? 1 : 0;
        finalData.pnl = pnlData && pnlData.length > 0 ? _.reduce((_.map(pnlData, (ele) => { return ele.trade_pnl })), (sum, ele) => { return (sum + ele) }) : 0;
        finalData.opening_position = lastMonthOpenPosition.actualqty;
        finalData.opening_price = lastMonthOpenPosition.price;
        finalData.closing_position = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['open_position'] : (lastMonthOpenPosition.actualqty || 0) //(isContainTransaction ? closePosition.open_position : (closePosition.actualqty || 0));
        finalData.closing_price = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['cost_price'] : (lastMonthOpenPosition.cost_price || 0) //data.closing_position ? closePosition.cost_price : 0;
        finalData.settlement_opening_position = lastMonthOpenPosition.actualqty;
        finalData.settlement_opening_price = lastMonthOpenPosition.price;
        finalData.settlement_closing_position = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['open_position'] : (lastMonthOpenPosition.actualqty || 0) //(isContainTransaction ? closePosition.open_position : (closePosition.actualqty || 0));
        finalData.settlement_closing_price = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['cost_price'] : (lastMonthOpenPosition.cost_price || 0) //data.closing_position ? closePosition.cost_price : 0;
        finalSubmissionData.push(finalData);
        finalSubmissionIndex++;
        startDate.add(1, 'days');

      }

      while (startDate.isSameOrBefore(endDate)) {

        let finalData: any = {};
        let pnlData = dataDateWise[startDate.format('YYYY-MM-DD')];
        let lastDayPosition = finalSubmissionIndex > -1 ? finalSubmissionData[finalSubmissionIndex] : null;
        finalData.security_id = pendingPortfolio.security_id;
        finalData.traderbook_id = pendingPortfolio.traderbook_id;
        finalData.as_on_date = startDate.format('YYYY-MM-DD');
        finalData.currency = pendingPortfolio.trade_currency;
        finalData.is_active = 1;
        finalData.entry_by = 999999;

        finalData.transaction_type = isSettlement ? 1 : 0;
        finalData.pnl = pnlData && pnlData.length > 0 ? _.reduce((_.map(pnlData, (ele) => { return ele.trade_pnl })), (sum, ele) => { return (sum + ele) }) : 0;
        finalData.opening_position = lastDayPosition ? lastDayPosition.closing_position : 0;
        finalData.opening_price = lastDayPosition ? lastDayPosition.closing_price : 0;
        finalData.closing_position = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['open_position'] : (lastDayPosition ? lastDayPosition.closing_position : 0) //(isContainTransaction ? closePosition.open_position : (closePosition.actualqty || 0));
        finalData.closing_price = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['cost_price'] : (lastDayPosition ? lastDayPosition.closing_price : 0) //data.closing_position ? closePosition.cost_price : 0;
        finalData.settlement_opening_position = lastDayPosition ? lastDayPosition.closing_position : 0;
        finalData.settlement_opening_price = lastDayPosition ? lastDayPosition.closing_price : 0;
        finalData.settlement_closing_position = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['open_position'] : (lastDayPosition ? lastDayPosition.closing_position : 0) //(isContainTransaction ? closePosition.open_position : (closePosition.actualqty || 0));
        finalData.settlement_closing_price = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['cost_price'] : (lastDayPosition ? lastDayPosition.closing_price : 0) //data.closing_position ? closePosition.cost_price : 0;

        finalSubmissionData.push(finalData);
        finalSubmissionIndex++;
        startDate.add(1, 'days');
      }

      for (let index = 0; index < finalSubmissionData.length; index++) {
        const positionToSubmit = finalSubmissionData[index];
        // const existingPosition = existingPositionsSubmittedMap.get(positionToSubmit.traderbook_id + '-' + positionToSubmit.security_id + '-' + positionToSubmit.as_on_date + '-' + positionToSubmit.currency);
        // if (!existingPosition || this.checkPositionObjectDifference(positionToSubmit, existingPosition)) {
        if (true) {
          await this.positionTrackingService.SubmitTraderbookPositionDailySummary(positionToSubmit);
        }
      }

    } catch (error) {
      this.logService.Error(serverIp, webServerInfo, productName, applicationName,
        'event.service.ts', 'submitClosePositionForSecurityPortfolio', 0, 'NA', new Date(), 'error calculating closing position for portfolio',
        'NA', 'NA', 'NA',
        'error calculating closing position for portfolio', productDetails, error);
    }

  }

  private async submitClosePositionForSecurityCustodian(pendingPortfolio: any, lastMonthOpenPosition: any,
    positionDataWithPnL: any, start_date: string, end_date: string, isSettlement: boolean) {
    try {

      let dataDateWise = _.groupBy(positionDataWithPnL, (ele) => { return moment(ele['effective_date']).format('YYYY-MM-DD') });

      let startDate = moment(start_date);
      let endDate = moment(end_date);

      let finalSubmissionData: any[] = [];
      let finalSubmissionIndex = -1;

      if (lastMonthOpenPosition) {

        let finalData: any = {};
        let pnlData = dataDateWise[startDate.format('YYYY-MM-DD')];
        finalData.security_id = pendingPortfolio.security_id;
        //finalData.traderbook_id = pendingPortfolio.portfolio_id;
        finalData.custodian_id = pendingPortfolio.custodian_id;
        finalData.custodian_security_account = pendingPortfolio.custodian_security_account;
        finalData.as_on_date = startDate.format('YYYY-MM-DD');
        finalData.currency = pendingPortfolio.trade_currency;
        finalData.is_active = 1;
        finalData.entry_by = 999999;

        finalData.transaction_type = isSettlement ? 1 : 0;
        finalData.pnl = pnlData && pnlData.length > 0 ? _.reduce((_.map(pnlData, (ele) => { return ele.trade_pnl })), (sum, ele) => { return (sum + ele) }) : 0;
        finalData.opening_position = lastMonthOpenPosition.actualqty;
        finalData.opening_price = lastMonthOpenPosition.price;
        finalData.closing_position = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['open_position'] : (lastMonthOpenPosition.actualqty || 0) //(isContainTransaction ? closePosition.open_position : (closePosition.actualqty || 0));
        finalData.closing_price = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['cost_price'] : (lastMonthOpenPosition.cost_price || 0) //data.closing_position ? closePosition.cost_price : 0;
        finalData.settlement_opening_position = lastMonthOpenPosition.actualqty;
        finalData.settlement_opening_price = lastMonthOpenPosition.price;
        finalData.settlement_closing_position = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['open_position'] : (lastMonthOpenPosition.actualqty || 0) //(isContainTransaction ? closePosition.open_position : (closePosition.actualqty || 0));
        finalData.settlement_closing_price = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['cost_price'] : (lastMonthOpenPosition.cost_price || 0) //data.closing_position ? closePosition.cost_price : 0;
        finalSubmissionData.push(finalData);
        finalSubmissionIndex++;
        startDate.add(1, 'days');

      }

      while (startDate.isSameOrBefore(endDate)) {

        let finalData: any = {};
        let pnlData = dataDateWise[startDate.format('YYYY-MM-DD')];
        let lastDayPosition = finalSubmissionIndex > -1 ? finalSubmissionData[finalSubmissionIndex] : null;
        finalData.security_id = pendingPortfolio.security_id;
        finalData.custodian_id = pendingPortfolio.custodian_id;
        finalData.custodian_security_account = pendingPortfolio.custodian_security_account;
        //finalData.traderbook_id = pendingPortfolio.portfolio_id;
        finalData.as_on_date = startDate.format('YYYY-MM-DD');
        finalData.currency = pendingPortfolio.trade_currency;
        finalData.is_active = 1;
        finalData.entry_by = 999999;

        finalData.transaction_type = isSettlement ? 1 : 0;
        finalData.pnl = pnlData && pnlData.length > 0 ? _.reduce((_.map(pnlData, (ele) => { return ele.trade_pnl })), (sum, ele) => { return (sum + ele) }) : 0;
        finalData.opening_position = lastDayPosition ? lastDayPosition.closing_position : 0;
        finalData.opening_price = lastDayPosition ? lastDayPosition.closing_price : 0;
        finalData.closing_position = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['open_position'] : (lastDayPosition ? lastDayPosition.closing_position : 0) //(isContainTransaction ? closePosition.open_position : (closePosition.actualqty || 0));
        finalData.closing_price = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['cost_price'] : (lastDayPosition ? lastDayPosition.closing_price : 0) //data.closing_position ? closePosition.cost_price : 0;
        finalData.settlement_opening_position = lastDayPosition ? lastDayPosition.closing_position : 0;
        finalData.settlement_opening_price = lastDayPosition ? lastDayPosition.closing_price : 0;
        finalData.settlement_closing_position = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['open_position'] : (lastDayPosition ? lastDayPosition.closing_position : 0) //(isContainTransaction ? closePosition.open_position : (closePosition.actualqty || 0));
        finalData.settlement_closing_price = pnlData && pnlData.length > 0 ? pnlData[pnlData.length - 1]['cost_price'] : (lastDayPosition ? lastDayPosition.closing_price : 0) //data.closing_position ? closePosition.cost_price : 0;

        finalSubmissionData.push(finalData);
        finalSubmissionIndex++;
        startDate.add(1, 'days');
      }


      for (let index = 0; index < finalSubmissionData.length; index++) {
        this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
          'position.service.ts', 'processSecurityPortfolio-3', 0, 'NA', new Date(), 'position details',
          'NA', 'NA', 'NA',
          'Close Position=' + JSON.stringify(finalSubmissionData[index]), productDetails);

        await this.positionTrackingService.SubmitCustodianPositionDailySummary(finalSubmissionData[index]);
      }


    } catch (error) {
      this.logService.Error(serverIp, webServerInfo, productName, applicationName,
        'event.service.ts', 'submitClosePositionForSecurityPortfolio', 0, 'NA', new Date(), 'error calculating closing position for portfolio',
        'NA', 'NA', 'NA',
        'error calculating closing position for portfolio', productDetails, error);
    }

  }

  private async getOpenPositionForSecurityCustodian(data: any, effective_date, isSettlement: boolean) {
    try {
      var openPosition = await this.positionTrackingService.getOpeningPositionCustodianWise(effective_date,
        isSettlement ? 1 : 0, data.custodian_id, data.security_id,
        data.custodian_security_account, data.trade_currency);
      var position = { price: 0, qty: 0, is_buy: '1', actualqty: 0, cost_price: 0 };
      if (openPosition && openPosition.length > 0) {
        position.price = openPosition[0].closing_price;
        position.cost_price = openPosition[0].closing_price;
        position.qty = openPosition[0].closing_position;
        position.actualqty = openPosition[0].closing_position;
        position.is_buy = openPosition[0].closing_position > 0 ? '1' : '0';
      }
      return position;
    } catch (error) {
      this.logService.Error(serverIp, webServerInfo, productName, applicationName,
        'event.service.ts', 'getOpenPositionForSecurityCustodian', 0, 'NA', new Date(), 'error calculating open position for custodian',
        'NA', 'NA', 'NA',
        'error calculating open position for custodian', productDetails, error);
    }
    return null;

  }

  // private checkPositionObjectDifference(position: any, last_position: any) {
  //   if (Number(position['pnl']) != Number(last_position['pnl'])) return true;

  //   if (position.transaction_type == 0) {
  //     const t0Keys = ['closing_position', 'opening_position', 'closing_price', 'opening_price'];
  //     return t0Keys.some(x => Boolean(Number(position[x] != Number(last_position[x]))));
  //   }
  //   else {
  //     const t1Keys = ['settlement_closing_position', 'settlement_opening_position', 'settlement_closing_price', 'settlement_opening_price'];
  //     return t1Keys.some(x => Boolean(Number(position[x] != Number(last_position[x]))));
  //   }
  // }
}