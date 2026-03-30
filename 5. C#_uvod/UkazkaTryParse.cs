class Program {
    static void Main() {
        int x; 
    
        Console.Write("Zadej vstup: ");
        while (!int.TryParse(Console.ReadLine(), out x)) {
           Console.WriteLine("Spatny vstup.");
           Console.WriteLine("Ocekavame cele cislo.");
       
           Console.Write("Zadej znovu:");
        }
    
        Console.WriteLine($"Mocnina {x*x}");
    }
}

