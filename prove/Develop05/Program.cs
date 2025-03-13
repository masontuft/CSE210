using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        int totalPoints = 0;
        List<Goal> goals = new List<Goal>();
        bool finished = false;
        bool saved = false;

        while (finished == false)
        {
            Console.WriteLine($"Total Points: {totalPoints}");
            Console.WriteLine("1. Add a goal");
            Console.WriteLine("2. Display all goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Exit");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    // AddGoal();
                    Console.WriteLine("The types of Goals are: ");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    int goalChoice = int.Parse(Console.ReadLine());
                    switch (goalChoice)
                    {
                        case 1:
                            Console.Write("Enter the name of the goal: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter the description of the goal: ");
                            string desc = Console.ReadLine();
                            Console.Write("Enter the number of points for the goal: ");
                            int points = int.Parse(Console.ReadLine());
                            SimpleGoal simpleGoal = new SimpleGoal(name, desc, points);
                            goals.Add(simpleGoal);
                            break;
                        case 2:
                            Console.Write("Enter the name of the goal: ");
                            name = Console.ReadLine();
                            Console.Write("Enter the description of the goal: ");
                            desc = Console.ReadLine();
                            Console.Write("Enter the number of points for the goal: ");
                            points = int.Parse(Console.ReadLine());
                            EternalGoal eternalGoal = new EternalGoal(name, desc, points);
                            goals.Add(eternalGoal);
                            break;
                        case 3:
                            Console.Write("Enter the name of the goal: ");
                            name = Console.ReadLine();
                            Console.Write("Enter the description of the goal: ");
                            desc = Console.ReadLine();
                            Console.Write("Enter the number of points for the goal: ");
                            points = int.Parse(Console.ReadLine());
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            int totalTimes = int.Parse(Console.ReadLine());
                            Console.Write("What is the bonus for completing this goal? ");
                            int bonusPoints = int.Parse(Console.ReadLine());
                            ChecklistGoal checklistGoal = new ChecklistGoal(name, desc, points, totalTimes, bonusPoints);
                            goals.Add(checklistGoal);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                    break;
                case 2:
                    Display();
                    Console.WriteLine("\nCreated Goals:");
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.Write($"{i + 1}. ");
                        goals[i].Display();
                    }
                    break;
                case 3:
                    Save();
                    break;
                case 4:
                    Load();
                    break;
                case 5:
                    Console.WriteLine("\nGoals:");
                    for (int i = 0; i < goals.Count; i++)
                    {
                        Console.Write($"{i + 1}. ");
                        goals[i].Display();
                    }
                    Console.Write("Which goal did you accomplish? ");
                    int goalNum = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Consgratulations!! You have earned {goals[goalNum - 1].GetPoints()} points!");
                    totalPoints += goals[goalNum - 1].SetCompleted();
                    break;
                case 6:
                    finished = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
        
        // Test constructors by creating different types of goals
        // SimpleGoal simpleGoal = new SimpleGoal("Run a marathon", "Complete a full marathon", 1000);
        // EternalGoal eternalGoal = new EternalGoal("Read scriptures", "Read scriptures for at least 10 minutes", 100);
        // ChecklistGoal checklistGoal = new ChecklistGoal("Attend temple", "Attend the temple", 50);
        
        // Add goals to the list
        // goals.Add(simpleGoal);
        // goals.Add(eternalGoal);
        // goals.Add(checklistGoal);
        
        // Display all goals to verify constructors worked correctly
        
        
        // Test the GetRep method
        // Console.WriteLine("\nTesting GetRep method:");
        // Goal simpleRep = simpleGoal.GetRep();
        // simpleRep.Display();
        
        // Test parameterless constructors
        Console.WriteLine("\nTesting parameterless constructors:");
        SimpleGoal emptySimpleGoal = new SimpleGoal();
        emptySimpleGoal.Display();

    }
    private static void Save()
    {

    }

    private static void Load()
    {

    }

    private static void Display()
    {
        
    }
}