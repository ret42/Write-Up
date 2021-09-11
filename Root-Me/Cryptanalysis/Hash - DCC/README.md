# Hash - DCC

### Prerequires:

- [Rockyou](https://github.com/praetorian-inc/Hob0Rules/blob/master/wordlists/rockyou.txt.gz)
- [John the Ripper](https://www.openwall.com/john/)

-----------------

- Put this format hash in your .hash file `M$Administrator#15a57c279ebdfea574ad1ff91eb6ef0c`

- So it's not really hard, just use this cmd: `./john --format=mscash -w=./rockyou.txt ./myhash.hash`

- And you will get the flag
