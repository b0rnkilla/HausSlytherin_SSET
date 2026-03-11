namespace HausSlytherin_SSET.Aufgaben
{
    // Aufgabe 4 - Vererbung Design

    // Aufgabe 4.1 - Erstelle Basisklasse:
    public class Creature
    {
        // Aufgabe 4.2 Edfiniere gemeinsame Eigenschaften:
        public string Name { get; set; } = string.Empty;
        public int DangerLevel { get; set; }


        // Konstruktor wurde für Aufgabe 10 benötigt und hinzugefügt:
        public Creature(string name, int dangerLevel)
        {
            Name = name;
            DangerLevel = dangerLevel;
        }
    }


    // Aufgabe 4.3 - Erstelle Unterklassen:
    public class Dragon : Creature , IRateable // <-- Aufgabe 5.3
    {
        // Konstruktor wurde für Aufgabe 10 benötigt und hinzugefügt:
        public Dragon(string name, int dangerLevel) : base(name, dangerLevel) { }


        // Aufgabe 4.4 - Implementiere Polymorphie Methode:
        public void MakeSound() => Console.WriteLine("The dragon roars!");

        // Aufgabe 5.3:
        public int GetDangerLevel() => DangerLevel;
        public bool IsForbidden() => DangerLevel > 5;
    }


    public class Spider : Creature , IRateable // Aufgabe 5.3
    {
        // Konstruktor wurde für Aufgabe 10 benötigt und hinzugefügt:
        public Spider(string name, int dangerLevel) : base(name, dangerLevel) { }


        public void MakeSound() => Console.WriteLine("The spider hisses!");
        
        // Aufgabe 5.3:
        public int GetDangerLevel() => DangerLevel;
        public bool IsForbidden() => DangerLevel > 5;
    }


    public class Phoenix : Creature
    {
        // Konstruktor wurde für Aufgabe 10 benötigt und hinzugefügt:
        public Phoenix(string name, int dangerLevel) : base(name, dangerLevel) { }


        public void MakeSound() => Console.WriteLine("The phoenix screeches!");
    }
}
