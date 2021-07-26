# Fragmented

### Prerequires:

- Nothing

-----------------

- If we do a `strings frag_1` etc..

- We can see we have a part of all flags.

- So we gonna rebuild it, but if we rebuild it in order we cannot exec the file.

- So I tried different orders and it works:


```py
import os

files = ['frag_4', 'frag_1', 'frag_3', 'frag_2', 'frag_7', 'frag_5', 'frag_6']

bytes = b''
for file in files:
    with open(file, 'rb') as f:
        x = f.read()
        bytes += x

with open('flag.elf', 'wb') as f:
    f.write(bytes)

os.system('./flag.elf')
```
