class Program
{
    static void Main()
    {
        Console.Write("Zadej prvni znak: ");
        char znak1 = Console.ReadLine()[0];

        Console.Write("Zadej druhy znak: ");
        char znak2 = Console.ReadLine()[0];

        Console.WriteLine($"{znak1}{znak2}{znak1}");
        Console.WriteLine($"{znak2}{znak1}{znak2}");
        Console.WriteLine($"{znak1}{znak2}{znak1}");

    }
}
