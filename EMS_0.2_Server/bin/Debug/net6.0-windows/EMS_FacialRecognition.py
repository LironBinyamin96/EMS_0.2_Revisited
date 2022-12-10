import os
import numpy as np
import cv2 as cv2
import face_recognition
import pyodbc
from datetime import datetime

employeeCooldownDict = {} #Used for tracking employees. Preventing entry spaming.
def OnCooldown(employeeId):
    global employeeCooldownDict
    employeeCooldownDict={key:value for (key,value) in employeeCooldownDict.items() if (datetime.now()-value).seconds<10}
    if(employeeId in employeeCooldownDict.keys()):
        print((datetime.now()-employeeCooldownDict[employeeId]).seconds)
        return True
    else:
        employeeCooldownDict[employeeId] = datetime.now()
        return False


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
config = ParseConfig() #Used for retrieving configurations. Created by EMS_Server.


SQLConnection = pyodbc.connect(
    "Driver={SQL Server Native Client 11.0};"+
    config["PythonDBConnection"].split('|')[1]+
    "Database=EmployeeManagmentDataBase;"+
    "Trusted_Connection=yes;")


def GetFullName(employeeID):
    cursor = SQLConnection.cursor()
    responce = cursor.execute(f'select _fName,_lName from {config["EmployeeDataTable"]} where _intId = {employeeID} ;')
    data = responce.fetchone()
    try: return f'{data[0]} {data[1]}'
    except : return ""

def GetTimedGreeting(time):
    hours = int(datetime.today().strftime('%H')) #Get hours from the time object
    if(hours>22 or hours<4): return "Greetings. Are you in need of coffie?"
    elif(hours>18): return "Good Evening"
    elif(hours>13): return "Good Afternoon"
    else: return "Good Morning"

def StampEmployee(employeeID):
    if(OnCooldown(employeeID)): return 'Too soon.'
    #Check if employee exists
    cursor = SQLConnection.cursor()
    cursor.execute(f'select _fName from {config["EmployeeDataTable"]} where _intId={employeeID}')
    if(cursor.fetchval() is None): return f'Employee {employeeID} does not exist.'

    #Get last log entry
    responce=cursor.execute(f'select top (1) _entry,_exit from {config["EmployeeLogsTable"]} where _intId = {employeeID} order by _entry DESC;')
    data = responce.fetchone()
    val=tuple()

    #Decide if it's an entry or an exit
    if(data is None or data[0] is None or (data[0] is not None and data[1] is not None)):
        sql = f'insert INTO {config["EmployeeLogsTable"]} (_intId,_entry) VALUES(?, ?); update {config["EmployeeDataTable"]} set _employmentStatus = 1 where _IntId = ?;'
        val = (employeeID, datetime.now().strftime('%Y-%m-%d %H:%M:%S'), employeeID)
        cursor.execute(sql, val)
        SQLConnection.commit()
        return 'Entry added.'
    elif(data[1] is None):
        sql = f'update {config["EmployeeLogsTable"]} set _exit = ? where _intId = ? and _entry = ?;update {config["EmployeeDataTable"]} set _employmentStatus = 2 where _IntId = {employeeID};'
        val = (datetime.now().strftime("%Y-%m-%d %H:%M:%S"),employeeID,data[0] )
        cursor.execute(sql, val)
        SQLConnection.commit()
        return 'Exit added.'
    else: return 'Could not add/update entry.'


path = config['RootDirectory']+'\\Images'
images = [] # list that contains all the images
EmployeeIdentity = [] # list that contains all the names of the images without an image suffix
myList = os.listdir(path) # list that contains all the names of the images

# adding image to list
for empIdentity in myList:
    EmployeeIdentity.append(os.path.splitext(empIdentity)[0])
    curImg= cv2.imread(f'{path}/{empIdentity}')
    images.append(curImg)

#Encoding
def findEncodings (images):
    encodingList = []
    for ImageForIdentification in (map(lambda x: cv2.cvtColor(x, cv2.COLOR_BGR2RGB),images)):
        try: encodingList.append(face_recognition.face_encodings(ImageForIdentification)[0])
        finally: continue
    return encodingList

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
        if match[theBastMatchIndex] and faceDistance[theBastMatchIndex] < 0.45:
            Employee = EmployeeIdentity[theBastMatchIndex].upper()
            empName = GetFullName(Employee)
            greeting = GetTimedGreeting(datetime.now())
            print(greeting, empName)
            y1,x2,y2,x1= faceLocation
            y1,x2,y2,x1= y1*4,x2*4,y2*4,x1*4
            cv2.rectangle(img,(x1,y1),(x2,y2),(0,255,0),1)
            cv2.rectangle(img,(x1,y2-35),(x2,y2),(0,255,0),cv2.FILLED)
            cv2.putText(img,empName,(x1+6,y2-25),cv2.FONT_HERSHEY_COMPLEX,0.5,(0,0,0),2)
            result = StampEmployee(Employee)
            if(result =='Too soon.'):
                print(f'{empName} already stamped')
            else: 
                print(result)
                cv2.putText(img,greeting,(x1+6,y2-6),cv2.FONT_HERSHEY_COMPLEX,0.5,(0,0,0),2)
    cv2.imshow("Camera", img)
    cv2.waitKey(1)
