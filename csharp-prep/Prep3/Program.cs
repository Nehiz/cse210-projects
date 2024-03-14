using System;

class Program
{
    static void Main(string[] args)
    {
        //Ask the user to input the magic number and their guess.
                //code below is commented out for when the user supplies the magic number.
        //Console.Write("What is the magic number? ");
        //string magicNumberInput = Console.ReadLine();

        //code to have the computer generate the magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        Console.Write("Welcome to our number guessing game!" + "\nPlease enter your guess? ");
        string guessInput = Console.ReadLine();

        // Parse the input and store it in the guess.
        //int magicNumber = int.Parse(magicNumberInput);
        int guess = int.Parse(guessInput);

        // Determine if the user needs to guess higher or lower
        if (magicNumber > guess)
        {
            Console.WriteLine("Higher");
        }
        else if (magicNumber < guess)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }

        // A loop that keeps looping until the user guess right
        while (magicNumber != guess)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }


    }
}