cr0 = "" #Enter the pass you got from IDA

c0 = cr0.split(' ')
flag =''

for num in c0:
    x = chr(int(num)//16)
    flag += x

print(flag)
