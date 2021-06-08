# Javascript - Obfuscation 5

### Prerequires:

- Nothing

-----------------

- Too long for making my own WU so here is the solution by py script (I will made my new one soon):

```py
    #!/usr/bin/python3
    #coding: utf-8
     
    import string
    import requests
     
    printable = string.ascii_letters + string.digits + string.punctuation + ' '
    xor = lambda x,y : ''.join(chr(ord(c) ^ y) for c in x)
     
    def chall_hash(to_hash):
        alphabet = '8aZ{E$+rT yU}1#2(IOP<qs,DFg.)H*Jk~L6M7]W;X%VxB:N!^-03/9[4&5|"?Kz'
        i = 0
        chr1 = ord(to_hash[0]);
        enc1 = chr1 >> 2;
        res_hash = ""
        if len(to_hash) == 3:
            chr2 = ord(to_hash[1])
            chr3 = ord(to_hash[2])
            enc2 = (chr1 & 3) << 4 | chr2 >> 4;
            enc3 = (chr2 & 15) << 2 | chr3 >> 6;
            enc4 = chr3 & 63;
            res_hash += alphabet[enc1] + alphabet[enc2] + alphabet[enc3] + alphabet[enc4];
        elif len(to_hash) == 2:
            chr2 = ord(to_hash[1])
            chr3 = None
            enc2 = (chr1 & 3) << 4 | chr2 >> 4;
            enc3 = (chr2 & 15) << 2;
            res_hash += alphabet[enc1] + alphabet[enc2] + alphabet[enc3];
        else:
            chr2 = chr3 = None
            enc2 = (chr1 & 3) << 4
            res_hash += alphabet[enc1] + alphabet[enc2];
     
        return res_hash
     
    token = "p5rdEr87pT}dp'[Ap^2d2S*,~:JLESF0 ('7p(,5J'<,2prFE/W"
     
    key = ord(chall_hash("er")[-1]) ^ ord(token[-1])
    print("Clé du XOR : %s" % key)
     
    token = xor(token,key)
    password = ""
    for turn in range(0,12):
        found = False
        index_turn = turn*4
        print("Tour %s consignes: %s" % (turn, token[index_turn: index_turn+4]))
        for i in printable:
            for j in printable:
                for k in printable:
                    hashstring = chall_hash(i + j + k)
                    if hashstring == token[index_turn:index_turn+4]:
                        password += i + j + k
                        found = True
                        print("Tour %s : %s" % (turn,password))
                    if found:break
                if found:break
            if found:break
     
    password = password[0:-2] # on enléve les 2 derniérs caractéres qui sont eD
    print("le mot de passe est dans cette chaine : %s" % password)
     
    for i in range(0, len(password)):
        flag = password[i:]
        res = requests.get("http://challenge01.root-me.org/web-client/ch15/%s.php" % flag)
        if res.status_code == 200:
            print("Le flag : %s" % flag)
            break
```
