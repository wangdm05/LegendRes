# 小图拼接成大图
# 由于Unity不能创建超过16384的Texture, 所以用Python解决
import PIL.Image as Image
import os
import json
import time
import sys

Image.LOAD_TRUNCATED_IMAGES = True

# 图片大小上线
Image.MAX_IMAGE_PIXELS = None
debug = sys.gettrace()

if debug :
    print("Debug模式\n")
    savePath = 'E:\\RXCQ\\map\\bigImage\\'
    pathRoot = 'E:\\RXCQ\\map\\tiles'
    thumbnailRoot = 'E:\\RXCQ\map\\thumbnails\\'
else:
    print("Release模式\n")
    savePath = sys.argv[2]
    pathRoot = sys.argv[1]

filePaths = os.listdir(pathRoot)
global fileIndex
fileIndex = 0

if not os.path.exists(savePath):
    os.makedirs(savePath)

def merge(path):
    global fileIndex
    fileIndex += 1

    paths = os.listdir(path)
    base_name = os.path.basename(path)
    jsonPath = path + "\\..\\..\\Json\\" + base_name + ".json"
    with open(jsonPath, 'r', encoding = 'UTF-8') as f:
        load_dict = json.load(f)

    textureWidth = load_dict['width']
    textureHeight = load_dict['height']

    to_image = Image.new('RGB', (textureWidth, textureHeight))
    imageSavePath = savePath + base_name + '.jpg'

    if os.path.exists(imageSavePath):
        return

    length = len(paths)
    name = paths[length - 1].split('.')[0]
    x = int(name.split('_')[0]) + 1
    y = int(name.split('_')[1]) + 1

    index = 0
    count = x * y
    for i in range(0, x):
        for j in range(0, y):
            index += 1
            imageFileName = str(i) + "_" + str(j)
            imagePath = path + "\\" + imageFileName + ".jpg"
            from_image = Image.open(imagePath)
            to_image.paste(from_image, (j * from_image.width, i * from_image.height))
            progress = int(index / count * 100)
            print("\r", end="")
            print("小图拼接到大图: {}%, {}, 当前地图名字: {} ".format(progress, "{}/{}".format(fileIndex, len(filePaths)), base_name), end="")

            sys.stdout.flush()
            time.sleep(0.01)

    to_image.save(imageSavePath)

    # 生成缩略图
    Thumbnail(to_image, base_name, 600, 400)

def mergeImages():
    for i in range(0, len(filePaths)):
        filePath = pathRoot + "\\" + filePaths[i]
        merge(filePath)

def Rename():
     for i in range(0, len(filePaths)):
        filePath = pathRoot + "\\" + filePaths[i]
        paths = os.listdir(filePath)
        base_name = os.path.basename(filePath)

        if len(paths) == 1 :
            suffix = paths[0].split('.')[1]
            newName = '0_0.' + suffix
            os.rename(filePath + '\\' + paths[0], filePath + '\\' + newName)
            print("重命名 {} To {}".format(paths[0], newName))

def Thumbnail(toImage, Name, Width, Height):
    # 生成缩略图
    size = Width, Height
    toImage.thumbnail(size)
    toImage.save(thumbnailRoot + Name + '.jpg')
    

Rename()
mergeImages()
print("\n全部拼接完成, {}/{}".format(fileIndex, len(filePaths)))