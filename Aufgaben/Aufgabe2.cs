namespace HausSlytherin_SSET.Aufgaben
{
    // Aufgabe 2 - OOP Analyse

    /* Gegeben:
     * class Dragon
     * {
     *      public string name;
     *      public int danger;
     * } 
     */

    /* Aufgabe 2.1 - Identifiziere OOP Probleme.
     * 
     * Verletzung der Kapselung: o.g. Felder sind öffentlich, was zu unkontrolliertem Zugriff und Veränderung führen kann.
     * Keine Kontrolle über gültige Werte: Es gibt keine Mechanismen, um sicherzustellen, dass die Felder nur gültige Werte erhalten.
     * Keine saubere Initialisierung: Es gibt keinen Konstruktor, um sicherzustellen, dass die Felder korrekt initialisiert werden.
     * Keine Trennung von Daten und Zugriff: Statt Properties werden rohe Felder verwendet, wodurch keine Logik (z. B. Validierung) beim Setzen der Werte eingebaut werden kann.
     */

    class Drag0n
    {

        // Aufgabe 2.2 - Verbessere Klasse mit Properties:
        public string Name { get; set; }
        public int Danger { get; set; }

        // Aufgabe 2.3 - Füge Konstruktor hinzu:
        public Drag0n(string name, int danger)
        {
            Name = name;
            Danger = danger;
        }

        // Aufgabe 2.4 - Füge Methode hinzu:
        public void PrintInfo()
        {
            Console.WriteLine($"Dragon Name: {Name}, Danger Level: {Danger}");
        }
    }


}
