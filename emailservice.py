import asyncio
from datetime import datetime
import json
import boto3
import os
from uuid import uuid4

class EmailService:

    def __init__(self, aws_access_key_id, aws_secret_access_key, aws_region):
        self.client = boto3.client(
            'ses',
            aws_access_key_id = aws_access_key_id,
            aws_secret_access_key = aws_secret_access_key,
            region_name = aws_region
        )
import re

# Validate expected format of file names before processing
valid_file_pattern = re.compile(r'^\d{8}_[A-Za-z0-9._-]+(\.[A-Za-z]{1,5})?$')

fileNamesList = [
    x for x in fileNamesList 
    if valid_file_pattern.match(x) and datetime.strptime(x.split('_')[0], '%Y%m%d').strftime('%Y-%m-%d') == current_date_utc
]
    def checkForMissingFiles(self,db_connection,folderObjectType,eventName):

        current_date_utc = datetime.utcnow()
        formatted_date_utc = current_date_utc.strftime('%Y-%m-%d %H:%M:%S')

        dbResultForUnprocessedFiles = db_connection.execute_read_stored_procedure('proc_web_get_file_upload_mst',(0,folderObjectType, formatted_date_utc, formatted_date_utc,0,''))
        dbResultForprocessedFiles = db_connection.execute_read_stored_procedure('proc_web_get_file_upload_mst',(0,folderObjectType, formatted_date_utc, formatted_date_utc,1,''))
        dbResultForfinalReceivedFiles = dbResultForUnprocessedFiles + dbResultForprocessedFiles

        finalReceivedfileNameList = [row['file_name'] for row in dbResultForfinalReceivedFiles]

        fileNamesList = []

        if len(finalReceivedfileNameList) != 0 :
            if folderObjectType == 'Wedbush':
                fileNamesList = [x for x in fileNamesList if datetime.strptime(x.split('_')[0], '%Y%m%d').strftime('%Y-%m-%d') == current_date_utc]
            else:
                fileNamesList = [x for x in fileNamesList if datetime.strptime(x.split('_')[-1].split('.')[0], '%Y%m%d').strftime('%Y-%m-%d') == current_date_utc]
                
        dbResultForExpectedFiles = db_connection.execute_read_stored_procedure('proc_web_get_event_file_mapping_dtl',[eventName])

        missingFilesList = [expectedFileName for expectedFileName in dbResultForExpectedFiles if not any(fileName.lower().find(expectedFileName["file_name"].lower()) != -1 for fileName in fileNamesList)]
        
        todayFiles = [x for x in dbResultForExpectedFiles if x["process_type"] == 1]

        if eventName == 'Wedbush':
            today = [expectedFileName for expectedFileName in todayFiles if not any(
                fileName.lower() == expectedFileName["file_name"].lower() + '_' + fileName.split('_')[0] + expectedFileName["file_extension"]
                for fileName in fileNamesList
            )]
            missingFilesList.extend(today)

        else:
            today = [expectedFileName for expectedFileName in todayFiles if not any(
                fileName.lower() == expectedFileName["file_name"].lower() + '_' + fileName.split('.')[0].split('_')[-1] + expectedFileName["file_extension"]
                for fileName in fileNamesList
            )]
            missingFilesList.extend(today)

        finalReceivedList = [] 

        if missingFilesList:
            filesToCheckForToday = []
            elements = [x for x in missingFilesList if x["process_type"] == 1]
            curDate = datetime.utcnow()

            dateToCheck = curDate.strftime('%Y-%m-%d')

            if folderObjectType == 'Wedbush':
                filesToCheckForToday = [f"{curDate.strftime('%Y%m%d')}_{x['file_name']}.{x['file_extension']}" for x in elements]
            else:
                filesToCheckForToday = [f"{x['file_name']}_{curDate.strftime('%Y%m%d')}.{x['file_extension']}" for x in elements]

                def fetch_files(file):

                    unProcessedList = db_connection.execute_read_stored_procedure('proc_web_get_file_upload_mst', (0, folderObjectType, dateToCheck, dateToCheck, 0, file))
                    processedList = db_connection.execute_read_stored_procedure('proc_web_get_file_upload_mst', (0, folderObjectType, dateToCheck, dateToCheck, 1, file))
                    return unProcessedList + processedList

            tasks = [fetch_files(file) for file in filesToCheckForToday]
            # finalReceivedList = await asyncio.gather(*tasks)
            finalReceivedList = tasks
       
        if finalReceivedList and len(finalReceivedList) > 0:
            missingFilesList = [x for x in missingFilesList if not any(fileName['file_name'].lower() in x['file_name'].lower() for fileName in finalReceivedList)]

        uniqueMissingFilesList = [item for index, item in enumerate(missingFilesList) if item and item['file_name'] and missingFilesList.index(item) == index]

        missingFileNames = []

        for item in uniqueMissingFilesList:
            if item['process_type'] == 1:
                if folderObjectType == 'Wedbush':
                    missingFileNames.append(f"{datetime.utcnow().strftime('%Y%m%d')}_{item['file_name']}.{item['file_extension']}")
                else:
                    missingFileNames.append(f"{current_date_utc}_{item['file_name']}.{item['file_extension']}")
            else:
                if folderObjectType == 'Wedbush':
                    missingFileNames.append(f"{item['file_name']}_{datetime.utcnow().strftime('%Y%m%d')}.{item['file_extension']}")
                else:
                    missingFileNames.append(f"{item['file_name']}_{current_date_utc}.{item['file_extension']}")

       
        if missingFileNames and len(missingFileNames):
            print("sending email...")
            self.send_email(missingFileNames, eventName, formatted_date_utc)
            print("sent email successfully")


    def send_email(self,missingFileNames,eventName,formatted_date_utc):
        try:
            # Construct the email message
            email_subject = f'Missing Files For Event : {eventName} At {formatted_date_utc} (UTC)'
            email_body = f'<div>Dear Team,</div>' \
                         f'<p>Following files are not received:</p>' \
                         f'<p>{" , ".join(missingFileNames)}</p>' \
                         f'<div>Thanks</div>'

            # Send email using Amazon SES
            response = self.client.send_email(
                Source='jayraj.rathwa@fintechglobal.center',
                Destination={'ToAddresses': ['jayraj.rathwa@fintechglobal.center']},
                Message={
                    'Subject': {'Data': email_subject},
                    'Body': {'Html': {'Data': email_body}}
                }
            )

            print(f'Mail sent response: {response}')

        except Exception as e:
            print(f"Error in sending missing files mail: {e.response['Error']['Message']}")




           