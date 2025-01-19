using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess = -1;

        int count = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
                count = count + 1;
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
                count = count + 1;
            }
            else
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {count} guesses.");
            }

        }                    
    }
}