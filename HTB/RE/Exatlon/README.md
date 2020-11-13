# Exatlon

### Prerequires:

- <a href="https://www.hex-rays.com/products/ida/support/download/" rel="nofollow">IDA</a>

-----------------

- Let's open our terminal and type " strings exatlon_v1 " .

<img src="https://cdn.discordapp.com/attachments/698984879823519827/776587054569226250/unknown.png">

- We can see it's packed with UPX, so let's unpack it with this command " upx -d exatlon_v1 ":

<img src="https://cdn.discordapp.com/attachments/698984879823519827/776592925403643904/unknown.png">

- Go try to open the file now with " ./exatlon_v1 "

<img src="https://cdn.discordapp.com/attachments/698984879823519827/776785639689420810/unknown.png">

- We need pw so let's open IDA and open the file " exatlon_v1 "

- Now go to the main function, when we scroll down this appear:

<img src="https://cdn.discordapp.com/attachments/698984879823519827/776786752613384202/unknown.png">

- So right click on it and click to " Jump to operand "

- If we scroll up 

<img src="https://cdn.discordapp.com/attachments/698984879823519827/776787500748111872/unknown.png">

- Now we know the pass.

- At this moment I got stucked a lot because I was not able to understand the pattern.

- I was pretty sure it was an ASCII table so I started to devide arrived at 16.

- The pattern looked more logic.

- I used the ASCII table for see if the first three results are good (I mean if it was HTB or not)

- It was HTB, so let's write a script in python for devide

- <a href="https://github.com/cr0c0/Writes-Ups/blob/main/HTB/RE/Exatlon/flag.py" rel="nofollow">Flag</a>

- And you will get the flag ^^

<img src="https://cdn.discordapp.com/attachments/698984879823519827/776798911121457172/unknown.png">
