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
    
    public ListingActivity()
    {

    }
    public ListingActivity(string name, string desc) : base(name, desc)
    {
        
    }

    public void RunActivity()
    {
        
    }
}