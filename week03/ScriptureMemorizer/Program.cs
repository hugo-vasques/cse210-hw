using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart and lean not unto thine own understanding."
        ));
        scriptures.Add(new Scripture(
            new Reference("Joshua", 1, 9),
            "Have I not commanded you? Be strong and courageous. Do not be afraid; do not be discouraged, for the Lord your God will be with you wherever you go."
        ));
        scriptures.Add(new Scripture(
            new Reference("Philippians", 4, 13),
            "I can do all things through Christ who strengthens me."
        ));
        scriptures.Add(new Scripture(
            new Reference("Psalm", 23, 1),
            "The Lord is my shepherd; I shall not want."
        ));
        scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."
        ));

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine("\nHi there and welcome to the amazing SCRIPTURE MEMORIZER!");
            Console.WriteLine("\nTo continue, press ENTER to wide words or type 'q' to exit.");
            Console.WriteLine();
            Console.WriteLine(scripture.GetDisplayText());

            string input = Console.ReadLine();

            if (input == "q")
                break;

            scripture.HideRandomWords(2);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll the words are hidden!");
                break;
            }
        }
    }
}