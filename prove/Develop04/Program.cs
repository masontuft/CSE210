using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        bool finished = false;
        while (finished == false)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice from the menu: ");
            string userEntry = Console.ReadLine();
            switch (userEntry)
            {
                case "1":
                // Breathing activity
                    break;
                case "2":
                // reflecting activity
                    break;
                case "3":
                    // Listing Activity
                    break;
                case "4":
                    finished = true;
                    break;
                default:
                    break;
            }

        }
    }
}