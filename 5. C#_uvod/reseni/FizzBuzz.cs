class Program
{
    static void Main()
    {
        Console.Write("Zadej kladne cislo: ");
        int limit = int.Parse(Console.ReadLine());

        for (int i = 1; i <= limit; i++)
        {
            if (i % 3 == 0) 
                Console.Write("Fizz");
            else if (i % 5 == 0)
                Console.Write("Buzz");
            else
                Console.Write($"cislo: {i} {1+1} {limit}");
            Console.WriteLine();
        }
    }
}
