using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            Random newRandom = new Random();
            int magicNumber = newRandom.Next(1, 100);

            int guess = -1;
            int attempts = 0;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                attempts++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
            }
            Console.WriteLine("Nice! You guessed it!");
            Console.WriteLine($"And the number of attempts is: {attempts}!");

            Console.Write("Would you like to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }
    }
}