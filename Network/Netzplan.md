# Netzplan

Basis-Netzadresse: 192.168.2.0 / 24

Folgende Subnetze werden konfiguriert:

| (Sub-)Netzadresse  | IP von        | IP bis        | Anzahl IPs | Anzahl Hosts | Verwendung            |
|--------------------|---------------|---------------|------------|--------------|-----------------------|
| 192.168.2.0 / 27   | 192.168.2.0   | 192.168.2.31  | 32         | 29           | Abteilung 1           |
| 192.168.2.32 / 27  | 192.168.2.32  | 192.168.2.63  | 32         | 29           | Abteilung 2           |
| 192.168.2.64 / 27  | 192.168.2.64  | 192.168.2.95  | 32         | 29           | Abteilung 3           |
| 192.167.2.96 / 27  | 192.168.2.96  | 192.168.2.127 | 32         | 29           | Abteilung 4           |
| 192.168.2.216 / 29 | 192.168.2.216 | 192.168.2.223 | 8          | 5            | Verbindung der Router |
| 192.168.2.224 / 29 | 192.168.2.224 | 192.168.2.231 | 8          | 5            | Druckerraum UG        |
| 192.168.2.232 / 29 | 192.168.2.232 | 192.168.2.239 | 8          | 5            | Serverraum            |
| 192.168.2.240 / 29 | 192.168.2.240 | 192.168.2.247 | 8          | 5            | Druckerraum OG        |
| 192.168.2.248 / 29 | 192.168.2.248 | 192.168.2.255 | 8          | 5            | Konferenzraum         |

Der Konferenzraum wird mit einem WLAN-Router ausgestattet, dessen Konfiguration folgt.

<br>

Folgende Subnetze werden nicht benötigt und können somit in Zukunft verwendet werden, z.B. für weitere Abteilungen:

| (Sub-)Netzadresse  | IP von        | IP bis        | Anzahl IPs | Anzahl Hosts |
|--------------------|---------------|---------------|------------|--------------|
| 192.168.2.128 / 26 | 192.168.2.128 | 192.168.2.191 | 64         | 61           |
| 192.168.2.192 / 28 | 192.168.2.192 | 192.168.2.206 | 16         | 13           |
| 192.168.2.208 / 29 | 192.168.2.208 | 192.168.2.215 | 8          | 5            |
| 192.168.2.216 / 29 | 192.168.2.216 | 192.168.2.223 | 8          | 5            |
