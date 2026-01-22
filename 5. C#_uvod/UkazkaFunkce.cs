class Program
{
    static int Secti(int a, int b)
    {
        return a + b;
    }

    static double Vydel(double x, double y)
    {
        if (y == 0)
        {
            Console.WriteLine("Chyba! Dìlení nulou.");
            return 0;
        }

        return (double) x / y;  // nutno pøetypovat
    }
    
    static void Main()
    {
        // todo: pøidej volání funkcí
    }
}


