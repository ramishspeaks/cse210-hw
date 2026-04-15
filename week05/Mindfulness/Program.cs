using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Choose option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity b = new BreathingActivity();
                b.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity r = new ReflectingActivity();
                r.Run();
            }
            else if (choice == "3")
            {
                ListingActivity l = new ListingActivity();
                l.Run();
            }
            else if (choice == "4")
            {
                break;
            }
        }
    }
}