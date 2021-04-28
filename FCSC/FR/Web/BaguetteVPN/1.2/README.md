# [Web] BaguetteVPN 1/2 - 25pts

### Prérequis:

- dirsearch

<img src="https://cdn.discordapp.com/attachments/837006684558852156/837009284033544212/unknown.png">

-----------------

- On donc faire un " dirsearch -u http://challenges2.france-cybersecurity-challenge.fr:5002/ ", une fois fais on pourra voir un lien vers un Dockerfile, une fois rendu on obtiendra ce fichier:

```dockerfile
FROM python:3.7.3

WORKDIR /usr/src/app

COPY ./server/requirements.txt ./
RUN pip install --no-cache-dir -r requirements.txt

COPY ./server/ ./

RUN useradd ctf
USER ctf

CMD [ "python", "./baguettevpn_server_app_v0.py" ]
```

- Donc on peut se douter que l'url voulu est ceci: http://challenges2.france-cybersecurity-challenge.fr:5002/baguettevpn_server_app_v0.py

<img src="https://cdn.discordapp.com/attachments/837006684558852156/837009914983088179/unknown.png">

- Et effectivement c'était juste: FCSC{e5e3234f8dae908461c6ee777ee329a2c5ab3b1a8b277ff2ae288743bbc6d880}
