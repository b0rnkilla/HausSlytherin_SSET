namespace HausSlytherin_SSET.Aufgaben
{
    // Aufgabe 8 - Service Layer Design

    // Aufgabe 8.1 - Erstelle Klasse:
    public class CreatureServicee
    {
        // Aufgabe 8.2 - Methoden:
        public void AddCreature() { /* Logik zum Hinzufügen einer Kreatur */ }
        public void GetCreature() { /* Logik zum Abrufen einer Kreatur */ }
        public void RemoveCreature() { /* Logik zum Entfernen einer Kreatur */ }
    }

    // Aufgabe 8.3 - Warum gehört diese Logik nicht ins Model?
    /*
     * Das Model soll in erster Linie die Datenstruktur einer Kreatur beschreiben, also zum Beispiel Eigenschaften wie `Name`, `Species` oder `DangerLevel`.  
     * Methoden wie Hinzufügen, Suchen oder Entfernen sind dagegen fachliche Abläufe und gehören deshalb nicht direkt ins Model.
     *
     * Wenn man diese Logik ins Model legt, bekommt die Klasse zu viele Verantwortlichkeiten.  
     * Dadurch wird der Code unübersichtlicher und verletzt das Single Responsibility Principle.
     */

    // Aufgabe 8.4 - Erkläre Vorteil von Service Layer.
    /* 
     * Ein Service Layer sorgt dafür, dass die Business Logik zentral an einer Stelle liegt.
     * Dadurch bleibt der Code besser strukturiert, leichter wartbar und einfacher erweiterbar.
     * 
     * Außerdem trennt der Service Layer die fachliche Logik von der Datenstruktur und von der Speicherung.
     * Das verbessert die Testbarkeit und passt gut zu einer sauberen Architektur mit Models, Services und Repositories.
     */
}
