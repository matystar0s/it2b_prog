class Program
{

    static void Main()
    {

        double[] pole = new double[10];

        Console.WriteLine("Zadej 10 cisel na samostatne radky:");
        for (int i = 0; i < pole.Length; i++)
        {
            pole[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Maximum: {pole.Max()}");

        double rozdil = pole.Max() - pole.Min();
        Console.WriteLine($"Rozdil max a min: {rozdil}");

        Array.Sort( pole );
        for (int i = 0; i < 3; i++)
            Console.WriteLine($"{i + 1}. nejnizsi hodnota: {pole[i]}");

        double median = (pole[4] + pole[5]) / 2;
        Console.WriteLine($"median: {median}");

        // vypis serazeneho pole:
        Console.WriteLine("Searazene prvky pole:");
        foreach (double cislo in pole) {
            Console.WriteLine($"   {cislo}");
        }
    }
}
