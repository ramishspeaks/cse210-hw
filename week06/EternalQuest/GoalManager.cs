using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        while (true)
        {
            Console.WriteLine($"\nScore: {_score}");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");

            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            if (choice == "1") CreateGoal();
            else if (choice == "2") ListGoals();
            else if (choice == "3") RecordEvent();
            else if (choice == "4") SaveGoals();
            else if (choice == "5") LoadGoals();
            else if (choice == "6") break;
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == "2")
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    private void ListGoals()
    {
        int i = 1;
        foreach (Goal g in _goals)
        {
            string status = g.IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i}. {status} {g.GetDetailsString()}");
            i++;
        }
    }

    private void RecordEvent()
    {
        ListGoals();

        Console.Write("Select goal: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int earned = _goals[index].RecordEvent();
        _score += earned;

        Console.WriteLine($"You earned {earned} points!");
    }

    private void SaveGoals()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);

            foreach (Goal g in _goals)
            {
                output.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    private void LoadGoals()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");

            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal g = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(g);
            }
            else if (parts[0] == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal g = new ChecklistGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[5]),
                    int.Parse(parts[6])
                );
                _goals.Add(g);
            }
        }
    }
}