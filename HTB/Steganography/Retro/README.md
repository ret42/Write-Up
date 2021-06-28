# Retro

### Prerequires:

- [MakeTZX](http://ramsoft.bbk.org.omegahg.com/maketzx.html)
- [HexDecoder](https://www.convertstring.com/fr/EncodeDecode/HexDecode)

-----------------

- So the first step of this challenge is to ``binwalk -e`` the "retro.jpg", we will get the ``eighties_were_nice.txt`` and the ``retro.wav`` file

- Let's open the ``eighties_were_nice.txt``

```
Retro style is nice! I hope you can find the "flag" as we usually did in the eighties
```

- If we do a little research about old specturm (80's), we can found a thing named ZXTape, after reading thing we know we have to convert the .wav to .tzx.

- So here is a program for make it: [MakeTZX](http://ramsoft.bbk.org.omegahg.com/maketzx.html)

- So type into your terminal it: ``./maketzx.exe retro.wav output.tzx``

<img src="https://cdn.discordapp.com/attachments/858063013905956908/859141699904995338/unknown.png">

- Now you just have to open the output which text editor, and copy the hex result and paste into [HexDecoder](https://www.convertstring.com/fr/EncodeDecode/HexDecode) and you will have the flag.
