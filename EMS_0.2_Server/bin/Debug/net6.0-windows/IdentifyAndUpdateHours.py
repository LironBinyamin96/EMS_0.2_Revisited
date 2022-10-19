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
#------------------- SQL -------------------
#connection to SQL server
conn = pyodbc.connect(
    "Driver={SQL Server Native Client 11.0};"+
    config["PythonDBConnection"].split('|')[1]+
    "Database=EmployeeManagmentDataBase;"+
    "Trusted_Connection=yes;")

def getFullNameOfEmployee(connection,employeeId):
    cursor = connection.cursor()
    cursor.execute(f'select _fName,_lName from Employees where _intId = {employeeId} ;')
    fullNameOfEmployee= cursor.fetchone()
    fullNameString = fullNameOfEmployee[0] + " " + fullNameOfEmployee[1] 
    return fullNameString

def GetFormatForReturningTimeOfDay(currentTime):
    # format currentTime is '%Y-%m-%d %H:%M:%S'
    dataTime = currentTime.split(" ")
    finalDataTime = dataTime[1].split(":")
    if(1<(int(finalDataTime[0]))<10):
        return "Good Morning"
    elif (10<(int(finalDataTime[0]))<14):
        return "Good Day"
    elif (14<(int(finalDataTime[0]))<18):
        return "Good Afternoon"
    else:
        return "Good Evening"

# Checking the last login status of the employee
def read(connection,employeeId):
    cursor = connection.cursor()
    cursor.execute(f'select top (1) _entry,_exit from HourLogs where _intId = {employeeId} order by _entry DESC;')
    x=cursor.fetchone()
    if x == None: return False # If the employee does not exist yet
    if x[1] == None: return True # If the worker printed an entry but did not print an exit
    return False # If the employee has entry and exit

# Getting the login time - auxiliary function for printing a logout
def getEntryTime(connection,employeeId):
    cursor = connection.cursor()
    cursor.execute(f'select top (1) _entry from HourLogs where _intId = {employeeId} order by _entry DESC;')
    x = cursor.fetchone()
    for row in x:
        return row
    return 0

# insert entry time to SQL server
def entry (connection,entryTime):
    data = entryTime.split("|")
    cursor = connection.cursor()
    #if EmployeeStatus(connection,data[0]) != 0:  ----------
    sql = 'insert INTO HourLogs(_intId,_entry) VALUES(?,?); update Employees set _employmentStatus = 1 where _IntId = ?;'
    val = (data[0], data[1],data[0])
    cursor.execute(sql, val)
    connection.commit()
    print(GetFormatForReturningTimeOfDay(data[1]) +" "+ data[2]+ "!\nyour entry time is : " + data[1])

# insert exit time to SQL server
def exitTime (connection,exitTime,entryTime):
    data = exitTime.split("|")
    cursor = connection.cursor()
    #if EmployeeStatus(connection,data[0]) != 0: --------
    sql = 'update HourLogs set _exit = ? where _intId = ? and _entry = ?;update Employees set _employmentStatus = 2 where _IntId = ?;'
    val = (data[1], data[0], entryTime,data[0])
    cursor.execute(sql, val)
    connection.commit()
    print(GetFormatForReturningTimeOfDay(data[1]) +" "+ data[2]+ "!\nyour exit time is : " + data[1])

def EmployeeStatus (connection,employeeId):
    cursor = connection.cursor()
    cursor.execute(f'select _employmentStatus from Employees where _intId = {employeeId} ;')
    x= cursor.fetchone()
    for row in x:
        return(row)



# Employees dictionry - for checking time differences between entry time and exit time 
listDict = {}

# Getting employee hours and updating entry/exit status
def TimeToEmployee(listDict,formatData):
     data = formatData.split(" ")
     employeeID, employeeDate, employeeHour = data[0], data[1], data[2]

     if (employeeID not in listDict):
         listDict[employeeID] = employeeDate+" "+employeeHour
         timestampCheck(employeeID)
     else:
         hold = listDict[employeeID] # In case of a new employee or resetting the program
         dateTimeToString = datetime.now().strftime('%Y-%m-%d %H:%M:%S')
         sum = datetime.strptime(hold, '%Y-%m-%d %H:%M:%S') - datetime.strptime(dateTimeToString, '%Y-%m-%d %H:%M:%S')
         if int(abs(sum.total_seconds())) > 10:
             timestampCheck(employeeID)

def timestampCheck(employeeID):
    if read(conn, employeeID): # If exit time is empty
        listDict[employeeID] = datetime.now().strftime('%Y-%m-%d %H:%M:%S') # Update the current time
        formatToReturn = employeeID + "|" + listDict[employeeID] + "|" + getFullNameOfEmployee(conn, employeeID)
        exitTime(conn, formatToReturn, getEntryTime(conn, employeeID))
    else: # If a new employee or an employee prints an entry
        listDict[employeeID] = datetime.now().strftime('%Y-%m-%d %H:%M:%S')
        formatToReturn = employeeID + "|" + listDict[employeeID] + "|" + getFullNameOfEmployee(conn, employeeID)
        entry(conn, formatToReturn)
        listDict[employeeID] = datetime.now().strftime('%Y-%m-%d %H:%M:%S')


#------------------ Getting images and encoding -------------------
path = config['RootDirectory']+'\\Images'
# list that contains all the images
images = []
# list that contains all the names of the images without an image suffix
EmployeeIdentity = []
# list that contains all the names of the images
myList = os.listdir(path)

# adding image to list
for empIdentity in myList:
    EmployeeIdentity.append(os.path.splitext(empIdentity)[0])
    curImg= cv2.imread(f'{path}/{empIdentity}')
    images.append(curImg)

# function to encode all images
def findEncodings (images):
    encodingList= []
    for ImageForIdentification in images:
        ImageForIdentification = cv2.cvtColor(ImageForIdentification, cv2.COLOR_BGR2RGB)
        try:
            encodeImageForIdentification = face_recognition.face_encodings(ImageForIdentification)[0]
            encodingList.append(encodeImageForIdentification)
        finally: continue
    return encodingList

# configure and printing entry or exit time
def EntryOrExitTime(Employee):
    dateTimeToString = datetime.now().strftime('%Y-%m-%d %H:%M:%S')
    formatData = Employee + " " + dateTimeToString
    TimeToEmployee(listDict,formatData)

encodingListfinal = findEncodings(images)
print("Encoding Complete! number images: " + str(len(encodingListfinal)))
print("---------------------------------------------")

#------------------ Camera activation and comparison between images and faces -------------------

#Camera setting
cap = cv2.VideoCapture(0)

# imgS = reducing the image size in order to speed up the process
while True:
    success, img = cap.read()
    imgS = cv2.resize(img,(0,0),None,0.25,0.25) # quarter of the size of the image
    imgS = cv2.cvtColor(imgS, cv2.COLOR_BGR2RGB) # Change the color
    facesLocation = face_recognition.face_locations(imgS) # Finding all the faces in the picture
    encodingForCap = face_recognition.face_encodings(imgS,facesLocation) # encoding

    # Running over a list of images and comparing to the current image using the encoding and location
    for encodeFace, faceLocation in zip(encodingForCap,facesLocation):
        # Comparing faces between a list of encodings and the encoding of the camera image
        match = face_recognition.compare_faces(encodingListfinal,encodeFace)
        # test for the best match in case there are employees with a similar appearance
        faceDistance = face_recognition.face_distance(encodingListfinal,encodeFace)
        # Finding the minimum value of an image by index
        theBastMatchIndex = np.argmin(faceDistance)

        if match[theBastMatchIndex] and faceDistance[theBastMatchIndex] < 0.5:
            Employee = EmployeeIdentity[theBastMatchIndex].upper()
            EntryOrExitTime(Employee)
            y1,x2,y2,x1= faceLocation
            y1,x2,y2,x1= y1*4,x2*4,y2*4,x1*4
            cv2.rectangle(img,(x1,y1),(x2,y2),(0,255,0),1)
            cv2.rectangle(img,(x1,y2-35),(x2,y2),(0,255,0),cv2.FILLED)
            cv2.putText(img,getFullNameOfEmployee(conn,Employee),(x1+6,y2-6),cv2.FONT_HERSHEY_COMPLEX,2,(0,0,0),2)
    cv2.imshow("Camera", img)
    cv2.waitKey(1)