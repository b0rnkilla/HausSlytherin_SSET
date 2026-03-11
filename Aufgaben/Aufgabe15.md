## Aufgabe 15 – Architektur Review

### 15.1 Analysiere dein Projekt

Das Projekt ist in Bereiche wie **Models, Services und Repositories** unterteilt.
Diese Struktur trennt Daten, Business Logic und Datenzugriff voneinander.

---

### 15.2 Identifiziere Verbesserung

Eine mögliche Verbesserung wäre die **weitere Trennung von Verantwortlichkeiten**, zum Beispiel durch zusätzliche Interfaces oder spezialisierte Services.
Außerdem könnten Validierungen und spezielle Logik noch klarer ausgelagert werden.

---

### 15.3 Refactore Struktur

Die Struktur kann verbessert werden, indem Klassen klar nach Aufgaben aufgeteilt werden, zum Beispiel:

* **Models** für Datenstrukturen
* **Repositories** für Datenzugriff
* **Services** für Business Logic
* **Interfaces** für Abstraktionen

Dadurch wird das System besser wartbar und erweiterbar.

---

### 15.4 Diagramm (optional)

```
Program
   │
   ▼
Services
   │
   ▼
Repositories
   │
   ▼
Models
```

Die Anwendung arbeitet über Services mit den Daten, während die Repositories den Zugriff auf die gespeicherten Daten übernehmen.
