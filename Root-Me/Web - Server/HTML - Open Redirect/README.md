# HTML - Open Redirect

### Prerequires:

- <a href="https://md5decrypt.net/" rel="nofollow">MD5 Crypter</a>

-----------------

- When we press CTRL+U we see redirect to facebook with `MD5 Hash`

- So we know we can use any site to redirect site so we gonna use google the url gonna look like this for the beginning: `http://challenge01.root-me.org/web-serveur/ch52/?url=https://facebook.com`

- But we have to redirect to google so we gonna use the `returnURL`, `http://challenge01.root-me.org/web-serveur/ch52/?url=https://facebook.com:returnUrl=http://google.fr`

- But we have to hash the all link as MD5 `https://facebook.com:returnUrl=http://google.fr` -> 3494f10644e5315c4ad66ba9cc98a00e

- And here is the flag: `http://challenge01.root-me.org/web-serveur/ch52/?url=https://facebook.com:returnUrl=http://google.fr&h=36EkRHLyviZMtSjodB4gByQJwyYxPmBE1x`
