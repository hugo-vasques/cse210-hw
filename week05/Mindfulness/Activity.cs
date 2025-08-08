public class Activity
{
    private string _name;
    private int _duration;
    
    private string _description;
    private string _startingMessage;
    private string _endingMessage;

    public void SetDuration(int seconds)
    {
        _duration = seconds;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetStartingMessage(string message)
    {
        _startingMessage = message;
    }

    public void SetEndingMessage(string message)
    {
        _endingMessage = message;
    }

    public void DisplayDescription()
    {
        Console.WriteLine(_description);
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\n--- {_name} ---\n");
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {_duration} seconds\n");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\n--- {_endingMessage} ---");
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(250);
            Console.Write("\b");
            index = (index + 1) % spinner.Length;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public Activity(string name, string description, string endingMessage)
    {
        _name = name;
        _description = description;
        _endingMessage = endingMessage;
    }

    public string GetName()
    {
        return _name;
    }
}