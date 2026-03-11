namespace HausSlytherin_SSET.Aufgaben
{
    // Aufgabe 7 - God Class Refactoring

    /* Gegeben:
     * class CreatureManager
     * {
     *      CreateCreature()
     *      PrintCreature()
     *      Statistics()
     *      Validation()
     *      Database()
     * }
     */

    /* Aufgabe 7.1 - Warum ist das eine God Class?
     * 
     * Eine God Class ist eine Klasse, die zu viele Verantwortlichkeiten übernimmt.
     * - Verletzung des Single Responsibility Principle
     * - Klasse wird sehr groß und unübersichtlich
     * - Änderungen werden riskant, weil alles miteinander verbunden ist
     * - Code wird schwer testbar
     * - Wiederverwendung wird schwieriger
     * 
     * Kurz gesagt: Eine Klasse weiß zu viel und macht zu viel.
     */

    // Aufgabe 7.2 - Teile Klasse in Services auf.
    public class CreatureService
    {
        // Aufgabe 7.3 - Verschiebe Methoden
        public void CreateCreature() { /* Logik zum Erstellen einer Kreatur */ }
        public void PrintCreature() { /* Logik zum Drucken einer Kreatur */ }
    }
    public class StatisticService
    {
        public void Statistics() { /* Logik zur Berechnung von Statistiken */ }
    }

    public class ValidationService
    {
        public void Validate() { /* Logik zur Validierung von Daten */ }
    }
    public class DatabaseService
    {
        public void SaveToDatabase() { /* Logik zum Speichern in der Datenbank */ }
    }

    // Aufgabe 7.4 - Erkläre Vorteile:

    /* 1. Bessere Wartbarkeit
     * Der Code ist übersichtlicher.
     * 
     * 2. Bessere Testbarkeit
     * Jede Klasse kann separat getestet werden.
     * 
     * 3. Bessere Erweiterbarkeit
     * Neue Funktionen können leichter ergänzt werden.
     * 
     * 4. Einhaltung von SOLID
     * Vor allem Single Responsibility Principle.
     */
}
