using System;

class Program
{
    static void Main(string[] args)
    {
      
        Console.WriteLine("What is your grade percentage? ");
        string gradeInput = Console.ReadLine();


        // Parse the input and store it in the variable grade
        int grade = int.Parse(gradeInput);

        int lastDigit = grade % 10; // Get the last digit of the grade

        //create a new variable called 'letter' to store the letter grade and sign.
        string letter;
        string sign = "";

        // Determine the letter grade
        if (grade >= 90)
        {
            if (grade == 100) // If the grade is 100, it is an A+
            {   
                letter = "A";
            }
            else
            {
                letter = "A-";
            } 
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the sign based on the last digit
        if (lastDigit >= 7 && grade == 100) //
        {
            if (letter != "F") // this ensures the F takes no + sign
            {
                sign = "+";
            }
        }
        else if (lastDigit < 3 && grade <= 99)
        {
            if (letter != "F") // this will ensures the F takes no - sign
            sign = "-";
        }

        // Display the letter grade and sign
        Console.WriteLine($"Your grade is: {letter}{sign}");

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