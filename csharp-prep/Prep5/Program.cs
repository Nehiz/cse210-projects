using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome(); 

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Prep5 Program. ");
        }

        //Console.WriteLine("Press Enter to continue ");

        string name = PromptUserName();

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();  //to read the user input
            
            return name;  //to return the user input
        }
        
        //Console.WriteLine("Press Enter to continue");

        int number = PromptUserNumber();

        static int PromptUserNumber()
        {
            Console.Write("Kindly enter your favourite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }
        
        int squared = SquareNumber(number);

        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }

        DisplayResult(name, squared);

        static void DisplayResult(string name, int squared)
        {
            Console.WriteLine($"{name}, the square of your number is {squared}");
        }

    }
}