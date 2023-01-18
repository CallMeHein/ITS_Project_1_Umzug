# Projekt: Umzug

## Anforderungsanalyse

### Ist-Zustand

- Kleinunternehmen
- 5 MitarbeiterInnen
- Eine Etage
- Netzplan:
  - Router von ISP gestellt
  - Alle Rechner über einen Switch an Router angebunden
  - Alle Geräte manuell konfiguriert

### Soll-Zustand

- Zweite Etage wird angemietet
- Dynamische Vergabe der IPs an alle Geräte
- Etagen sollen in jeweils eigenem Netzwerk liegen
- Alle Geräte sollen Internetzugang haben → Verbindung mit Router

### Offene Fragen

- Gibt es Vorschriften zu der Art der Verbindung? WLAN? LAN?
  - Vorschlag: LAN
    - Pro
      - Stabilere Verbindung
      - Höhere Bandbreite
    - Contra
      - Höherer Aufwand (Kabel verlegen, evtl Anpassungen am Gebäude)
      - Expansion undynamischer (→ erfordert zukunftssicherere Planung, ansonsten k)
- Wird mit neuen MitarbeiterInnen gerechnet?
  - Wenn ja, wie viele Geräte können in den Etagen jeweils vorhanden sein? (→ maximale Größe der nötigen Switches bestimmen, um zukunfssicher zu planen)
- Wird es innerhalb der Etagen Abteilungen geben, die nochmal in einem jeweils eigenen Subnetz liegen sollen?
  - Wenn ja, wie viele Abteilungen oder Subnetze sollen berücksichtigt werden?
  - Ansonsten: Kann mit einer weiteren Expansion (z.B. auf eine dritte Etage) gerechnet werden?
  - → Anzahl der nötigen Ports des Routers bestimmen, evtl. muss ein anderer Router verwendet werden.
- Soll die aktuell verwendete Netzaddresse weiterhin verwendet werden?
  - Falls ja, Prüfen, ob genug Host-IP-Adressen vorhanden sind um die nötigen ausreichend Subnetze einzurichten
  - Ansonsten: Freie Wahl? Vorschriften?

## Netzplan

## Demonstrationsprototyp PaketTracer
