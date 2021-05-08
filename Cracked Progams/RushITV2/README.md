# Rush IT V2

FR: C'est un programme qui a pour but d'optimiser son pc, petit hic, il n'optimise presque en rien le pc, et chez certaines personnes il le rend plus buggé, et le développeur le vend à un prix trop élevé pour ce que le programme permet, sans oublier que il est comblé de bug (Par exemple il ne clear pas le prefetch alors qu'il y a l'option etc...)
Le write-up sera en anglais.

EN: It's a program which has for goal to optimize the pc, small hitch, it optimizes almost nothing the computer, and at certain people it makes it more buggy, and the developer sells it at a price too high for what the program allows, without forgetting that it is filled of bug (For example it does not clear the prefetch whereas there is the option etc...)
The write-up will be in english.

-----------------

# Write-Up:

### Prerequires:

- <a href="https://github.com/CodeCracker-Tools/MegaDumper" rel="nofollow">MegaDumper (Just take the MegaDumper build it will be faster)</a>
- <a href="https://www.mediafire.com/file/82y53xo98itj2di/MegaDumper.exe/file" rel="nofollow">MegaDumper Build</a>
- <a href="https://github.com/dnSpy/dnSpy" rel="nofollow">dnSpy</a>

-----------------

- So for the first step let's open MegaDumper as administrator, and open " rush_it_v1.exe " (I already know it was .NET)

- Let's search in MegaDumper the process named " rush_it_v1.exe " and right click on it and press .NET dump.

<img src="https://cdn.discordapp.com/attachments/804801385240723519/840580038025674752/unknown.png">

- When it's done you will have a folder with the name " Dumps ", and now we can close MegaDumper and Rush IT.

- Open dnSpy and drag the Rush IT with the lowest size.

<img src="https://cdn.discordapp.com/attachments/804801385240723519/840580803561127976/unknown.png">

- Now let's go into " Rush_it_redesign " and " Form1 ", you will have this:

<img src="https://cdn.discordapp.com/attachments/804801385240723519/840581231594831903/unknown.png">

- We can see the database and how it works, the first thing I tried it's to change my MachineGuid as the MachineGuid of Aquafy so " 782c32d8-6e21-48c1-9ec6-9d888b38b2ba ", I went to my registry with this dir: HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Cryptography, and it worked.

- So we can connect to the program with the MachineGuid of someone.

- Now let's crack it for real.

- Go to the folder Dumps and drag the file " Bunifu_UI_v1.5.3.dll " into dnSpy (it will be important for compile it again)

- In dnSpy press right click and " Edit Method (C#)... ", and for all else just replace it as if so it will look like that

<img src="https://cdn.discordapp.com/attachments/804801385240723519/840583081324576788/unknown.png">

```csharp
						Form2 form = new Form2();
						MessageBox.Show("Connecté! cracked by XXX", "Rush It", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						form.Show();
						base.Hide();
					}
					else
					{
						Form2 form = new Form2();
						MessageBox.Show("Connecté! cracked by XXX", "Rush It", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						form.Show();
						base.Hide();
					}
				}
				else
				{
					Form2 form = new Form2();
					MessageBox.Show("Connecté! cracked by XXX", "Rush It", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					form.Show();
					base.Hide();
				}
			}
			else
			{
				Form2 form = new Form2();
				MessageBox.Show("Connecté! cracked by XXX", "Rush It", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				form.Show();
				base.Hide();
			}
		}
	}
}
```

- You can replace the XXX by your name if you want.

- Now click on Compile (Bottom right), save it and execute it.

- You cracked the progam:

<img src="https://cdn.discordapp.com/attachments/804801385240723519/840583701573664798/unknown.png">
<img src="https://cdn.discordapp.com/attachments/804801385240723519/840583791147352074/unknown.png">

- Keep in mind it's a trash program so I don't advise you to use it.
