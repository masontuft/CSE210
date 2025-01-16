using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep 5 World!");
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squared = SquareNumber(userNumber);
        DisplayResults(userName,squared);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();
        int userNumber = int.Parse(userInput);
        return userNumber;
    }
    static int SquareNumber(int userNumber) 
    {
        int squared = (int)Math.Pow(userNumber, 2);
        return squared;
    }
    static void DisplayResults(string name, int squared)
    {
        Console.WriteLine($"{name}, the suare of your number is {squared}");
    }

}