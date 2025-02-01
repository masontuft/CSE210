using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;


public class Journal
{
    public List<Entry> _journal = new List<Entry>();
    public string _fileName = "myJournal.txt";
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
        userEntry._date = DateOnly.FromDateTime(DateTime.Now);
        userEntry.Display();
        return userEntry;
    }

    public void Display()
    {
        foreach (var _entry in _journal)
        {
            Console.WriteLine($"Date: {_entry._date} - Prompt: {_entry._prompt} \n {_entry._entry}");
        }
    }
    public void Save()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName, append: true))
        {
            // You can add text to the file with the WriteLine method
            foreach (var _entry in _journal)
            {
                outputFile.WriteLine("---ENTRY---");
                outputFile.WriteLine(_entry._date);
                outputFile.WriteLine(_entry._prompt);
                outputFile.WriteLine(_entry._entry);
                // outputFile.WriteLine($"Date: {_entry._date} - Prompt: {_entry._prompt} \n {_entry._entry} ");    
            }
        }
    }
    public void Load()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        _journal.Clear();

        Entry indexEntry = null;

        foreach (string line in lines)
        {
            if(line == "---ENTRY---")
            {
                indexEntry = new Entry();
                _journal.Add(indexEntry);
                continue;
            }

            if (indexEntry != null)
            {
                if (indexEntry._date == default)
                {
                    indexEntry._date = DateOnly.Parse(line);
                }
                else if (string.IsNullOrEmpty(indexEntry._prompt))
                {
                    indexEntry._prompt = line;
                }
                else if (string.IsNullOrEmpty(indexEntry._entry))
                {
                    indexEntry._entry = line;
                }
            }
            // Console.WriteLine(line);
            
        }
        Display();
    }
}

