# Netzplan

Basis-Netzadresse: 192.168.2.0 / 24

Folgende Subnetze werden konfiguriert:

| (Sub-)Netzadresse  | IP von        | IP bis        | Anzahl IPs | Anzahl Hosts | Verwendung     |
|--------------------|---------------|---------------|------------|--------------|----------------|
| 192.168.2.0 / 27   | 192.168.2.0   | 192.168.2.31  | 32         | 29           | Abteilung 1    |
| 192.168.2.32 / 27  | 192.168.2.32  | 192.168.2.63  | 32         | 29           | Abteilung 2    |
| 192.168.2.64 / 27  | 192.168.2.64  | 192.168.2.95  | 32         | 29           | Abteilung 3    |
| 192.167.2.96 / 27  | 192.168.2.96  | 192.168.2.127 | 32         | 29           | Abteilung 4    |
| 192.168.2.240 / 30 | 192.168.2.240 | 192.168.2.243 | 4          | 1            | Druckerraum E1 |
| 192.168.2.244 / 30 | 192.168.2.244 | 192.168.2.247 | 4          | 1            | Serverraum     |
| 192.168.2.248 / 30 | 192.168.2.248 | 192.168.2.251 | 4          | 1            | DruckerRaum E2 |
| 192.168.2.252 / 30 | 192.168.2.252 | 192.168.2.255 | 4          | 1            | Konferenzraum  |

Der Konferenzraum wird mit einem WLAN-Router ausgestattet, weshalb nur ein Host notwendig ist. Die Konfiguration des neuen Routers folgt.

<br>

Folgende Subnetze werden nicht benötigt und können somit in Zukunft verwendet werden, z.B. für weitere Abteilungen:

| (Sub-)Netzadresse  | IP von        | IP bis        | Anzahl IPs | Anzahl Hosts |
|--------------------|---------------|---------------|------------|--------------|
| 192.168.2.128 / 26 | 192.168.2.128 | 192.168.2.191 | 64         | 61           |
| 192.168.2.192 / 27 | 192.168.2.192 | 192.168.2.223 | 32         | 29           |
| 192.168.2.224 / 28 | 192.168.2.224 | 192.168.2.239 | 16         | 13           |