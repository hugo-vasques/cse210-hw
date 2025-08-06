public class ReflectionActivity : Activity
{
    private List<string> _reflectionPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "How did you feel when it was complete?",
        "What is your favorite thing about this experience?",
        "What did you learn from this moment?",
        "How can you apply this lesson in the future?"
    };

    public ReflectionActivity()
        : base("Reflection Activity",
               "This activity will help you reflect on times in your life when you have shown strength and resilience.",
               "Well done on completing your reflection.")
    {
    }

    public void Run()
    {
        Console.Write("Enter the duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);

        Console.Clear();
        DisplayStartingMessage();

        Random rand = new Random();
        string prompt = _reflectionPrompts[rand.Next(_reflectionPrompts.Count)];

        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {prompt} ---\n");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        ShowSpinner(3);
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        int i = 0;

        while (DateTime.Now < endTime && i < _questions.Count)
        {
            Console.WriteLine($"> {_questions[i]}");
            ShowSpinner(5);
            Console.WriteLine();
            i++;
        }

        DisplayEndingMessage();
        Console.WriteLine($"\nYou have completed another {GetDuration()} seconds of the Reflection Activity!");
        Console.WriteLine("\nPress enter to go back to the menu...");
        Console.ReadLine();
    }
}
