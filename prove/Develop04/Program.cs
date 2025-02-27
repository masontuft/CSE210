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
                    
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking through breathing " 
                    + "in an out slowly. Clearn your mind and focus on your breathing.");
                    breathingActivity.StartActivity();
                    breathingActivity.RunActivity();
                    break;
                case "2":
                // reflecting activity
                    ReflectionActivity reflectingActivity = new ReflectionActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown " 
                    + "strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    reflectingActivity.StartActivity();
                    reflectingActivity.RunActivity();
                    // reflectingActivity
                    break;
                case "3":
                    // Listing Activity
                    ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life " 
                    + "by having you list as many things as you can in a certain area.");
                    listingActivity.StartActivity();
                    listingActivity.RunActivity();
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