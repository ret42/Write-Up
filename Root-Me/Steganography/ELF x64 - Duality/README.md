# ELF x64 - Duality

### Prerequires:

- [steg86](http://apngdis.sourceforge.net/)
- Steghide
- [PCRT](https://github.com/sherlly/PCRT) - For french people I did a translation, click on `README_fr.MD`

-----------------

- So for the first step we have to build steg86 (you can find the build [here](https://github.com/ret42/Write-Up/blob/main/Root-Me/Steganography/ELF%20x64%20-%20Duality/steg86.zip))

- After it we gonna type this ``./steg86 extract innocent.bin > message`` and ``cat message``, we will get our passphrase.

- So let's type ``steghide extract -sf happy.jpg`` and put the passphrase you got before, we will get a corrupted png output.

- So we gonna fix it easily with PCRT with this command ``python2 PCRT.py -i flag.png``, press ``Yes`` everywhere and the flag will be at the top.
