using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hi there pal :) please enter a number from 50 to 100 to proceed: ");
        string userValue = Console.ReadLine();
        int x = int.Parse(userValue);

        string letter = "";

        if (x >= 90)
        {
            letter = "A";
        }
        else if (x >= 80)
        {
            letter = "B";
        }
        else if (x >= 70)
        {
            letter = "C";
        }
        else if (x >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (x >= 70)
        {
            Console.WriteLine("Congrats! You passed!");
        }
        else
        {
            Console.WriteLine("Ooof, you didn't make it, better luck next time!");
        }
    }
}