using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();
        int grade = int.Parse(valueFromUser);
        string gradeLetter;
        string gradeSymbol = "";

        if (grade >= 70)
        {
            Console.WriteLine("You passed your class!!");
        }
        else
        {
            Console.WriteLine("You didn't pass! Try again, you got this!!");
        }

        if (grade >= 90)
        {
            gradeLetter = "A";
            if ((grade % 10) <= 3)
            {
                gradeSymbol = "-";
            }
        }
        else if (grade >= 80)
        {
            gradeLetter = "B";
            if ((grade % 10) >= 7)
            {
                gradeSymbol = "+";
            }
            else if ((grade % 10) <= 3)
            {
                gradeSymbol = "-";
            }
        }
        else if (grade >= 70)
        {
            gradeLetter = "C";
            if ((grade % 10) >= 7)
            {
                gradeSymbol = "+";
            }
            else if ((grade % 10) <= 3)
            {
                gradeSymbol = "-";
            }
        }
        else if (grade >= 60)
        {
            gradeLetter = "D";
            if ((grade % 10) >= 7)
            {
                gradeSymbol = "+";
            }
            else if ((grade % 10) <= 3)
            {
                gradeSymbol = "-";
            }
        }
        else
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"Your grade is a(n) {gradeLetter}{gradeSymbol} at {grade}%");
    }
}