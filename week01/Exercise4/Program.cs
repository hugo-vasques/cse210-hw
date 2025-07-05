using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int entry = -1;

        Console.WriteLine("Please, enter a list  of numbers, type 0 to quit");

        while (entry != 0)
        {
            Console.WriteLine("Enter number: ");
            string input = Console.ReadLine();
            entry = int.Parse(input);

            if (entry != 0)
            {
                numbers.Add(entry);
            }
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"\nThe sum is: {sum} ");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}