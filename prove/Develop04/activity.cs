public class Activity
{
    public string _name;
    public string _desc;
    public int _duration;

    public Activity()
    {

    }

    public Activity(string name, string desc)
    {
        _name = name;
        _desc = desc;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine($"{_desc}");
        Console.WriteLine();
        Console.Write("How long in seconds would you like for your session? ");
        string userInput = Console.ReadLine();
        _duration = int.Parse(userInput);
        GetReady();
    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        // Animation
        DisplayAnimation(3);
        // Thread.Sleep(5000);
    }

    public void DisplayCountdown(int time)
    {

    }

    public void DisplayWellDone()
    {
        Console.WriteLine();
        Console.WriteLine("Well done...");
        Console.WriteLine($"You have completed {_duration} seconds of {_name}.");
        Thread.Sleep(1000);
        // Animation
    }

    public void DisplayAnimation(int time) 
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1200);
        }
        for (int i = time; i > 0; i--)
        {
            Console.Write("\b \b");
        }
        // Console.Write("\b \b");
    }

    public void EndActivity(int time)
    {
        Console.WriteLine("Heading back to menu...");
        // Animation
        Thread.Sleep(time * 1000);
    }
}