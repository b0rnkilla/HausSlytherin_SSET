## Aufgabe 6 – SOLID Analyse

### 6.1

**Erkläre Single Responsibility Principle (SRP).**

Das Single Responsibility Principle besagt, dass eine Klasse **nur eine einzige Verantwortung** haben sollte.
Das bedeutet, eine Klasse sollte nur **eine klar definierte Aufgabe** erfüllen und nur aus **einem Grund geändert werden müssen**.

---

### 6.2

**Erkläre Open Closed Principle (OCP).**

Das Open Closed Principle besagt, dass Softwarekomponenten **für Erweiterungen offen, aber für Änderungen geschlossen** sein sollen.
Neue Funktionen sollten durch **Erweiterung (z. B. neue Klassen oder Implementierungen)** hinzugefügt werden, ohne bestehenden Code verändern zu müssen.

---

### 6.3

**Erkläre Dependency Inversion Principle (DIP).**

Das Dependency Inversion Principle besagt, dass **hochwertige Module nicht direkt von konkreten Klassen abhängen sollen**, sondern von **Abstraktionen** wie Interfaces.
Dadurch wird der Code flexibler, austauschbarer und leichter testbar.

---

### 6.4

**Finde ein Beispiel aus deinem Code.**

Ein Beispiel ist die Verwendung eines **Interfaces wie `IRateable`**.
Klassen wie `Dragon` oder `Spider` implementieren dieses Interface, sodass andere Teile des Programms nur mit der **Abstraktion (`IRateable`)** arbeiten müssen und nicht von einer konkreten Klasse abhängig sind.
