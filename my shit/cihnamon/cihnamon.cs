public class Cichnamon
{
    public string Name { get; set; }
    public int CurrentHealth { get; set; }
    public int MaxHealth { get; set; }
    public int AttackBonus { get; set; }
    public Attack BasicAttack { get; set; }
    public Attack SpecialAttack { get; set; }

    public Cichnamon(string name, int maxHealth, int attackBonus, Attack basicAttack, Attack specialAttack)
    {
        Name = name;
        MaxHealth = maxHealth;
        CurrentHealth = maxHealth;
        AttackBonus = attackBonus;
        BasicAttack = basicAttack;
        SpecialAttack = specialAttack;
    }

    public void PerformBasicAttack(Cichnamon target)
    {
        int damage = BasicAttack.GetDamage() + AttackBonus;
        target.TakeDamage(damage);
        Console.WriteLine($"{Name} used {BasicAttack.Name}! {target.Name} took {damage} damage.");
    }

    public void PerformSpecialAttack(Cichnamon target)
    {
        int damage = SpecialAttack.GetDamage() + AttackBonus;
        target.TakeDamage(damage);
        Console.WriteLine($"{Name} used {SpecialAttack.Name}! {target.Name} took {damage} damage.");
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

    public bool IsAlive()
    {
        return CurrentHealth > 0;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Name} - Health: {CurrentHealth}/{MaxHealth}, Attack Bonus: {AttackBonus}");
        Console.WriteLine("Basic Attack:");
        BasicAttack.PrintInfo();
        Console.WriteLine("Special Attack:");
        SpecialAttack.PrintInfo();
    }
}