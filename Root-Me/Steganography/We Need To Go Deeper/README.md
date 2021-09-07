# We Need To Go Deeper

### Prerequires:

- binwalk

-----------------

- If we do a binwalk we can see this result:

<img src="https://cdn.discordapp.com/attachments/883796930096934962/884861109591474297/unknown.png">

- So we gonna skip the 404 result with this `dd if=ch10.jpg of=flag.jpg skip=404 bs=1`

- And you will get the flag in the `flag.jpg`
