public class ReflectionActivity : Activity
{
    private List<string> prompts = [
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    ];
    private List<string> items = [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    ];
    Random random = new Random();

    public ReflectionActivity()
    {

    }
    public ReflectionActivity(string name, string desc) : base(name, desc)
    {
        
    }
    public void RunActivity()
    {
        Console.Clear();
        Console.WriteLine("Consider the follwing prompt:");
        Console.WriteLine();
        Console.WriteLine($"\t-{prompts[random.Next(0, prompts.Count)]}-");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Now ponder on each of the following questions as they related to this expereince.");
        Console.Write("You may begin in:");
        for (int i = 3; i > 0; i--)
        {
            Console.Write($" {i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.WriteLine();
            displayQuestion();
            Console.WriteLine();
            currentTime = DateTime.Now;
            
        }
        DisplayWellDone();
        EndActivity(4);
    }

    public void displayQuestion()
    {
        Console.WriteLine(items[random.Next(0, items.Count)]);
        Thread.Sleep(6000);
    }
}