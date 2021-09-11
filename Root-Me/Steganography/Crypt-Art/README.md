# Crypt-Art

### Prerequires:

- [npietDecoder](http://www.bertnase.de/npiet/npiet-execute.php)
- [VigenèreDecoder](https://www.dcode.fr/chiffre-vigenere)

-----------------

- For the first step, if we do a `strings ch8.ppm` we can see the encrypted pass: `The encrypted pass is: XXXXXXXXXX`

- If we open the image we can see a art, i've already create a challenge like this so I know it was a npiet image, so I went to a npiet decoder

- And we got this result: `key is XXXXX`

- For the final step I was thinking on which method the pass was encrypted, and after few minutes I figure that it could be vigenere

- So I went to a vigenere decoder and I put the encrypted pass and the key and I got the flag: `ARTLOVXXXXXXXX`
