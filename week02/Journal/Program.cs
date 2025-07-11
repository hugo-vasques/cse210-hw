using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\nYour Digital Journal");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("Please select one of the following choices: ");

            choice = Console.ReadLine();

            Console.WriteLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"{prompt}");
                string content = Console.ReadLine();

                Entry entry = new Entry(content, prompt);
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                Console.WriteLine("Journal Entries");
                journal.DisplayJournal();
            }
            else if (choice == "3")
            {
                Console.Write("Please set the name of this file to save it: ");
                string filename = Console.ReadLine();
                journal.Save(filename);
                Console.WriteLine("Journal saved succesfully!");
            }
            else if (choice == "4")
            {
                Console.WriteLine("Name of the file that you want to load: ");
                string filename = Console.ReadLine();
                journal.Load(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Bye bye, hope you have a great day!");
            }
            else
            {
                Console.WriteLine("Invalid option. Try again please");
            }
        }
    }
}