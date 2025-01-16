using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep 3 World!");
        // Console.Write("What is the magic number? ");
        // string magicInput = Console.ReadLine();
        // int magicNumber = int.Parse(magicInput);
        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        bool incorrect = true;
        do 
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int guessNumber = int.Parse(guess);
            if (guessNumber == magicNumber) 
            {
                incorrect = false;
                Console.WriteLine("You Guessed it!");
            } else if (guessNumber >= magicNumber)
            {
                Console.WriteLine("Lower");
            }else 
            {
                Console.WriteLine("Higher");
            }
        } while (incorrect);
        

    }
}