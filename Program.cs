using HausSlytherin_SSET.Aufgaben;

namespace HausSlytherin_SSET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aufgabe 5.4 - Nutze Interface in Liste
            List<IRateable> creatures = new List<IRateable>();
            creatures.Add(new Dragon("Norbert", 9));
            creatures.Add(new Spider("Aragog", 10));

            // Aufgabe 10.1 - Berechne Durchschnitt DangerLevel:
            List<Creature> creatureList = new List<Creature>
            {
                new Creature("Norbert", 9),
                new Creature("Aragog", 10)
            };
            double averageDangerLevel = creatureList.Average(c => c.DangerLevel);
            Console.WriteLine($"Average Danger Level: {averageDangerLevel}");

            // Aufgabe 10.2 - Finde gefährlichste Kreatur:
            Creature mostDangerous = creatureList.OrderByDescending(c => c.DangerLevel).First();
            Console.WriteLine($"Most Dangerous Creature: {mostDangerous.Name} with Danger Level {mostDangerous.DangerLevel}");

            // Aufgabe 10.3 - Filter DangerLevel > 7:
            var dangerousCreatures = creatureList.Where(c => c.DangerLevel > 7);

            // Aufgabe 10.4 - Sortiere nach Name:
            var sortedByName = creatureList.OrderBy(c => c.Name);
            
            


            Console.ReadKey();
        }
    }
}
