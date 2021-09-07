#  PDF Object

### Prerequires:

- [Peepdf](https://github.com/jesparza/peepdf)
- [Base64Decode](https://www.base64decode.org/)

-----------------

- [Video](https://www.youtube.com/watch?v=EgbMNmKvOGk)

- We gonna launch peepfd and make analysis of the file with this cmd `python2 peepdf.py -i epreuve_BAC_2004.pdf`

- Extract the `object 77` as txt output `object 77 > output.txt`

- So we can easily guess that is Base64, but we will have to remove the first 7 lines:

<img src="https://cdn.discordapp.com/attachments/883796930096934962/884863050212069416/unknown.png">

- After this go on [Base64Decode](https://www.base64decode.org/) and put the *file* to decode, not the encoded string.

- Download the result and you will see the flag
