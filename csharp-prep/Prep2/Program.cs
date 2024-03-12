using System;

class Program
{
    static void Main(string[] args)
    {
      
        Console.WriteLine("What is your grade percentage? ");
        string gradeInput = Console.ReadLine();

        // Declear a variable to store the parsed input
        //int grade;

        // Parse the input and store it in the variable grade
        int grade = int.Parse(gradeInput);

        //create a new variable called 'letter' to store the letter grade
        char letter;

        if (grade >= 90)
        {
            letter = 'A';
        }
        else if (grade >= 80)
        {
            letter = 'B';
        }
        else if (grade >= 70)
        {
            letter = 'C';
        }
        else if (grade >= 60)
        {
            letter = 'D';
        }
        else
        {
            letter = 'F';
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (grade >=70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}