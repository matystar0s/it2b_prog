class Program
    {
    static void Main()
        {
        string[] otazky = 
        {
            "Lze změnit délku pole po jeho vytvoření?",
            "Indexace prvků stringu začíná vždy od 0.",
            "Vlastnost Length vrací délku pole.",
            "Indexováním mohu měnit jednotlivé znaky stringu.",
            "Datový typ string se v češtině řekne \"provaz\".",
            "Cyklus foreach lze použít pro průchod polem či stringem.",
            "Pole lze seřadit pomocí Array.Sort().",
            "Lze porovnávat stringy pomocí == ?",
            "Pole může obsahovat více datových typů najednou.",
            "Datový typ pole se v angličtině řekne \"meadow\"."
        };

        char[] odpovedi =
        {
            'N',
            'A',
            'A',
            'N',
            'N',
            'A',
            'A',
            'A',
            'N', 
            'N' 
        };

        int spravne = 0;


        Console.WriteLine("Dám ti 10 otázek na pole a stringy v C#.");
        Console.WriteLine("Odpovídej POUZE pomocí [A]no, [N]e.");
            
        for (int i = 0; i < otazky.Length; i++)
        {
            Console.WriteLine();
            Console.WriteLine(i + ") " + otazky[i]);
                
            Console.Write("Tvoje odpověď: ");
            char vstup = Char.ToUpper(Console.ReadLine()[0]);
            Console.WriteLine();

            if (vstup == odpovedi[i])
            {
                Console.WriteLine("Správně! Máš malé bezvýznamné plus.");
                spravne++;
            }
            else                {
                Console.WriteLine("Špatně! Bodík je fuč :(");
            }

            Console.WriteLine();
        }

        Console.WriteLine($"Výsledek: {spravne} / {otazky.Length}");
        if (spravne < otazky.Length/2)
            Console.WriteLine("Ani půlku otázek nemáš správně. Jak :(((");
        else if (spravne < otazky.Length - 2)
            Console.WriteLine("Něco málo ses naučil.");
        else if (spravne < otazky.Length)
            Console.WriteLine("Skvělý výsledek!");
        else
            Console.WriteLine("Gratuluju k plnému počtu bodů!");
    }
}
