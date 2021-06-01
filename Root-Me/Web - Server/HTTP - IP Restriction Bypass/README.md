# HTTP - IP Restriction Bypass

### Prerequires:

- <a href="https://portswigger.net/burp/releases/professional-community-2021-5-1" rel="nofollow">Burp Suite</a>

-----------------

- We have to spoof our ip so we gonna use the header `Client-Ip`

- Open Burp Suite and make request to the site, we know we have to be in local for get acces to the site so the IP gonna be `192.168.1.1`

- Press "Forward"

<img src="https://cdn.discordapp.com/attachments/804801385240723519/849283291545731092/unknown.png">

- Here is the flag:

<img src="https://cdn.discordapp.com/attachments/804801385240723519/849283571192561734/unknown.png">
