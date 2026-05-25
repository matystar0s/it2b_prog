public class Attack
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public string Description { get; set; }

    public Attack(string name, int damage, string description)
    {
        Name = name;
        Damage = damage;
        Description = description;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"{Name}: {Description} (Damage: {Damage})");
    }

    public int GetDamage()
    {
        return Damage;
    }
}