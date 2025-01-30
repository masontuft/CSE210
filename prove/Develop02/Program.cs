using System;


class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        Menu menu = new Menu();
        Journal journal = new Journal();
        bool running = true;
        while(running == true)
        {
            menu.Display();
            string userChoice = Console.ReadLine();
            int choiceNum = int.Parse(userChoice);
            switch (choiceNum)
            {
                case 1:
                    Console.WriteLine("1 selected");
                    journal._journal.Add(journal.AddEntry());
                    break;
                case 2:
                    Console.WriteLine("2 selected");
                    Console.WriteLine(journal._journal);
                    foreach (var _entry in journal._journal)
                    {
                        Console.WriteLine(_entry._prompt);
                        Console.WriteLine(_entry._entry);
                    }
                    break;
                case 3:
                    Console.WriteLine("3 selected");
                    break;
                case 4:
                    running = false;
                    break;
                default:
                    break;
            }
        }
    }
}