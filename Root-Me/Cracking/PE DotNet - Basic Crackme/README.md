# PE DotNet - Basic Crackme

### Prerequires:

- [ProcessHacker](https://github.com/processhacker/processhacker)

-----------------

- [Youtube Video](https://www.youtube.com/watch?v=Ja6Zftw1gSc)

- We gonna use ProcessHacker for this challenge.

- Let's start the program and type random thing, we will get a MessageBox which said "Bad hacker", we will keep it for later.

- Launch ProcessHacker and type DotNet, you will be able to see the program, and some subprocess, and one are named "TempXXXXX" (it will be a random name but it will always start as "Temp")

- Double click on the temp process and go to the `Memory` section and click on `Strings` and check `Image` and press ok.

- Then click on `Filters` and `Contains`, now type Bad hacker and press enter, just scroll up and you will see the flag. 
