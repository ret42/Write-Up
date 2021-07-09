# PE DotNet - Basic Anti-Debug

### Prerequires:

- <a href="https://github.com/dnSpy/dnSpy" rel="nofollow">dnSpy</a>

-----------------

- Open dnSpy and drag the file into it.

- Go on the Form1 and remove the anti-debugging method: (right click edit method)

<img src="https://cdn.discordapp.com/attachments/862667483709440010/863037353408069642/unknown.png">

- To this:

<img src="https://cdn.discordapp.com/attachments/862667483709440010/863037525378334731/unknown.png">

- Compile it, and save the file as a new name like ``ch39ss.exe``.

- Close all project and drag ``ch39ss.exe`` into dnSpy.

- Go again into the Form1 and put a breakpoint at line 48 ``bool flag = Operators.CompareString(this.TextBox1.Text, Form1.mqsldfksdfgljk(@string, key), false) == 0;`` and start the program.

- Click on the "Check!" button and in dnSpy at the bottom you will see the real flag.
