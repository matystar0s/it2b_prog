class Program
{

    static int PocetAnomalii(int[] pole)
    {
        int pocet = 0;

        for (int i = 1; i < pole.Length-1; i++)
        {
            int min = pole[i-1];
            int bud = pole[i+1];

            if ((pole[i] < min && pole[i] < bud) || (pole[i] > min && pole[i] > bud)) {
                pocet++;
            }
        }

        return pocet;
    }


    static void Main()
    {

        int[] pole = new int[8];
        Console.WriteLine("Zadej prvky pole:");
        for (int i = 0; i < pole.Length; i++)
            pole[i] =  int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine($"Pocet anomalii:: {PocetAnomalii(pole)}");
    }
}

