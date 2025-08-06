public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List as many things as you can that you're grateful for.",
        "List the people who have positively impacted your life.",
        "List your personal strengths.",
        "List moments in life that made you smile."
    };

    public ListingActivity()
    : base("Listing Activity",
           "This activity will help you focus on the positive things in your life by listing as many items as you can.",
           "You have completed the Listing Activity. Well done!")
    {
    }

    public void Run()
    {
        Console.Write("Enter the duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);

        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);

        string prompt = SelectRandomPrompt();
        Console.WriteLine($"\nList Prompt:\n>> {prompt}");
        Console.WriteLine("You will have a few seconds to think about it...");
        ShowCountDown(3);

        Console.WriteLine("Start listing! Press Enter after each item:");
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        int itemCount = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            itemCount++;
        }

        Console.WriteLine($"\nYou listed {itemCount} items!");
        DisplayEndingMessage();
        Console.WriteLine($"\nYou have completed another {GetDuration()} seconds of the Listing Activity!");
        Console.WriteLine("\nPress enter to go back to the menu...");
        Console.ReadLine();
    }

    private string SelectRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }
}
