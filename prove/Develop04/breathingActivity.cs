public class BreathingActivity : Activity
{
    
    public BreathingActivity()
    {

    }
    public BreathingActivity(string name, string desc) : base(name, desc)
    {
        
    }
    public void RunActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.WriteLine();
            BreatheIn(4);
            Console.WriteLine();
            BreatheOut(6);
            Console.WriteLine();
            currentTime = DateTime.Now;
            
        }
        DisplayWellDone();
        EndActivity(4);
        
    }

    public void BreatheIn(int time)
    {
        Console.Write("Breathe in...");
        while (time >=0)
        {
            Console.Write($"{time}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            time--;
        }
    }
    public void BreatheOut(int time)
    {
        Console.Write("Breathe out...");
        while (time >=0)
        {
            Console.Write($"{time}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            time--;
        }
    }
}