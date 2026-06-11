namespace CichnamonArena
{
    class Attack
    {
        public string Name { get; private set; }
        public int Damage { get; private set; }
        public string Description { get; private set; }

        public Attack(string name, int damage, string description)
        {
            Name = name;
            Damage = damage;
            Description = description;
        }

        public int GetDamage()
        {
            return Damage;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"  {Name} (damage: {Damage}) - {Description}");
        }
    }
}
