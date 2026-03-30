public class Program
{
    static void Main()
    {
        // napln prazdne pole:
        int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i;
        }

        // tvorba pole:
        int[] temperatures = {-5, -2, 3, -1, 8};

        // delka:
        Console.WriteLine(temperatures.Length);

        // razeni pole:
        Array.Sort(temperatures);
        // otočení pole:
        Array.Reverse(temperatures);

        // min/max:
        int max = temperatures.Max();
        int min = temperatures.Min();

        // vypsani a cykleni:
        foreach (int temp in temperatures) {
            Console.WriteLine(temp);
        }

    }
}
