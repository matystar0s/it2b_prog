class Program
{
    static int SoucetCifer(int n)
    {
        int cifra;
        int soucet = 0;
        while (n > 0)
        {
            cifra = n % 10;
            soucet += cifra;

            n /= 10;
        }

        return soucet;
    }

    static void Main()
    {
        int n = 1499;
        Console.WriteLine($"Součet cifer {n}: {SoucetCifer(n)}");
    }
}
