using System.Collections.Generic;
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Hello, Enter a list of numbers, type 0 when finished.");  // Prompt the user to enter a list of numbers
        Console.WriteLine("Enter a number: ");
        string number = Console.ReadLine();  // Read the input and store it in the variable number

        int numbers = int.Parse(number);  // Parse the input and store it in the variable numbers

        List<int> numList = new List<int>();  // Create a new list to store the numbers
        numList.Add(numbers);  // Add the first number to the list

        //to find the sum of the numbers in the list
        int sum = 0; // Initialize the sum to 0
        
        double average = numList.Average(); //compute the average of the numbers in the list        
        
        while (numbers != 0) // Loop until the user enters 0
        {
            sum += numbers;  // Add the number to the sum
            Console.WriteLine("Enter another number: ");  // Prompt the user to enter another number
            number = Console.ReadLine();  // Read the input and store it in the variable number
            numbers = int.Parse(number);  // Parse the input and store it in the variable numbers
            numList.Add(numbers);  // Add the number to the list

            int max = numList.Max(); //The maximum number in the list
            
            
            if (numbers == 0)  // If the user enters 0, exit the loop
            {
                Console.WriteLine($"The sum is {sum}");  // Print the sum
                Console.WriteLine($"The average is {average}");  // Print the average
                Console.WriteLine($"The largest number is {max}");  // Print the max
                break;
            }


        }        
    }
}