using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people you appreciate?",
        "What are your strengths?",
        "Who did you help recently?",
        "Who are your heroes?"
    };

    private int _count = 0;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "List as many things as you can.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("Start listing...");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        _count = 0;

        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            _count++;
        }

        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }
}