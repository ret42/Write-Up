# proc's & net

### Prerequires:

- Nothing

-----------------

- Take a random text editor.

- We can see this.

<img src="https://cdn.discordapp.com/attachments/698984879823519827/782026633606332426/unknown.png">

- Grab the remote ip, and use this script

```perl
#!/usr/bin/perl

my $hexip=$ARGV[0];
my $hexport=$ARGV[1];

print "hex: $hexip\n";

my @ip = map hex($_), ( $hexip =~ m/../g );

my $ip = join('.',reverse(@ip));

my $port = hex($hexport);

print "IP: $ip  PORT: $port\n";
```

- (https://gist.github.com/jkstill/5095725)

- When we decode we got the IP, and for find the source port the url is HTTPS so it's 443

<img src="https://cdn.discordapp.com/attachments/698984879823519827/795743031600087070/unknown.png">


