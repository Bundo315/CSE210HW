
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
        "Who was the coolest person I met today?",
        "What was the best part of my day?",
        "How did my calculus go today?",
        "How did my classes go?",
        "What did i make for dinner?",
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