using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Vytvoření listu:
        List<int> numbers = new List<int> { 5, 2, 8, 2, 10 };
        // prázdný: List<int> numbers = new List<int>;

        // Přidání prvků:
        numbers.Add(15);
        numbers.Add(3);

        // Přístup přes index:
        Console.WriteLine("Prvek na indexu 2: " + numbers[2]);

        // Počet prvků:
        Console.WriteLine("Počet prvků: " + numbers.Count);

        // Obsahuje prvek?
        Console.WriteLine("Obsahuje 8? " + numbers.Contains(8));

        // Odebrání prvku (první výskyt):
        numbers.Remove(2);

        // Odebrání podle indexu:
        numbers.RemoveAt(0);

        // Seřazení:
        numbers.Sort();

        // Otočení:
        numbers.Reverse();

        // Výpis listu:
        foreach (int x in numbers)
        {
            Console.Write(x + " ");
        }
      
        // Vyčištění listu:
        numbers.Clear();

        Console.WriteLine("Po Clear(): " + numbers.Count);
    }
}
