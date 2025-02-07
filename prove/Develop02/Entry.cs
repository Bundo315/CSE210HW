
using System;

public class Entry 
{
    public string _date;
    public string _prompt;
    public string _response;

    public void MakeDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }

    public void MakePrompt()
    {
        List<string> prompts = new List<string>()
        {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        };

        Random rand = new Random();
        int random = rand.Next(prompts.Count);
        _prompt = prompts[random];
        Console.WriteLine(_prompt);
    }

    public void GetResponse()
    {
        _response = Console.ReadLine();
    }
}