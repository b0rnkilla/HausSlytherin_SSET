namespace HausSlytherin_SSET.Aufgaben
{
    // Aufgabe 3 - Encapsulation Refactor

    /* Gegeben:
     * class Basilisk
     * {
     *      public int dangerLevel;
     * }
     */

    /* Aufgabe 3.1 - Warum ist das schlecht?
     * 
     * Verletzung der Kapselung: Das öffentliche Feld "dangerLevel" ermöglicht unkontrollierten Zugriff und Veränderung von außen, was zu unerwarteten Fehlern führen kann.
     * Keine Kontrolle über gültige Werte: Es gibt keine Mechanismen, um sicherzustellen, dass "dangerLevel" nur gültige Werte (z.B. positive Zahlen) erhält.
     * Keine Möglichkeit zur Erweiterung: Es gibt keine Möglichkeit, Logik hinzuzufügen (z.B. Validierung oder Benachrichtigungen), wenn der Wert geändert wird.
     */

    class Basilisk
    {
        // Aufgabe 3.2 - Refactor mit private Feld:
        private int dangerLevel;

        // Aufgabe 3.3 - Erstelle Getter/Setter:
        public int GetDangerLevel() => dangerLevel;

        public void SetDangerLevel(int newLevel)
        {
            // Aufgabe 3.4 - Validiere DangerLevel (1-10):
            if (newLevel < 1 || newLevel > 10)
            {
                Console.WriteLine("Danger level must be between 1 and 10.");
                return;
            }

            dangerLevel = newLevel;
            Console.WriteLine($"Danger Level set to: {dangerLevel}");
        }
    }
}
