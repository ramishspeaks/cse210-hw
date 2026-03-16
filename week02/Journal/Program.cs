using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        string prompt = promptGen.GetRandomPrompt();

        Entry entry = new Entry();
        entry._date = DateTime.Now.ToShortDateString();
        entry._promptText = prompt;

        Console.WriteLine(prompt);
        entry._entryText = Console.ReadLine();

        myJournal.AddEntry(entry);

        myJournal.DisplayAll();
    }
}