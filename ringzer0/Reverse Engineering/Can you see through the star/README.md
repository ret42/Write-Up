# Can you see through the star

### Prerequires:

- [dnSpy](https://github.com/dnSpy/dnSpy)

-----------------

- I just removed the protection, passchar, and the ~form

- So delete it:

<img src="https://cdn.discordapp.com/attachments/862667483709440010/874046544486203422/unknown.png">

- In `Initialize Component()`, remove the `this.maskedTextBox1.PasswordChar = '*';`

- If you press `Compile`, you will have a `Identifier expected` error, so double click on it, and remove this:

<img src="https://cdn.discordapp.com/attachments/862667483709440010/874047052408041472/unknown.png">

- Now you can compile, save the program and execute it and get the flag
