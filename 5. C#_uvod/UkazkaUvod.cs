class Program
{
    static void Main()
    {
        Console.Write("Zadej cislo: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Zadej cislo: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Soucet: {a + b}");
    }
}


