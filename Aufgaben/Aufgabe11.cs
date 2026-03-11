namespace HausSlytherin_SSET.Aufgaben
{
    // Aufgabe 11 - Exception Design

    // Aufgabe 11.1 - Wann sollte man Exceptions verwenden?
    /*
     * Exceptions sollten verwendet werden, um unerwartete oder fehlerhafte Situationen zu behandeln, die während der Programmausführung auftreten können.
     * Sie ermöglichen es, Fehler zu erkennen und darauf zu reagieren, ohne dass das gesamte Programm abstürzt.
     * Beispiele sind ungültige Benutzereingaben, fehlende Daten, ungültige Zustände, ...     * 
     */

    // Aufgabe 11.2 - Erstelle eigene Exception:
    public class DangerLevelException : Exception
    {
        public DangerLevelException(string message) : base(message) { }
    }

    // Aufgabe 11.3 - Werfe Exception wenn Level > 10:
    // -> siehe Program.cs

    // Aufgabe 11.4 - Fange Fehler im Main:
    // -> siehe Program.cs
}
