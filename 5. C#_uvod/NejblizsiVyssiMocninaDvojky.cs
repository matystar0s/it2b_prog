class Program
{
    static void Main()
    {
        Console.Write("zadej cislo: ");
        int n = int.Parse(Console.ReadLine());

        int mocnina = 1;

        while (mocnina < n)
        {
            //Console.WriteLine(mocnina);
            mocnina *= 2;
        }

        Console.WriteLine($"Nejblizsi vyssi mocnina 2 je {mocnina}");
    }
}
