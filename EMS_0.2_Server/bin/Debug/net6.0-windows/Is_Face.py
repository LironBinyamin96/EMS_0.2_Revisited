import cv2
import face_recognition
import time

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


def has_human_face(image):
    faces = face_recognition.face_locations(image)
    return len(faces)

config = ParseConfig()
path = f'{config["RootDirectory"]}\\Is_Face{config["ImageFormat"]}'
print(path)
image = cv2.imread(path)
print('face search started')
print(has_human_face(image))
print('end')
exit()


