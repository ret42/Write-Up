# LSB - Uncle Scrooge

### Prerequires:

- [StegoLSB](https://gist.github.com/dhondta/d2151c82dcd9a610a7380df1c6a0272c) (I prefered to use the py file directly)
- [Base64Decode](https://www.base64decode.org/)

-----------------

- I bruteforced the image with the cmd `./stegolsb.py bruteforce ch9.png` and we got this result:

<img src="https://cdn.discordapp.com/attachments/883796930096934962/884865067038945320/unknown.png">

- So after a quick search of why the flag not working, I tried to put the string into some decoder, and the base64 worked.

- Then use [Base64Decode](https://www.base64decode.org/) or type this in your terminal: `echo -en "TFdmMDdyc01iaUE2" | base64 -d`
