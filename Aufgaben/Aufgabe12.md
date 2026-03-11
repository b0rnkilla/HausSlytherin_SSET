## Aufgabe 12 – Architektur Analyse

### 12.1 Warum ist diese Struktur sinnvoll?

Die Aufteilung in **Models, Services und Repositories** sorgt für eine klare Struktur im Projekt.
Jeder Bereich hat eine eigene Verantwortung, wodurch der Code übersichtlicher und wartbarer wird.

---

### 12.2 Welche Klasse gehört wohin?

**Models**
Enthalten die Datenstrukturen, z. B. `Creature`, `Incident`, `Researcher`.

**Services**
Enthalten die Business Logic, z. B. `CreatureService` oder `IncidentService`.

**Repositories**
Kümmern sich um den Datenzugriff, z. B. `CreatureRepository`.

---

### 12.3 Beispielstruktur

```
Project
│
├── Models
│   ├── Creature.cs
│   ├── Incident.cs
│   └── Researcher.cs
│
├── Services
│   ├── CreatureService.cs
│   └── IncidentService.cs
│
├── Repositories
│   ├── CreatureRepository.cs
│   └── IncidentRepository.cs
│
└── Program.cs
```

---

### 12.4 Vorteile

* klare Trennung der Verantwortlichkeiten
* bessere Wartbarkeit
* einfachere Erweiterbarkeit
* bessere Testbarkeit
