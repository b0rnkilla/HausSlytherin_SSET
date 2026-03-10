namespace HausSlytherin_SSET.Aufgaben
{
    // Aufgabe 4 - Vererbung Design

    // Aufgabe 4.1 - Erstelle Basisklasse:
    public class Creature
    {
        // Aufgabe 4.2 Edfiniere gemeinsame Eigenschaften:
        public string Name { get; set; } = string.Empty;
        public int DangerLevel { get; set; }
    }

    // Aufgabe 4.3 - Erstelle Unterklassen:
    public class Dragon : Creature , IRateable // <-- Aufgabe 5.3
    {
        // Aufgabe 4.4 - Implementiere Polymorphie Methode:
        public void MakeSound() => Console.WriteLine("The dragon roars!");

        // Aufgabe 5.3:
        public int GetDangerLevel() => DangerLevel;
        public bool IsForbidden() => DangerLevel > 5;
    }
    public class Spider : Creature , IRateable // Aufgabe 5.3
    {
        public void MakeSound() => Console.WriteLine("The spider hisses!");
        
        // Aufgabe 5.3:
        public int GetDangerLevel() => DangerLevel;
        public bool IsForbidden() => DangerLevel > 5;
    }
    public class Phoenix : Creature
    {
        public void MakeSound() => Console.WriteLine("The phoenix screeches!");
    }
}
