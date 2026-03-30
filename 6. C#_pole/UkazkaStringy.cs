class Program
{
    static void Main()
    {
        Console.WriteLine("Zadej login:");
        string login = Console.ReadLine();

        // Porovnání stringu
        if (login == "admin")
        {
            Console.WriteLine("Jsi admin");
        } else
        {
            Console.WriteLine("Nejsi admin");
        }

        // Délka stringu
        int delka = login.Length;
        Console.WriteLine($"Tvuj login ma {delka} znaku");

        // Průchod stringem
        Console.WriteLine();
        Console.WriteLine("Znaky loginu:");
        foreach (char znak in login)
        {
            Console.WriteLine($"  {znak}");
        }

        // Převod na velká písmena:
        login = login.ToUpper();

        // Převod na malá písmena:
        login = login.ToLower();

        // Kopie stringu:
        string kopie = new string(login);

        // Obsahuje string jiny string:
        if (login.Contains("ass"))
        {
            Console.WriteLine("V loginu nesmí být sprosta slova");
        }

    }
}
