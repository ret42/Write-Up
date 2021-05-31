# So Many Zips - 5 Pts

### Prerequires:

- <a>Nothing</a>

-----------------

- I used the script of my friend, ty to him <a href="https://github.com/g3zb0yy" rel="nofollow">@g3zb0yy</a>

```py
import os
import io
import zipfile
import re
import glob

def zipexiste(directory):
    is_zip = False
    for root, dirs, files in os.walk(directory):
        for filename in files:
            if re.search(r'\.mzip$', filename):
                is_zip = True
    return is_zip

def unzipdossier(directory):
    while True:
        try:
            for root, dirs, files in os.walk(directory):
                for filename in files:
                    if re.search(r'\.mzip$', filename):
                        to_path = os.path.join(root, filename.split('.mzip')[0])
                        zipped_file = os.path.join(root, filename)
                        if not os.path.exists(to_path):
                            os.makedirs(to_path)
                            with zipfile.ZipFile(zipped_file, 'r') as zfile:
                                zfile.extractall(path=to_path)
                            os.remove(zipped_file)
        except OSError:
            continue


def unzip_directory_recursively(directory, max_iter=1000):
    print(os.path.exists(directory))
    iterate = 0
    while zipexiste(directory) and iterate < max_iter:
        unzipdossier(directory)
        iterate += 1
    pre = "false " if iterate < max_iter else "true"
    print(pre,max_iter, iterate)

# unzip_directory_recursively("iwa")

def see():
    subdirs = [x[0] for x in os.walk("iwa")]
    for dirdir in subdirs:
        for filename in glob.glob(os.path.join(dirdir, '*.*'), recursive=True):
            with open(filename, "r") as file:
                print(file.read())
            #with zipfile.ZipFile(filename, "r") as file:
                #file.extractall("/home/hyp0/Bureau")

see()
```
