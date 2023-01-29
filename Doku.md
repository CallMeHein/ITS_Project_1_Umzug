# Projekt: Umzug

## Teil 1: Netzwerk

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

### Netzplan

Warten auf offene Fragen

### Demonstrationsprototyp PaketTracer

Warten auf offene Fragen
