using CichnamonArena;

Random rnd = new Random();

Console.WriteLine("Welcome to Cichnamon Arena!");
Console.Write("Enter your name: ");
string playerName = Console.ReadLine() ?? "Trainer";

Console.Write("Enter the opponent's name: ");
string opponentName = Console.ReadLine() ?? "Evil Trainer";

Trainer player   = new Trainer(playerName);
Trainer computer = new Trainer(opponentName);

Cichnamon oldrich = new Cichnamon("Ondrej Pekelny", 100, 5,
    new Attack("FlameyBoy",      10, "Ondrej is so hot that he burns the enemy."),
    new Attack("Flamethrower", 22, "Ondrej´s private scorching stream of fire burns everything!"));

Cichnamon vojtech = new Cichnamon("Vojtech Plavcik", 110, 3,
    new Attack("Splash",    9,  "Vojtech splashes his liquid."),
    new Attack("Liquid Cannon", 20, "A powerful current of lqiuid blasts the opponent!"));

Cichnamon tonda = new Cichnamon("Tonda Travickar", 120, 2,
    new Attack("Weed Toss",     8,  "Tonda throws a pile of weed in the opponent's face to make them high."),
    new Attack("Poison Cloud", 19, "A thick smoke poisons the opponent!"));

Console.WriteLine("\nChoose your Cichnamon:");
Console.WriteLine("1 - Ondrej Pekelny");
oldrich.PrintInfo();
Console.WriteLine("2 - Vojtech Plavcik");
vojtech.PrintInfo();
Console.WriteLine("3 - Tonda Travickar");
tonda.PrintInfo();

int choice = GetChoice(1, 3);
Cichnamon playerC = choice == 1 ? oldrich : choice == 2 ? vojtech : tonda;
player.AddCichnamon(playerC);
player.SelectCichnamon(0);
Console.WriteLine($"\nYou chose: {playerC.Name}");

Cichnamon villain = new Cichnamon("Darkfang", 95, 4,
    new Attack("Scratch",   10, "Darkfang slashes with sharp claws."),
    new Attack("Dark Wave", 20, "A mysterious dark energy strikes the opponent!"));

computer.AddCichnamon(villain);
computer.SelectCichnamon(0);
Console.WriteLine($"Your opponent is: {villain.Name}");

Cichnamon myC  = player.ActiveCichnamon!;
Cichnamon oppC = computer.ActiveCichnamon!;

bool specialUsed = false;
bool healUsed    = false;
int  turn        = 1;

while (myC.IsAlive() && oppC.IsAlive())
{
    Console.WriteLine($"\n--- YOUR TURN ---");
    Console.WriteLine($"  {myC.Name}: {myC.CurrentHealth} HP");
    Console.WriteLine($"  {oppC.Name}: {oppC.CurrentHealth} HP");
    Console.WriteLine();

    Console.WriteLine($"1 - Basic attack: {myC.BasicAttack.Name}");

    bool canSpecial = !specialUsed || turn % 2 == 0;
    Console.WriteLine(canSpecial
        ? $"2 - Special attack: {myC.SpecialAttack.Name}"
        : $"2 - Special attack: {myC.SpecialAttack.Name} (not available yet)");

    Console.WriteLine(healUsed
        ? "3 - Heal (already used)"
        : "3 - Heal (+20 HP)");

    int action = GetChoice(1, 3);

    if (action == 1)
    {
        myC.UseBasicAttack(oppC);
    }
    else if (action == 2)
    {
        if (canSpecial)
        {
            myC.UseSpecialAttack(oppC);
            specialUsed = true;
        }
        else
        {
            Console.WriteLine("Special attack not available yet! Using basic attack instead.");
            myC.UseBasicAttack(oppC);
        }
    }
    else
    {
        if (!healUsed)
        {
            myC.Heal(20);
            healUsed = true;
            Console.WriteLine($"{myC.Name} healed for 20 HP! Health: {myC.CurrentHealth}/{myC.MaxHealth}");
        }
        else
        {
            Console.WriteLine("Heal already used! Using basic attack instead.");
            myC.UseBasicAttack(oppC);
        }
    }

    if (!oppC.IsAlive()) break;

    Console.WriteLine($"\n--- OPPONENT'S TURN ---");
    if (turn % 2 == 0)
        oppC.UseSpecialAttack(myC);
    else
        oppC.UseBasicAttack(myC);

    turn++;
    Console.WriteLine("\nPress Enter to continue...");
    Console.ReadLine();
}

Console.WriteLine();
if (myC.IsAlive())
{
    Console.WriteLine($"YOU WIN! {myC.Name} is victorious!");
    player.LevelUp();
    Console.WriteLine($"{player.Name} reached level {player.Level}!");

    Console.WriteLine("\nChoose a reward for your Cichnamon:");
    Console.WriteLine("1 - Increase max health (+15 HP)");
    Console.WriteLine("2 - Increase attack bonus (+3)");
    int reward = GetChoice(1, 2);
    if (reward == 1)
    {
        myC.Heal(15);
        Console.WriteLine($"{myC.Name} now has {myC.CurrentHealth}/{myC.MaxHealth} HP.");
    }
    else
    {
        Console.WriteLine($"{myC.Name} has become stronger!");
    }
}
else
{
    Console.WriteLine($"YOU LOSE! {oppC.Name} wins.");
}

Console.WriteLine("\nYour Cichnamon's final status:");
myC.PrintInfo();

Console.WriteLine("\nThanks for playing!");

static int GetChoice(int min, int max)
{
    while (true)
    {
        Console.Write("Your choice: ");
        if (int.TryParse(Console.ReadLine(), out int v) && v >= min && v <= max)
            return v;
        Console.WriteLine($"Invalid input. Enter a number between {min} and {max}.");
    }
}
