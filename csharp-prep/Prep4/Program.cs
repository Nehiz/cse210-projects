using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numList = new List<int>();  // Create a new list to store the numbers

        Console.WriteLine("Enter a number (or 0 to quit): ");  // Prompt the user to enter a number
        
        while (true) // Infinite loop until the user enters 0
        {
            string number = Console.ReadLine();  // Read the user input and store it in the variable number
            
            int numbers = int.Parse(number);  // Parse the input and store it in the variable numbers
            
            if (numbers == 0)  // Check if the user enters 0.
            {
                break; // If yes, then exit the loop
            }
            
            numList.Add(numbers);  // Add the number to the list
            Console.WriteLine($"Number: {numbers} added to list"); // Provide feedback to the user
        }

        int sum = numList.Sum(); //    Calculate the sum of the numbers
        double average = numList.Average(); // Calculate the average of the numbers
        int max = numList.Max(); // Calculate the maximun number   

        Console.WriteLine($"The sum is {sum}");  // Print the sum
        Console.WriteLine($"The average is {average}");  // Print the average
        Console.WriteLine($"The largest number is {max}");  // Print the max

    }
}