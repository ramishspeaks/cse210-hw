using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video();
        v1._title = "C# Basics";
        v1._author = "Ramish";
        v1._length = 300;

        v1._comments.Add(new Comment("Ali", "Good video"));
        v1._comments.Add(new Comment("Sara", "Nice explanation"));
        v1._comments.Add(new Comment("John", "Helpful"));

        videos.Add(v1);

        Video v2 = new Video();
        v2._title = "Loops in C#";
        v2._author = "Ahmed";
        v2._length = 400;

        v2._comments.Add(new Comment("Usman", "Great"));
        v2._comments.Add(new Comment("Zara", "Easy to understand"));
        v2._comments.Add(new Comment("David", "Thanks"));

        videos.Add(v2);

        Video v3 = new Video();
        v3._title = "OOP Concepts";
        v3._author = "Ali";
        v3._length = 500;

        v3._comments.Add(new Comment("Hamza", "Awesome"));
        v3._comments.Add(new Comment("Ayesha", "Clear concept"));
        v3._comments.Add(new Comment("Mike", "Loved it"));

        videos.Add(v3);

        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v._title}");
            Console.WriteLine($"Author: {v._author}");
            Console.WriteLine($"Length: {v._length} seconds");
            Console.WriteLine($"Number of comments: {v.GetCommentCount()}");

            foreach (Comment c in v._comments)
            {
                Console.WriteLine($"{c._name}: {c._text}");
            }

            Console.WriteLine("----------------------");
        }
    }
}