public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity",
               "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.",
               "You did a great job with your breathing. Keep it up!")
    {
    }

    public void Run()
    {
        Console.Write("Enter the duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);

        Console.Clear();
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(3);
            Console.WriteLine();

            Console.Write("Now breathe out... ");
            ShowCountDown(3);
            Console.WriteLine();
            Console.WriteLine();
        }

        DisplayEndingMessage();
        Console.WriteLine($"\nYou have completed another {GetDuration()} seconds of the Breathing Activity!");
        Console.WriteLine("\nPress Enter to go back to the menu...");
        Console.ReadLine();
    }
}