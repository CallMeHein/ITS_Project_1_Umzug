# Projekt: Umzug

## Teil 1: Netzwerk

---
### Anforderungsanalyse

#### Ist-Zustand

- Kleinunternehmen
- 5 MitarbeiterInnen
- Eine Etage
- Netzplan:
  - Router von ISP gestellt
  - Netzadresse 192.168.2.0/24
  - Alle Rechner über einen Switch an Router angebunden
  - Alle Geräte manuell konfiguriert

#### Soll-Zustand

- Zweite Etage wird angemietet
  - Konferenzraum für 30 Personen in der oberen Etage
    - WLAN für externe, ohne Zugriff auf interne Netze
    - WLAN für interne, mit Zugriff auf interne Netze
  - Serverraum in der unteren Etage
  - Druckerraum in beiden Etagen
  - Kabelkanal vorhanden → Vernetzung der Etagen per LAN möglich
- Expansion auf 30 Mitarbeiter geplant, gleichmäßig auf Abteilungen verteilt
  - Redundanz beim Konfigurieren der Netzwerke für die Abteilungen einplanen, um weitere Expansion einfach zu gestalten
- Etagen sollen in jeweils eigenem Netzwerk liegen
  - Zwei Abteilungen pro Etage, jeweils in einem eigenen Netz
  - Ein Netzwerkdrucker pro Etage
- Dynamische Vergabe der IPs an alle Geräte

---
### Netzplan

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

<br>

Für den Konferenzraum werden zwei weitere Router benötigt, die mit je einem Access-Point das Gast- bzw. interne Netz aufspannen.

Dafür werden folgende Netze verwendet:

| Netzadresse       | IP von       | IP bis        | Anzahl IPs | Anzahl Hosts | Verwendung      |
|-------------------|--------------|---------------|------------|--------------|-----------------|
| 192.168.3.0 / 26  | 192.168.3.0  | 192.168.3.63  | 64         | 61           | Gastzugang      |
| 192.168.3.64 / 26 | 192.168.3.64 | 192.168.3.127 | 64         | 61           | interner Zugang |

<br>

Folgende Subnetze werden nicht benötigt und können somit in Zukunft verwendet werden, z.B. für weitere Abteilungen:

| (Sub-)Netzadresse  | IP von        | IP bis        | Anzahl IPs | Anzahl Hosts |
|--------------------|---------------|---------------|------------|--------------|
| 192.168.2.128 / 26 | 192.168.2.128 | 192.168.2.191 | 64         | 61           |
| 192.168.2.192 / 28 | 192.168.2.192 | 192.168.2.206 | 16         | 13           |
| 192.168.2.208 / 29 | 192.168.2.208 | 192.168.2.215 | 8          | 5            |
| 192.168.2.216 / 29 | 192.168.2.216 | 192.168.2.223 | 8          | 5            |

---

### Demonstrationsprototyp PaketTracer

Work in Progress. Siehe `./Network/Layout.pkt`