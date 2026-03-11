namespace HausSlytherin_SSET.Aufgaben
{
    // Aufgabe 9 - Repository Pattern

    // Aufgabe 9.1 - Erstelle Interface:
    public interface ICreatureRepository
    {
        // Aufgabe 9.2 - Methoden:
        void Add(Creature creature);
        List<Creature> GetAll();
        Creature? GetByName(string name);
    }

    // Aufgabe 9.3 - Implementiere Repository:
    public class CreatureRepository : ICreatureRepository
    {
        private List<Creature> _creatures = new List<Creature>();

        public void Add(Creature creature)
        {
            _creatures.Add(creature);
        }

        public List<Creature> GetAll()
        {
            return _creatures;
        }

        public Creature? GetByName(string name)
        {
            return _creatures.FirstOrDefault(c => c.Name == name);
        }
    }

    // Aufgabe 9.4 - Verbinde Repository mit Service:
    public class CreatureServiceee
    {
        private ICreatureRepository _repository;

        public CreatureServiceee(ICreatureRepository repository)
        {
            _repository = repository;
        }

        public void AddCreature(Creature creature)
        {
            _repository.Add(creature);
        }

        public List<Creature> GetCreatures()
        {
            return _repository.GetAll();
        }
    }
}
