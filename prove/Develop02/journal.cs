using System;



public class Journal
{
    public List<Entry> _journal = new List<Entry>();
    public Entry AddEntry()
    {
        Prompt prompt = new Prompt();
        Random random = new Random();
        Console.WriteLine("Add Entry Called");
        // Console.Write("Write what is on your mind: ");
        string randomPrompt = prompt._prompts[random.Next(prompt._prompts.Count)];
        Console.WriteLine(randomPrompt);
        Entry userEntry = new Entry();
        userEntry._prompt = randomPrompt;
        userEntry._entry = Console.ReadLine();
        userEntry.Display();
        return userEntry;
    }

    public void Display()
    {
        
    }
}

