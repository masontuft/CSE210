using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep 4 World!");
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber = 1;

        while(userNumber != 0)
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            numbers.Add(userNumber);
        }
        // Console.WriteLine(numbers.Count);
        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        // Console.WriteLine($"The average is: {numbers.Sum()/numbers.Count}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");

    }
}