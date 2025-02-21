using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment assignment1 = new Assignment("Samuel Bennett","Multiplication");
        assignment1.GetSummary();

        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        a2.GetSummary();
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        a3.GetSummary();
        Console.WriteLine(a3.GetWritingInformation());
    }
}