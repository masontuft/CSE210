using System;


class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        Menu menu = new Menu();
        Journal journal = new Journal();
        bool running = true;
        bool saved = true;
        while(running == true)
        {
            menu.Display();
            string userChoice = Console.ReadLine();
            int choiceNum = int.Parse(userChoice);
            switch (choiceNum)
            {
                case 1:
                    Console.WriteLine("New Entry");
                    journal._journal.Add(journal.AddEntry());
                    saved = false;
                    break;
                case 2:
                    Console.WriteLine("Display Journal");
                    // Console.WriteLine(journal._journal);
                    journal.Display();
                    break;
                case 3:
                    Console.Write("Load Journal (Enter a File Name):\n>");
                    journal._fileName = Console.ReadLine();
                    if(saved == false)
                    {
                        journal.Save();
                    }
                    journal.Load();
                    break;
                case 4:
                    Console.Write("Save Journal (Enter a File Name):\n>");
                    journal._fileName = Console.ReadLine();
                    journal.Save();
                    saved = true;
                    break;
                case 5:
                    if(saved == true)
                    {
                        running = false;
                    }else 
                    {
                        Console.WriteLine("Saving unsaved changes...");
                        journal.Save();
                        saved = true;
                        running = false;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}