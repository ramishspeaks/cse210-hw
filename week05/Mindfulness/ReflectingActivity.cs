using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you helped someone.",
        "Think of a time you did something difficult.",
        "Think of a time you were strong."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was it meaningful?",
        "How did you feel?",
        "What did you learn?",
        "What made it special?"
    };

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "Reflect on meaningful experiences.";
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine(prompt);
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine(question);
            ShowSpinner(3);
        }

        DisplayEndingMessage();
    }
}