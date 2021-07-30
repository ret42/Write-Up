# New Location

### Prerequires:

- [Burp Suite](https://portswigger.net/burp)

-----------------

- So if we read the php src, we can see the flag appear when we enter a wrong key, and we got redirect to the error page.

- Then I used Burp Suite.

- We put the link of the challenge in the browser, and we enter a random key and press forward untill you arrived to the error page.

- Go to the HTTP History and the flag wil be here

<img src="https://cdn.discordapp.com/attachments/862488407170351124/870474082485960704/unknown.png">
