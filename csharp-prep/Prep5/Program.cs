using System;

class Program
{
    static void Main(string[] args)  //
    {
        DisplayWelcome(); 

        string name = PromptUserName(); //
        int number = PromptUserNumber();
        int squared = SquareNumber(number);

        DisplayResult(name, squared);
    }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Prep5 Program. ");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();  //to read the user input
            
            return name;  //to return the user input
        }
        
        static int PromptUserNumber() //
        {
            Console.Write("Kindly enter your favourite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }
        
        static int SquareNumber(int number)
        {
            int squared = number * number;
            
            return squared;
        }

        static void DisplayResult(string name, int squared)
        {
            Console.WriteLine($" Hi {name}, the square of your number is {squared}");
        }

    }
}