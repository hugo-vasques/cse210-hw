using System;

public class Entry
{
    public string _date;
    public string _content;
    public string _prompt;

    public Entry(string content, string prompt)
    {
        _content = content;
        _prompt = prompt;
        _date = DateTime.Now.ToString("yyyy-MM-dd");
    }

    public string ToFileString()
    {
        return $"{_date}|{_prompt}|{_content}";
    }
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Answer: {_content}");
        Console.WriteLine();
    }
}