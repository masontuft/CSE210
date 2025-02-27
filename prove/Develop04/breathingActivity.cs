public class BreathingActivity : Activity
{
    

    public void RunActivity()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.WriteLine();
            BreatheIn(3);
            BreatheOut(4);
            Console.WriteLine();
            BreatheIn(4);
            BreatheOut(6);
            currentTime = DateTime.Now;
        }
        
    }

    public void BreatheIn(int time)
    {
        while (time >=0)
        {
            Console.Write($"Breathe in...{time}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            time--;
        }
    }
    public void BreatheOut(int time)
    {
        while (time >=0)
        {
            Console.Write($"Breathe out...{time}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            time--;
        }
    }
}