using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video();
        v1._title = "Learn C#";
        v1._author = "Ramish";
        v1._length = 300;

        v1._comments.Add(new Comment("Ali", "Nice video"));
        v1._comments.Add(new Comment("Sara", "Very helpful"));
        v1._comments.Add(new Comment("John", "Good work"));

        List<Video> videos = new List<Video>();
        videos.Add(v1);

        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v._title}");
            Console.WriteLine($"Author: {v._author}");
            Console.WriteLine($"Length: {v._length}");
            Console.WriteLine($"Comments: {v.GetCommentCount()}");

            foreach (Comment c in v._comments)
            {
                Console.WriteLine($"{c._name}: {c._text}");
            }

            Console.WriteLine();
        }
    }
}