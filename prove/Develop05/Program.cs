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
        bool saved = true;

        
        while (finished == false)
        {
            try
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
                                SimpleGoal simpleGoal = new SimpleGoal(name, desc, points, false);
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
                                ChecklistGoal checklistGoal = new ChecklistGoal(name, desc, points, totalTimes, bonusPoints, 0);
                                goals.Add(checklistGoal);
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                        saved = false;
                        break;
                    case 2:
                        Console.WriteLine("\nCreated Goals:");
                        for (int i = 0; i < goals.Count; i++)
                        {
                            Console.Write($"{i + 1}. ");
                            goals[i].Display();
                        }
                        break;
                        
                    case 3:
                        try
                        {
                            Console.Write("What is the Filname? ");
                            string filename = Console.ReadLine();
                            using (StreamWriter outputFile = new StreamWriter(filename))
                            {
                                // You can add text to the file with the WriteLine method
                                outputFile.WriteLine($"Total Points~{totalPoints}");
                                
                                foreach (Goal goal in goals)
                                {
                                    outputFile.WriteLine(goal.GetRep());
                                }
                            }
                            Console.WriteLine($"The goals have been saved to {filename}");
                            saved = true;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("An error occurred: " + e.Message);
                        }
                        
                        break;

                    case 4:
                        try
                        {
                            Console.Write("What is the Filname? ");
                            string filename = Console.ReadLine();
                            string[] lines = System.IO.File.ReadAllLines(filename);

                            foreach (string line in lines)
                            {
                                string[] parts = line.Split("~");
                                
                                if (parts[0] == "Total Points")
                                {
                                    totalPoints = int.Parse(parts[1]);
                                }
                                if (parts[0] == "SimpleGoal")
                                {
                                    SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                                    goals.Add(simpleGoal);
                                }
                                else if (parts[0] == "EternalGoal")
                                {
                                    EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                                    goals.Add(eternalGoal);
                                }
                                else if (parts[0] == "ChecklistGoal")
                                {
                                    ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                                    goals.Add(checklistGoal);
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("An error occurred: " + e.Message);
                        }
                        
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
                        totalPoints += goals[goalNum - 1].SetCompleted();
                        Console.WriteLine($"Consgratulations!! You have earned {goals[goalNum - 1].GetPoints()} points!");
                        saved = false;
                        break;

                    case 6:
                        if (saved == false)
                        {
                            try
                            {
                                string filename = "goals.txt";
                                using (StreamWriter outputFile = new StreamWriter(filename))
                                {
                                    // You can add text to the file with the WriteLine method
                                    outputFile.WriteLine($"Total Points~{totalPoints}");
                                    
                                    foreach (Goal goal in goals)
                                    {
                                        outputFile.WriteLine(goal.GetRep());
                                    }
                                }
                                Console.WriteLine($"The goals have been saved to {filename}");
                                saved = true;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("An error occurred: " + e.Message);
                            }
                            
                        }

                        finished = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
        
        
        

    }
    
}