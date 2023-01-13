import json
import datetime
from openpyxl import load_workbook
from win32com import client
import calendar


pathConfig = []
with open('TempClientConfig.txt') as file:
        lines = file.readlines()
        line = lines[0].split('=')
        print(lines)
        pathConfig = line
print(pathConfig)

path = pathConfig[1]+'\\'
f = open(f"{path}log.json", "r")
jsonFile = json.load(f)

# למשתנים JSON פירוק קובץ  
month = jsonFile["Month"]
year = jsonFile["Year"]
name = jsonFile["Full Name"]
StateID = jsonFile["StateID"]
InternalID = jsonFile["InternalID"]
MonthlyHours = jsonFile["MonthlyHours"]
TotalOvertime = jsonFile["TotalOvertime"]

# מילוי שדות פרטיי העובד
def returnDetails():
    sheet["C1"] = f"       Monthly employee report {month}/{year}"
    sheet["D3"] = f"Employee name: {name}"
    sheet["C4"] = f"     State ID: {StateID}"
    sheet["F4"] = f"     Internal ID: {InternalID}"
    sheet["J39"] = MonthlyHours
    sheet["K39"] = TotalOvertime

# יצירת פורמט של דוח נוכחות לפי חודש
def returnDatePerMount(rangeMonth):
    c = 0
    for i in range(8, rangeMonth+8):
        if c != rangeMonth + 1: c += 1
        dataforFormatMonth = str(f"{month}")
        if int(dataforFormatMonth) < 10: dataforFormatMonth = str(f"0{month}")
        formatDay, formatMonth, formatYear = str(f"0{c}" if c<10 else c), dataforFormatMonth, str(f"{year}")
        sheet[f"A{i}"] = f"{formatDay}/{formatMonth}/{formatYear}"
        d = datetime.date(int(formatYear), int(formatMonth), int(formatDay))
        sheet[f"B{i}"] = f"{calendar.day_name[d.weekday()]}"
        if calendar.day_name[d.weekday()] != 'Friday' and calendar.day_name[d.weekday()] != 'Saturday':
            sheet[f"C{i}"] = "08:00"
# מילוי דוח בנתוני שעות העבודה של העובד
def returnHours():
    day = jsonFile["Days"]
    c = 7
    for data in day:
        c += 1
        if data["Total"] == "00:00:00":
           continue
        else:
            sheet[f"J{c}"] = (data["Total"])
            if len(data["Entries"]) >= 3: forThree(data,c)
            elif len(data["Entries"]) == 2: forTwo(data,c)
            else: forOne(data,c)
            if data["Overtime"] == "00:00:00":
                continue
            else:
                sheet[f"K{c}"] = data["Overtime"]


def forThree(data,c):
    one = data["Entries"][0]
    sheet[f"D{c}"] = one["Start"][:5]
    sheet[f"E{c}"] = one["End"][:5]
    two = data["Entries"][1]
    sheet[f"F{c}"] = two["Start"][:5]
    sheet[f"G{c}"] = two["End"][:5]
    three = data["Entries"][-1]
    sheet[f"H{c}"] = three["Start"][:5]
    sheet[f"I{c}"] = three["End"][:5]

def forTwo(data,c):
    one = data["Entries"][0]
    sheet[f"D{c}"] = one["Start"][:5]
    sheet[f"E{c}"] = one["End"][:5]
    two = data["Entries"][1]
    sheet[f"F{c}"] = two["Start"][:5]
    sheet[f"G{c}"] = two["End"][:5]

def forOne(data,c):
    one = data["Entries"][0]
    sheet[f"D{c}"] = one["Start"][:5]
    sheet[f"E{c}"] = one["End"][:5]


day = jsonFile["Days"]


#xlsx שמירת הקובץ בפורמט 
workbook = load_workbook(filename=f'{path}Hours_Report.xlsx')
sheet = workbook.active
rangeMonth = calendar.monthrange(int(year), int(month))

returnDatePerMount(rangeMonth[1])
returnDetails()
returnHours()

workbook.save(filename=f"{path}{InternalID}.xlsx")
#PDF המרת הקובץ לפורמט 
excel = client.Dispatch("Excel.Application")
sheets = excel.Workbooks.Open(f"{path}{InternalID}.xlsx")
work_sheets = sheets.Worksheets[0]
work_sheets.ExportAsFixedFormat(0, f"{path}{InternalID}.pdf")
sheets.Close(True)
