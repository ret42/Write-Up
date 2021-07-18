# WASM - Introduction

### Prerequires:

- <a href="https://md5decrypt.net/" rel="nofollow">MD5Decrypt</a>

-----------------

- I didn't know WASM, but this challenge was little bit easy.

- We have to extract the index.wasm so just add `/index.wasm` in the url for get it.

- After that let's do a `strings index.wasm` into our terminal.

- We can see MD5.c etc...

- So with a little logic we can easily understand that our password are hashed in MD5

- If we scroll up we can see the hash `936fff76f378ace4cf83a4360cafcc20`

- Now we have to past the hash into [MD5Decrypt](https://md5decrypt.net/) and past the result into the challenge and we get the flag
