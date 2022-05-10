import os
import numpy as np
import cv2
import face_recognition
import pyodbc
from datetime import datetime

#------------------- SQL -------------------

#חיבור לבסיס נתונים
conn = pyodbc.connect(
    "Driver={SQL Server Native Client 11.0};"
    "Server=DESKTOP-BVFPCJ9\SQLEXPRESS;"
    "Database=EmployeeManagmentDataBase;"
    "Trusted_Connection=yes;")

# בדיקת מצב כניסה אחרונה של העובד
def read(connection,employeeId):
    cursor = connection.cursor()
    cursor.execute(f'select top (1) _entry,_exit from HourLogs where _intId = {employeeId} order by _entry DESC;')
    x=cursor.fetchone()
    if x == None: return False  # אם העובד לא קיים עדיין
    if x[1] == None: return True  # אם העובד הדפיס כניסה אך לא הדפיס יציאה
    return False  # אם יש לעובד כניסה ויציאה

#קבלת זמן הכניסה - פונקציית עזר להדפסת יציאה
def getEntryTime(connection,employeeId):
    cursor = connection.cursor()
    cursor.execute(f'select top (1) _entry from HourLogs where _intId = {employeeId} order by _entry DESC;')
    x = cursor.fetchone()
    for row in x:
        return row
    return 0

#הכנסת שעת כניסה לSQL
def entry (connection,entryTime):
    data = entryTime.split("|")
    cursor = connection.cursor()
    sql = 'insert INTO HourLogs(_intId,_entry) VALUES(?,?);'
    val = (data[0], data[1])
    cursor.execute(sql, val)
    connection.commit()
    print("Entry for employee "+data[0] + "\nEntry time: " + data[1])

#הכנסת שעת יציאה לSQL
def exitTime (connection,exitTime,entryTime):
    data = exitTime.split("|")
    cursor = connection.cursor()
    sql = 'update HourLogs set _exit = ? where _intId = ? and _entry = ?;'
    val = (data[1], data[0], entryTime)
    cursor.execute(sql, val)
    connection.commit()
    print("Exit for employee "+data[0] + "\nexit time: " + data[1])


# מילון עובדים - לבדיקת הפרשי זמן בין כניסה ויציאה
listDict = {}

# קליטת שעות העובדים ועידכון סטטוס כניסה/יציאה
def TimeToEmployee(listDict,formatData):
     data = formatData.split(" ")
     employeeID, employeeDate, employeeHour = data[0], data[1], data[2]

     if (employeeID not in listDict):  # למקרה של עובד חדש או איפוס התוכנה
         listDict[employeeID] = employeeDate+" "+employeeHour
         timestampCheck(employeeID)
     else:
         hold = listDict[employeeID]  # השעה שנמצאת כרגע במילון
         dateTimeToString = datetime.now().strftime('%Y-%m-%d %H:%M:%S')
         sum = datetime.strptime(hold, '%Y-%m-%d %H:%M:%S') - datetime.strptime(dateTimeToString, '%Y-%m-%d %H:%M:%S')
         print(int(abs(sum.total_seconds())))
         if int(abs(sum.total_seconds())) > 10:
             timestampCheck(employeeID)

def timestampCheck(employeeID):
    if read(conn, employeeID):  # אם שעת היציאה ריקה
        listDict[employeeID] = datetime.now().strftime('%Y-%m-%d %H:%M:%S')  # תעדכן את השעה הנוכחית
        formatToReturn = employeeID + "|" + listDict[employeeID]
        exitTime(conn, formatToReturn, getEntryTime(conn, employeeID))
    else:  # אם עובד חדש או עובד מדפיס כניסה
        listDict[employeeID] = datetime.now().strftime('%Y-%m-%d %H:%M:%S')
        formatToReturn = employeeID + "|" + listDict[employeeID]
        entry(conn, formatToReturn)
        listDict[employeeID] = datetime.now().strftime('%Y-%m-%d %H:%M:%S')


#------------------- קבלת תמונות וקידוד -------------------

path = 'imageBasic'
# רשימה שמכילה את כל התמונות
images = []
#רשימה שמכילה את כל השמות של התמונות ללא סיומת תמונה
EmployeeIdentity = []
# רשימה שמכילה את כל השמות של התמונות
myList = os.listdir(path)

#הוספת התמונות לרשימה
for empIdentity in myList:
    EmployeeIdentity.append(os.path.splitext(empIdentity)[0])
    curImg= cv2.imread(f'{path}/{empIdentity}')
    images.append(curImg)

#פונקציה לקידוד כל התמונות
def findEncodings (images):
    encodingList= []
    for ImageForIdentification in images:
        ImageForIdentification = cv2.cvtColor(ImageForIdentification, cv2.COLOR_BGR2RGB)
        encodeImageForIdentification = face_recognition.face_encodings(ImageForIdentification)[0]
        encodingList.append(encodeImageForIdentification)
    return encodingList

#הגדרה והדפסת זמן כניסה או יציאה
def EntryOrExitTime(Employee):
    dateTimeToString = datetime.now().strftime('%Y-%m-%d %H:%M:%S')
    formatData = Employee + " " + dateTimeToString
    TimeToEmployee(listDict,formatData)

encodingListfinal = findEncodings(images)
print("Encoding Complete! number images: " + str(len(encodingListfinal)))
print("---------------------------------------------")


#------------------- הפעלת מצלמה והשוואה בין תמונות לפרצוף -------------------

#הגדרת המצלמה
cap = cv2.VideoCapture(0)

# imgS = הקטנת גודל התמונה על מנת להאיץ את התהליך
while True:
    success, img = cap.read()
    imgS = cv2.resize(img,(0,0),None,0.25,0.25) # רבע מגודל התמונה
    imgS = cv2.cvtColor(imgS, cv2.COLOR_BGR2RGB) # שינוי הצבע
    facesLocation = face_recognition.face_locations(imgS)  # מציאת כל הפרצופים בתמונה
    encodingForCap = face_recognition.face_encodings(imgS,facesLocation)  # קידוד

# ריצה על רשימת תמונות והשוואה לתמונה נוכחית באמצעות הקידוד והמיקום
    for encodeFace, faceLocation in zip(encodingForCap,facesLocation):
        # השוואת פרצופים בין רשימת קידודים לבין הקידוד של התמונת מצלמה
        match = face_recognition.compare_faces(encodingListfinal,encodeFace)
        # ביצוע בדיקה להתאמה הכי טובה למקרה שיש עובדים בעלי חזות דומה
        # ככל שהמרחק קטן יותר - כך יש יותר התאמה
        faceDistance = face_recognition.face_distance(encodingListfinal,encodeFace)
        #print(faceDistance)
        theBastMatchIndex = np.argmin(faceDistance) # מציאת ערך מינימלי של תמונה לפי אינדקס

        if match[theBastMatchIndex] and faceDistance[theBastMatchIndex] < 0.5:
            Employee = EmployeeIdentity[theBastMatchIndex].upper()
            EntryOrExitTime(Employee)
            y1,x2,y2,x1= faceLocation
            y1,x2,y2,x1= y1*4,x2*4,y2*4,x1*4
            cv2.rectangle(img,(x1,y1),(x2,y2),(0,255,0),3)
            cv2.rectangle(img,(x1,y2-35),(x2,y2),(0,255,0),cv2.FILLED)
            cv2.putText(img,Employee,(x1+6,y2-6),cv2.FONT_HERSHEY_COMPLEX,1,(0,0,0),2)

    #cv2.imshow("Camera", img)
    #cv2.waitKey(1)