import { Injectable } from '@nestjs/common';
import * as SFTP from 'ssh2-sftp-client';
import * as path from 'path';
import { applicationName, productDetails, productName, serverIp, webServerInfo } from '../config';
import { DinoLogService } from 'dinologservice/data';
import { S3Service } from 'dinos3service/data';
import { FileUploadDBService } from 'dinodbops/data';
import { FileUploadModel } from 'dinodbops/data/models';
import { DinoRedisService } from 'dinoredisservice/data';
import moment = require('moment');
import { TaskHandler, FLAGS } from './task-handler.service';

@Injectable()
export class SftpWedbushCustomerService {
  constructor(
    private readonly redisService: DinoRedisService,
    private readonly s3Service: S3Service,
    private readonly logService: DinoLogService,
    private readonly fileUploadDBService: FileUploadDBService,
    private readonly taskHandler: TaskHandler,
  ) {
    // var message = {"Guid":"add325db-12dc-53ca-3c3e-3e5c99ebecd9", "TimeStamp":1597065300017,"Title":"Wedbush FETCH","Data":{"Action":"WEDBUSHSFTPPROCESS","ActionData":[{"Source":"/users/DINO","S3Destination":"from_dmbl/Wedbush","MoveAfterProcessPath":"","Days":"1","FromDate":"","ToDate":"","Type":"Wedbush","Origin":"Wedbush","Channel":"FILEPROCESSNOTIFICATIONTEST","SuccessMessage":{"Action":"WEDBUSHPROCESSFILE","ActionData":{"status":true,"data":{}}},"FailMessage":{"Action":"FailAction","ActionData":{"status":false,"data":{}}}}],"EntryBy":"999999","TaskId":18,"IsManual":0,"GroupId":18,"ExecutionOrder":0}};
    // debugger;
    //  this.startWedbushCustomerProcess(message);
  }
public async startWedbushCustomerProcess(message: any) {
    if (!message || !message.Data || !Array.isArray(message.Data.ActionData)) {
        throw new Error('Invalid message format. Expected properties are missing or incorrectly formatted.');
    }

    const folderObjects = message.Data.ActionData;
    // ...
const host = process.env.SFTP_HOST_WEDBUSH_CUSTOMER;
const port = parseInt(process.env.SFTP_PORT_WEDBUSH_CUSTOMER, 10);
const username = process.env.SFTP_USERNAME_WEDBUSH_CUSTOMER;
const password = process.env.SFTP_PASSWORD_WEDBUSH_CUSTOMER;

if (!/^[a-zA-Z0-9.-]+$/.test(host) || port < 1 || port > 65535 || username.length > 30) {
    throw new Error('Invalid SFTP credentials. Ensure that the host, port, and username are correctly formatted.');
}

await sftpClient.connect({
    host,
    port,
    username,
    password,
});}
  public async sleep(ms: number) {
    return new Promise((resolve) => {
      setTimeout(resolve, ms);
    });
  }

  public async startWedbushCustomerProcess(message: any) {
    try {
      const folderObjects = message.Data.ActionData;
      //const sftpClient = new SFTP();
      this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
        'SftpWedbushCustomerService', 'startWedbushCustomerProcess', 0, 'NA', new Date(), 'Enter',
        'NA', 'NA', 'NA',
        `Enter`,
        productDetails);

      await this.taskHandler.SubmitTaskStep(message.Data.TaskId, message.Data.GroupId, message.Guid, FLAGS.BOTH, message.Data.IsManual,
        'CONNECTING_SFTP', 'CONNECTING_SFTP', false, message.Data.EntryBy);
public async startWedbushCustomerProcess(message: any) {
    try {
        const folderObjects = message.Data.ActionData;

        await this.logServiceEntry(message);

        const sftpClient = await this.connectToSftp();

        if (!sftpClient) {
            await this.handleConnectionError(message);
            return;
        }

        for (const folderObject of folderObjects) {
            await this.processFilesInFolder(sftpClient, folderObject, message);
        }
        sftpClient.end();
    } catch (err) {
        await this.handleGeneralError(err, message);
    }
}

private async logServiceEntry(message: any) {
    // Logging logic
}

private async connectToSftp(): Promise<SFTP | null> {
    // SFTP connection logic
}

private async handleConnectionError(message: any) {
    // Handle connection error
}

private async processFilesInFolder(sftpClient: SFTP, folderObject: any, message: any) {
    // File processing logic per folder
}

private async handleGeneralError(err: any, message: any) {
    // Handle general error
}
      var iRetryCont = 0;
      while (iRetryCont < 3) {
        try {
          var sftpClient = new SFTP();
          await sftpClient.connect({
            host: String(process.env.SFTP_HOST_WEDBUSH_CUSTOMER),
            port: Number(process.env.SFTP_PORT_WEDBUSH_CUSTOMER),
            username: String(process.env.SFTP_USERNAME_WEDBUSH_CUSTOMER),
            password: String(process.env.SFTP_PASSWORD_WEDBUSH_CUSTOMER),
            tryKeyboard: true,
            algorithms: {
              cipher: [
                "aes256-cbc"
              ]
            }
          });
          break;// as connection is done.
        }
        catch (error) {
          await this.sleep(5000);
          iRetryCont++;
          sftpClient = null;
          var error_test = error;
          this.logService.Error(serverIp, webServerInfo, productName, applicationName,
            'SftpWedbushCustomerService', 'processingSingleFile', 0, 'NA', new Date(), 'Error in processingSingleFile',
            'NA', 'NA', 'NA',
            `Error in Connecting to SFTP retry count: ${iRetryCont} `,
            productDetails, error);
        }
      }

      if (!sftpClient) {
        this.logService.Error(serverIp, webServerInfo, productName, applicationName,
          'SftpWedbushCustomerService', 'processingSingleFile', 0, 'NA', new Date(), 'Error in SFTP connection',
          'NA', 'NA', 'NA',
          `Error in processingSingleFile`,
          productDetails, error_test);

        await this.taskHandler.SubmitTaskStep(message.Data.TaskId, message.Data.GroupId, message.Guid, FLAGS.BOTH, message.Data.IsManual,
          'CONNECTED_SFTP', 'Failed to connect SFTP notification ' + error_test, true, message.Data.EntryBy);

        await this.taskHandler.SubmitTaskStep(message.Data.TaskId, message.Data.GroupId, message.Guid, FLAGS.BOTH, message.Data.IsManual,
          'FILE_SUBMITED_S3', 'Failed to insert to s3 and sending notification ' + error_test, true, message.Data.EntryBy);

        await this.taskHandler.SubmitTaskStep(message.Data.TaskId, message.Data.GroupId, message.Guid, FLAGS.BOTH, message.Data.IsManual,
          'SEND_NOTIFICATION', 'Faild in send notfication to file process ', true, message.Data.EntryBy);
        return;
      }

      this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
        'SftpWedbushCustomerService', 'startWedbushCustomerProcess', 0, 'NA', new Date(), 'Connected',
        'NA', 'NA', 'NA',
        `Connected`,
        productDetails);

      await this.taskHandler.SubmitTaskStep(message.Data.TaskId, message.Data.GroupId, message.Guid, FLAGS.BOTH, message.Data.IsManual,
        'CONNECTED_SFTP', 'CONNECTED_SFTP', false, message.Data.EntryBy);

      for (let folderIndex = 0; folderIndex < folderObjects.length; folderIndex++) {
        var fileUpdatedInDB = 0;
        var uploadedFileData: any = [];
        const folderObject = folderObjects[folderIndex];
        const files = await sftpClient.list(folderObject.Source);

        var fromDate, toDate;
        if (folderObject.FromDate && folderObject.ToDate) {
          fromDate = moment.utc(folderObject.FromDate).valueOf();
          toDate = moment.utc(folderObject.ToDate).valueOf();
        } else {
          toDate = moment().utc().valueOf();
          fromDate = moment().utc().subtract(folderObject.Days || 1, "days").valueOf();
        }

        this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
          'SftpWedbushCustomerService', 'startWedbushCustomerProcess', 0, 'NA', new Date(), 'NoOfFiles-' + files.length + '. FromDate-' + fromDate + '. ToDate-' + toDate,
          'NA', 'NA', 'NA',
          `NoOfFiles`,
          productDetails);

        var fileList = files.filter(c => c.modifyTime > fromDate && c.modifyTime < toDate);

        for (let index = 0; index < fileList.length; index++) {
          try {
            const file = fileList[index];
            if ((file.modifyTime > fromDate && file.modifyTime < toDate) &&
              (file.name.includes("_POS_DinoCus.csv"))
            ) {
              const filePath = path.join(folderObject.Source, file.name).replace(/\\/g, '/');
              const fileExtension = path.extname(filePath);
              this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
                'SftpWedbushCustomerService', 'startWedbushCustomerProcess', 0, 'NA', new Date(), 'ProcessingFile-' + filePath,
                'NA', 'NA', 'NA',
                `ProcessingFile`,
                productDetails);
              var fileData: any = undefined;
              fileData = await sftpClient.get(filePath, fileData);
              if (fileExtension) {
                const s3filePath = path.join(folderObject.S3Destination, file.name).replace(/\\/g, '/');
                var s3Destination = s3filePath.replace(/^\\/, '').replace(/^\//, '');
                var isFileUploaded = await this.saveFileToS3(s3Destination, fileData);
                this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
                  'SftpWedbushCustomerService', 'startWedbushCustomerProcess', 0, 'NA', new Date(), 'UploadingFile-' + filePath + ' Done-' + isFileUploaded,
                  'NA', 'NA', 'NA',
                  `UploadingFile`,
                  productDetails);
                if (isFileUploaded) {
                  //Update database we have copied file in S3
                  const isFileUpdatedInDB = await this.updateFileInDatabase(file.name, s3Destination, folderObject.Type, folderObject.Origin, message.Data.EntryBy);
                  this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
                    'SftpWedbushCustomerService', 'startWedbushCustomerProcess', 0, 'NA', new Date(), 'UpdatingFileInDB-' + filePath + ' Done-' + isFileUpdatedInDB,
                    'NA', 'NA', 'NA',
                    `UpdatingFileInDB`,
                    productDetails);
                }
              }
            }
          } catch (err) {
            this.logService.Error(serverIp, webServerInfo, productName, applicationName,
              'SftpWedbushCustomerService', 'processingSingleFile', 0, 'NA', new Date(), 'Error in processingSingleFile',
              'NA', 'NA', 'NA',
              `Error in processingSingleFile`,
              productDetails, err);
          }
        }

        // Process unprocessed files
        this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
          'SftpRBCService', 'startRBCProcess', 0, 'NA', new Date(), 'Fetching unprocessed files',
          'NA', 'NA', 'NA',
          `NoOfFiles`,
          productDetails);
          
        const unProcessedFileList = await this.fileUploadDBService.getUploadedFileList(0, folderObject.Type, moment(fromDate).subtract('days', 7).format("YYYY-MM-DD"), moment(toDate).add('days', 1).format("YYYY-MM-DD"), 0, '');
        fileUpdatedInDB += unProcessedFileList.length;
        uploadedFileData.push(...unProcessedFileList.map(x => ({
          "S3FilePath": x.s3_path,
          "FileExtension": path.extname(x.s3_path)
        })));

        this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
          'SftpRBCService', 'startRBCProcess', 0, 'NA', new Date(), `Found ${unProcessedFileList.length} unprocessed files`,
          'NA', 'NA', 'NA',
          `NoOfFiles`,
          productDetails);

        await this.taskHandler.SubmitTaskStep(message.Data.TaskId, message.Data.GroupId, message.Guid, FLAGS.BOTH, message.Data.IsManual,
          'FILE_SUBMITED_S3', 'File inserted to s3 and sending notification ' + JSON.stringify(uploadedFileData), false, message.Data.EntryBy);
        await this.sendNotificationFilesAddedInS3(fileUpdatedInDB, message, folderObject, uploadedFileData);
      }
      sftpClient.end();
    } catch (err) {

      await this.taskHandler.SubmitTaskStep(message.Data.TaskId, message.Data.GroupId, message.Guid, FLAGS.BOTH, message.Data.IsManual,
        'FILE_SUBMITED_S3', 'Failed to insert to s3 and sending notification ' + err, true, message.Data.EntryBy);

      await this.taskHandler.SubmitTaskStep(message.Data.TaskId, message.Data.GroupId, message.Guid, FLAGS.BOTH, message.Data.IsManual,
        'SEND_NOTIFICATION', 'Faild in send notfication to file process ', true, message.Data.EntryBy);

      this.logService.Error(serverIp, webServerInfo, productName, applicationName,
        'SftpWedbushCustomerService', 'startWedbushCustomerProcess', 0, 'NA', new Date(), 'Error in startWedbushCustomerProcess',
        'NA', 'NA', 'NA',
        `Error in startWedbushCustomerProcess`,
        productDetails, err);
    }
  }

  private async saveFileToS3(filePath: string, fileData: any): Promise<any> {
    return await this.s3Service.uploadFiles(filePath, fileData)
      .then(data => {
        this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
          'SftpWedbushCustomerService', 'saveFileToS3', 0, 'NA', new Date(), 'File uploaded successfully on S3 at ' + filePath,
          'NA', 'NA', 'NA',
          'File uploaded successfully on S3 at ' + filePath,
          productDetails);
        return data;
      })
      .catch((err) => {
        this.logService.Error(serverIp, webServerInfo, productName, applicationName,
          'SftpWedbushCustomerService', 'saveFileToS3', 0, 'NA', new Date(), 'File uploading failed on S3 at ' + filePath,
          'NA', 'NA', 'NA',
          'File uploading failed on S3 at ' + filePath,
          productDetails, err);
        return err;
      });
  }

  private async updateFileInDatabase(fileName: string, s3Path: string, fileType: string, fileOrigin: string, entryBy: number): Promise<any> {
    var fileDetails = new FileUploadModel();
    fileDetails.fum_id = 0;
    fileDetails.file_name = fileName;
    fileDetails.s3_file_name = fileName;
    fileDetails.s3_path = s3Path;
    fileDetails.file_type = fileType;
    fileDetails.file_origin = fileOrigin;
    fileDetails.is_processed = 0;
    fileDetails.is_active = 1;
    fileDetails.entry_by = entryBy;
    fileDetails.trade_status = '';
    fileDetails.side = '';
    return await this.fileUploadDBService.submitUploadedFileDetails(fileDetails);
  }



  private async sendNotificationFilesAddedInS3(fileUpdatedInDB: any, eventMessage: any, folderObject: any, uploadedFileData: any): Promise<any> {
    try {
      //Send notification that we are done
      var responseMessage = {};
      if (folderObject.Channel && folderObject.SuccessMessage && folderObject.SuccessMessage.Action && fileUpdatedInDB > 0) {
        folderObject.SuccessMessage.ActionData.UploadedFiles = uploadedFileData;
        responseMessage = {
          GUID: eventMessage.GUID,
          Data: { Action: folderObject.SuccessMessage.Action, ActionData: folderObject.SuccessMessage.ActionData, EntryBy: eventMessage.Data.EntryBy }
        }

        this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
          'SftpWedbushCustomerService', 'sendNotificationFilesAddedInS3', 0, 'NA', new Date(), 'Channel-' + folderObject.Channel +
          ' Data-' + JSON.stringify(responseMessage) + ' fileUpdatedInDB-' + fileUpdatedInDB,
          'NA', 'NA', 'NA',
          `Notification-Success`,
          productDetails);
        this.redisService.publish(folderObject.Channel, JSON.stringify(responseMessage));

        await this.taskHandler.SubmitTaskStep(eventMessage.Data.TaskId, eventMessage.Data.GroupId, eventMessage.Guid, FLAGS.BOTH, eventMessage.Data.IsManual,
          'SEND_NOTIFICATION', 'Notification sent for process file ' + JSON.stringify(responseMessage), false, eventMessage.Data.EntryBy);
      }
      if (folderObject.Channel && folderObject.FailMessage && folderObject.FailMessage.Action && fileUpdatedInDB < 1) {
        responseMessage = {
          GUID: eventMessage.GUID,
          Data: { Action: folderObject.FailMessage.Action, ActionData: folderObject.FailMessage.ActionData, EntryBy: eventMessage.Data.EntryBy }
        }

        this.logService.Debug(serverIp, webServerInfo, productName, applicationName,
          'SftpWedbushCustomerService', 'sendNotificationFilesAddedInS3', 0, 'NA', new Date(), 'Channel-' + folderObject.Channel +
          ' Data-' + JSON.stringify(responseMessage) + ' fileUpdatedInDB-' + fileUpdatedInDB,
          'NA', 'NA', 'NA',
          `Notification-Fail`,
          productDetails);
        // this.redisService.publish(folderObject.Channel, JSON.stringify(responseMessage));
        await this.taskHandler.SubmitTaskStep(eventMessage.Data.TaskId, eventMessage.Data.GroupId, eventMessage.Guid, FLAGS.BOTH, eventMessage.Data.IsManual,
          'SEND_NOTIFICATION', 'Notification not send as no file to process ' + JSON.stringify(responseMessage), false, eventMessage.Data.EntryBy);
      }

    } catch (err) {
      await this.taskHandler.SubmitTaskStep(eventMessage.Data.TaskId, eventMessage.Data.GroupId, eventMessage.Guid, FLAGS.BOTH, eventMessage.Data.IsManual,
        'SEND_NOTIFICATION', 'Faild in send notfication to file process ' + err, true, eventMessage.Data.EntryBy);

      this.logService.Error(serverIp, webServerInfo, productName, applicationName,
        'SftpWedbushCustomerService', 'sendNotificationFilesAddedInS3', 0, 'NA', new Date(), 'Error in sendNotificationFilesAddedInS3',
        'NA', 'NA', 'NA',
        `Error in moveFileInProcessFolder`,
        productDetails, err);
    }
  }
}