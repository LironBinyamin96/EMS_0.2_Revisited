import os
import numpy as np
import cv2 as cv2
import face_recognition
import pyodbc
from datetime import datetime

def ParseConfig():
    with open('Config.txt') as file:
        lines = file.readlines()
        lines = [line.rstrip() for line in lines]
    config = dict({})
    while lines.__contains__(''):
        lines.remove('')
    for entry in lines:      
        entry=entry.split('#')
        config[entry[0]]=entry[1]
    return config

config = ParseConfig()
print(config)

conn = pyodbc.connect(
    "Driver={SQL Server Native Client 11.0};"+
    config["PythonDBConnection"].split('|')[1]+
    "Database=EmployeeManagmentDataBase;"+
    "Trusted_Connection=yes;")


def read(connection,employeeId):
    cursor = connection.cursor()
    cursor.execute(f'select top (1) _entry,_exit from HourLogs where _intId = {employeeId} order by _entry DESC;')
    x=cursor.fetchone()
    if x == None: return False
    if x[1] == None: return True
    return False

def getEntryTime(connection,employeeId):
    cursor = connection.cursor()
    cursor.execute(f'select top (1) _entry from HourLogs where _intId = {employeeId} order by _entry DESC;')
    x = cursor.fetchone()
    for row in x:
        return row
    return 0

def entry (connection,entryTime):
    data = entryTime.split("|")
    cursor = connection.cursor()
    sql = 'insert INTO HourLogs(_intId,_entry) VALUES(?,?);'
    val = (data[0], data[1])
    cursor.execute(sql, val)
    connection.commit()
    print("Entry for employee "+data[0] + "\nEntry time: " + data[1])


def exitTime (connection,exitTime,entryTime):
    data = exitTime.split("|")
    cursor = connection.cursor()
    sql = 'update HourLogs set _exit = ? where _intId = ? and _entry = ?;'
    val = (data[1], data[0], entryTime)
    cursor.execute(sql, val)
    connection.commit()
    print("Exit for employee "+data[0] + "\nexit time: " + data[1])



listDict = {}


def TimeToEmployee(listDict,formatData):
     data = formatData.split(" ")
     employeeID, employeeDate, employeeHour = data[0], data[1], data[2]

     if (employeeID not in listDict):
         listDict[employeeID] = employeeDate+" "+employeeHour
         timestampCheck(employeeID)
     else:
         hold = listDict[employeeID]
         dateTimeToString = datetime.now().strftime('%Y-%m-%d %H:%M:%S')
         sum = datetime.strptime(hold, '%Y-%m-%d %H:%M:%S') - datetime.strptime(dateTimeToString, '%Y-%m-%d %H:%M:%S')
         print(int(abs(sum.total_seconds())))
         if int(abs(sum.total_seconds())) > 10:
             timestampCheck(employeeID)

def timestampCheck(employeeID):
    if read(conn, employeeID):
        listDict[employeeID] = datetime.now().strftime('%Y-%m-%d %H:%M:%S')
        formatToReturn = employeeID + "|" + listDict[employeeID]
        exitTime(conn, formatToReturn, getEntryTime(conn, employeeID))
    else:
        listDict[employeeID] = datetime.now().strftime('%Y-%m-%d %H:%M:%S')
        formatToReturn = employeeID + "|" + listDict[employeeID]
        entry(conn, formatToReturn)
        listDict[employeeID] = datetime.now().strftime('%Y-%m-%d %H:%M:%S')



path = config['RootDirectory']+'\\Images'
images = []
EmployeeIdentity = []
myList = os.listdir(path)

for empIdentity in myList:
    EmployeeIdentity.append(os.path.splitext(empIdentity)[0])
    curImg= cv2.imread(f'{path}/{empIdentity}')
    images.append(curImg)

def findEncodings (images):
    encodingList= []
    for ImageForIdentification in images:
        ImageForIdentification = cv2.cvtColor(ImageForIdentification, cv2.COLOR_BGR2RGB)
        encodeImageForIdentification = face_recognition.face_encodings(ImageForIdentification)[0]
        encodingList.append(encodeImageForIdentification)
    return encodingList

def EntryOrExitTime(Employee):
    dateTimeToString = datetime.now().strftime('%Y-%m-%d %H:%M:%S')
    formatData = Employee + " " + dateTimeToString
    TimeToEmployee(listDict,formatData)

encodingListfinal = findEncodings(images)
print("Encoding Complete! number images: " + str(len(encodingListfinal)))
print("---------------------------------------------")


cap = cv2.VideoCapture(0)

while True:
    success, img = cap.read()
    imgS = cv2.resize(img,(0,0),None,0.25,0.25)
    imgS = cv2.cvtColor(imgS, cv2.COLOR_BGR2RGB)
    facesLocation = face_recognition.face_locations(imgS)
    encodingForCap = face_recognition.face_encodings(imgS,facesLocation)

    for encodeFace, faceLocation in zip(encodingForCap,facesLocation):
        match = face_recognition.compare_faces(encodingListfinal,encodeFace)
        faceDistance = face_recognition.face_distance(encodingListfinal,encodeFace)
        theBastMatchIndex = np.argmin(faceDistance)

        if match[theBastMatchIndex] and faceDistance[theBastMatchIndex] < 0.5:
            Employee = EmployeeIdentity[theBastMatchIndex].upper()
            EntryOrExitTime(Employee)
            y1,x2,y2,x1= faceLocation
            y1,x2,y2,x1= y1*4,x2*4,y2*4,x1*4
            cv2.rectangle(img,(x1,y1),(x2,y2),(0,255,0),3)
            cv2.rectangle(img,(x1,y2-35),(x2,y2),(0,255,0),cv2.FILLED)
            cv2.putText(img,Employee,(x1+6,y2-6),cv2.FONT_HERSHEY_COMPLEX,1,(0,0,0),2)
