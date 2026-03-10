using HausSlytherin_SSET.Aufgaben;

namespace HausSlytherin_SSET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aufgabe 5.4:
            List<IRateable> creatures = new List<IRateable>();
            creatures.Add(new Dragon());
            creatures.Add(new Spider());
        }
    }
}
