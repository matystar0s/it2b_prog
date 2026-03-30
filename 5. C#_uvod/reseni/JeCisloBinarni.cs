class Program
{
    static bool JeBinarni(int cislo)
    {
        int cislovka;
        while (cislo > 0)
        {
            cislovka = cislo % 10;
            if (!(cislovka == 0 || cislovka == 1))
            {
                return false;
            }
            cislo /= 10;
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Zadej cislo: ");
        int vstup = int.Parse(Console.ReadLine());

        Console.Write($"Vystup: {JeBinarni(vstup)}");
    }
}
