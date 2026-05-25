
class Program
{
    static void Main()
    {
















        Console.WriteLine("Welcome to Cichnamon Arena!");
        Console.Write("Enter your trainer name: ");
        string playerName = Console.ReadLine();
        Trainer player = new Trainer(playerName);

        Trainer computer = new Trainer("Computer");

        Attack fireball = new Attack("Fireball", 15, "A fiery blast");
        Attack flamethrower = new Attack("Flamethrower", 25, "A powerful flame attack");
        Attack waterSplash = new Attack("Water Splash", 12, "A splash of water");
        Attack hydroBlast = new Attack("Hydro Blast", 20, "A strong water attack");
        Attack grassWhip = new Attack("Grass Whip", 10, "A whip of grass");
        Attack solarBeam = new Attack("Solar Beam", 22, "A concentrated solar attack");

        Cichnamon fireCichnamon = new Cichnamon("Flamio", 100, 5, fireball, flamethrower);
        Cichnamon waterCichnamon = new Cichnamon("Aqua", 100, 4, waterSplash, hydroBlast);
        Cichnamon grassCichnamon = new Cichnamon("Leafy", 100, 3, grassWhip, solarBeam);

        player.AddCichnamon(fireCichnamon);
        player.AddCichnamon(waterCichnamon);
        player.AddCichnamon(grassCichnamon);

        computer.AddCichnamon(new Cichnamon("Shadow", 100, 4, fireball, hydroBlast));

        Console.WriteLine("Choose your Cichnamon:");
        for (int i = 0; i < player.Cichnamons.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {player.Cichnamons[i].Name}");
        }
        int choice = int.Parse(Console.ReadLine()) - 1;
        player.ChooseActiveCichnamon(choice);

        computer.ChooseActiveCichnamon(0);

        while (player.ActiveCichnamon.IsAlive() && computer.ActiveCichnamon.IsAlive())
        {
            Console.WriteLine("--- YOUR TURN ---");
            Console.WriteLine("1 - Basic Attack");
            Console.WriteLine("2 - Special Attack");
            Console.WriteLine("3 - Heal");
            int action = int.Parse(Console.ReadLine());
            switch (action)
            {
                case 1:
                    player.ActiveCichnamon.PerformBasicAttack(computer.ActiveCichnamon);
                    break;
                case 2:
                    player.ActiveCichnamon.PerformSpecialAttack(computer.ActiveCichnamon);
                    break;
                case 3:
                    player.ActiveCichnamon.Heal(20);
                    Console.WriteLine($"{player.ActiveCichnamon.Name} healed 20 health.");
                    break;
            }

            if (!computer.ActiveCichnamon.IsAlive()) break;


            Console.WriteLine("--- COMPUTER TURN ---");
            computer.turn(player.ActiveCichnamon);
        }

        if (player.ActiveCichnamon.IsAlive())
        {
            Console.WriteLine($"{player.ActiveCichnamon.Name} won!");
        }
        else
        {
            Console.WriteLine($"{computer.ActiveCichnamon.Name} won!");
        }
    }
}