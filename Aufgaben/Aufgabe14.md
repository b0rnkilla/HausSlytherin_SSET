## Aufgabe 14 – Code Smells

### 14.1 Definiere „Code Smell“

Ein Code Smell ist ein Hinweis darauf, dass der Code **schlecht strukturiert oder schwer wartbar** sein könnte.
Er zeigt mögliche Designprobleme im Code, auch wenn das Programm technisch funktioniert.

---

### 14.2 Beispiele

**God Class**
Eine Klasse übernimmt zu viele Aufgaben und wird dadurch sehr groß und unübersichtlich.

**Duplicate Code**
Der gleiche Code kommt an mehreren Stellen im Programm vor.

**Long Method**
Eine Methode ist zu lang und erledigt zu viele Aufgaben.

---

### 14.3 Zwei Beispiele

* Eine Klasse `CreatureManager`, die gleichzeitig Kreaturen erstellt, speichert, validiert und Statistiken berechnet.
* Mehrere Methoden enthalten denselben Berechnungscode für einen RiskScore.

---

### 14.4 Refactoring

**God Class:**
Die Klasse wird in mehrere spezialisierte Klassen aufgeteilt, z. B. `CreatureService`, `CreatureRepository` und `CreatureValidator`.

**Duplicate Code:**
Der wiederholte Code wird in eine eigene Methode ausgelagert und von mehreren Stellen aufgerufen.
