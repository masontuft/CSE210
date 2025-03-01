public class ListingActivity : Activity
{
    
    private List<String> prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    ];
    private List<String> responses = new List<String>();
    private Random random = new Random();
    
    public ListingActivity()
    {

    }
    public ListingActivity(string name, string desc) : base(name, desc)
    {
        
    }

    public void RunActivity()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"\t-{prompts[random.Next(0, prompts.Count)]}-");
        Console.Write("You may begin in: ");
        for (int i = 4; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            responses.Add(Console.ReadLine());
            currentTime = DateTime.Now;
            
        }
        Console.WriteLine("Here are the following responses you provided:");
        foreach (string response in responses)
        {
            Console.WriteLine(response);
        }
        DisplayWellDone();
        EndActivity(4);
    }
}