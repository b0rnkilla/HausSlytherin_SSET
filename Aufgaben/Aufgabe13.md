## Aufgabe 13 – Coupling & Cohesion

### 13.1 Erkläre Kopplung

Kopplung beschreibt, **wie stark Klassen voneinander abhängig sind**.
Eine geringe Kopplung ist besser, weil Klassen dann leichter geändert oder ausgetauscht werden können.

---

### 13.2 Erkläre Kohäsion

Kohäsion beschreibt, **wie gut die Aufgaben innerhalb einer Klasse zusammenpassen**.
Eine hohe Kohäsion ist gut, weil eine Klasse dann eine klare und zusammenhängende Aufgabe erfüllt.

---

### 13.3 Finde Beispiel in deinem Code

Ein Beispiel für gute Kohäsion ist eine Klasse wie `CreatureService`,
die sich nur um Operationen rund um Kreaturen kümmert, z. B. hinzufügen oder suchen.

---

### 13.4 Verbessere Design

Das Design kann verbessert werden, indem Klassen **klar getrennte Verantwortlichkeiten** bekommen und nicht zu stark voneinander abhängen.
Dies erreicht man z. B. durch **Interfaces, Services und das Repository Pattern**.
