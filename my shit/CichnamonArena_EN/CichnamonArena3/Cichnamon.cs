namespace CichnamonArena
{
    class Cichnamon
    {
        public string Name { get; private set; }
        public int CurrentHealth { get; private set; }
        public int MaxHealth { get; private set; }
        public int AttackBonus { get; private set; }
        public Attack BasicAttack { get; private set; }
        public Attack SpecialAttack { get; private set; }

        public Cichnamon(string name, int maxHealth, int attackBonus, Attack basicAttack, Attack specialAttack)
        {
            Name = name;
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
            AttackBonus = attackBonus;
            BasicAttack = basicAttack;
            SpecialAttack = specialAttack;
        }

        public bool IsAlive()
        {
            return CurrentHealth > 0;
        }

        public void TakeDamage(int damage)
        {
            CurrentHealth -= damage;
            if (CurrentHealth < 0) CurrentHealth = 0;
        }

        public void Heal(int amount)
        {
            CurrentHealth += amount;
            if (CurrentHealth > MaxHealth) CurrentHealth = MaxHealth;
        }

        public void UseBasicAttack(Cichnamon target)
        {
            int damage = BasicAttack.GetDamage() + AttackBonus;
            Console.WriteLine($"{Name} used {BasicAttack.Name}!");
            Console.WriteLine($"{BasicAttack.Description}");
            target.TakeDamage(damage);
            Console.WriteLine($"{target.Name} took {damage} damage.");
        }

        public void UseSpecialAttack(Cichnamon target)
        {
            int damage = SpecialAttack.GetDamage() + AttackBonus;
            Console.WriteLine($"{Name} used {SpecialAttack.Name}!");
            Console.WriteLine($"{SpecialAttack.Description}");
            target.TakeDamage(damage);
            Console.WriteLine($"{target.Name} took {damage} damage.");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"=== {Name} ===");
            Console.WriteLine($"  Health: {CurrentHealth}/{MaxHealth}");
            Console.WriteLine($"  Attack bonus: +{AttackBonus}");
            Console.Write("  Basic attack:   "); BasicAttack.PrintInfo();
            Console.Write("  Special attack: "); SpecialAttack.PrintInfo();
        }
    }
}
