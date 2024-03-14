using System;

class Program
{
    static void Main(string[] args)
    {
        /*Ask the user to input the magic number and their guess.
        
        Console.Write("What is the magic number? ");
        string magicNumberInput = Console.ReadLine();
        */

        //code to have the computer generate the magic number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        //Intialize the guess counter
        int guessCount = 1;

        Console.Write("Welcome to our number guessing game!"
        + "\nA number between 1 to 100 has been chosen."
        + "\nCan you guess the number? ");
        string guessInput = Console.ReadLine();

        
        //int magicNumber = int.Parse(magicNumberInput); //Parsed the magic number input entered by the user and saved in the variable magicNumber
        int guess = int.Parse(guessInput); // Parse the input and store it in the guess.

        // Use an if statement to determine if the user need to guess higher or lower
        
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
            //Console.Write("Can you guess the number? ");
            guess = int.Parse(Console.ReadLine());

            // Increase the guess counter
            guessCount++;

            // Use an if statement to determine if the user need to guess higher or lower
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
                Console.WriteLine($"Congratulations! You guessed the magic number {magicNumber} correctly in {guessCount} guesses.");
            }
        }


    }
}