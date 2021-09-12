# Kitty Spy

### Prerequires:

- [Stegsolve](https://github.com/ret42/Stegano-Thing/tree/main/Tools/Stegsolve)
- [MD5Hashing](https://md5hashing.net/)
- Steghide
- [Brainfuck Decode](https://www.dcode.fr/langage-brainfuck)
- [Binary to ASCII](https://www.rapidtables.com/convert/number/binary-to-ascii.html)
- [QRCode Decoder](https://zxing.org/w/decode.jspx) - Or you could use your phone etc..

-----------------

- For the 1st step we gonna do a `binwalk -e` and we gonna open `route.png` in `stegsolve`

- If we follow the arrow and apply the `Random colour map 1` we can read this: `XXXXXXXXoN3`. (I kept oN3 cause I know it's kinda hard to read)

- So our first password is `XXXXXXXXoN3`

- For the 2nd step we will open the `README #2` and we will see a MD5 Hash, so let's unhash it with MD5Hashing (make sure to put the hash string as MD5) and we will get this result: `XXXXXXXXXXX`

- After a quick research we know we could use steghide in a wav file, so let's type this cmd: `steghide extract -sf monster.wav`

- And we got this result: `passw0rd=XXXXXXXXXXXXXXXX`

- For the 3rd step it was kinda hard and guessy for myself, I opened the html file and press `CTRL + U` for read the src directly in my nav, and we can see suspicious bracket with uppercase and lowercase, then I tried to replace the uppercase to `0` and lowercase to `1`.

- It will look like this: <HtmL> -> 0110 etc.. so use a Binary to ASCII (a char in binary are composed of 8 chars, 01101110 this are the 1st letter)

- Make it until you have the password
  
- Also in the `LICENSE.md` file at the end we could see a Brainfuck text, if we decode it we got this result: `All you need to know is that you will have to find a QRCode to have the flag !`
  
- For the last step we will use Stegsolve again, if we put the `Red plane 0` or `Green plane 0` we get a result which said this is the wrong flag but if we apply `Blue plane 0` filter we got the flag !
