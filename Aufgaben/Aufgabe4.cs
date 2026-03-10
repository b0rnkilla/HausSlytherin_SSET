namespace HausSlytherin_SSET.Aufgaben
{
    // Aufgabe 4 - Vererbung Design

    // Aufgabe 4.1 - Erstelle Basisklasse:
    public class Creature
    {
        // Aufgabe 4.2 Edfiniere gemeinsame Eigenschaften:
        public string Name { get; set; }
        public int DangerLevel { get; set; }
    }

    // Aufgabe 4.3 - Erstelle Unterklassen:
    public class Dragon : Creature
    {
        // Aufgabe 4.4 - Implementiere Polymorphie Methode:
        public void MakeSound() => Console.WriteLine("The dragon roars!");
    }
    public class Spider : Creature
    {
        public void MakeSound() => Console.WriteLine("The spider hisses!");
    }
    public class Phoenix : Creature
    {
        public void MakeSound() => Console.WriteLine("The phoenix screeches!");
    }
}
