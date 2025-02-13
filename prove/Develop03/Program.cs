using System;

class Program
{
    

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        Scripture scripture = new Scripture();
        string scripRef = "D & C 66:6";
        string text = "Tarry not many days in this place; go not up unto the land " + 
        "of Zion as yet; but inasmuch as you can send, send; otherwise, think not " + 
        "of thy property.";
        Scripture script1 = new Scripture(text);
        Console.Clear();
        // Console.WriteLine("The screen is now clear!");
        bool running = true;
        while (running)
        {
            Console.WriteLine($"\nYou are working on {scripRef} Press Enter to continue or 'Q' to quit");
            ConsoleKeyInfo key = Console.ReadKey(false);
            
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine("You pressed Enter - performing action!");
                // Continue here with classes
            }
            else if (key.Key == ConsoleKey.Q)
            {
                running = false;
                Console.WriteLine("\nExiting program...");
            }
        }


    }
}