class Program
{
    static void Main()
    {
        Console.Write("Zadej počet hlasu pro prvniho kandidata: ");
        int hlasy1 = int.Parse(Console.ReadLine());

        Console.Write("Zadej počet hlasu pro druheho kandidata: ");
        int hlasy2 = int.Parse(Console.ReadLine());

        double procento1 = (double) hlasy1 / (hlasy1 + hlasy2);
        double procento2 = 1 - procento1;

        Console.WriteLine($"Kandidat jedna ziskal {Math.Round(procento1 * 100)}%");
        Console.WriteLine($"Kandidat dva ziskal {Math.Round(procento2 * 100)}%");
    }
}
