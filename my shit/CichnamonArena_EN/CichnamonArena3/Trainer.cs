namespace CichnamonArena
{
    class Trainer
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public List<Cichnamon> Cichnamons { get; private set; }
        public Cichnamon? ActiveCichnamon { get; private set; }

        public Trainer(string name)
        {
            Name = name;
            Level = 1;
            Cichnamons = new List<Cichnamon>();
        }

        public void AddCichnamon(Cichnamon c)
        {
            Cichnamons.Add(c);
        }

        public void SelectCichnamon(int index)
        {
            ActiveCichnamon = Cichnamons[index];
        }

        public void LevelUp()
        {
            Level++;
        }
    }
}
