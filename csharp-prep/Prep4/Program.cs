using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numList = new List<int>();  // Create a new list to store the numbers

        Console.WriteLine("Enter a number (or 0 to quit): ");  // Prompt the user to enter a number
        
        string number = Console.ReadLine();  // Read the user input and store it in the variable number
        int numbers = int.Parse(number);  // Parse the input and store it in the variable numbers
   
        numList.Add(numbers);  // Add the first number to the list

        //to find the sum of the numbers in the list
        int sum = 0; // Set the sum to 0

        while (numbers != 0) // Loop until the user enters 0
        {
            sum += numbers;  // Add the numbers to the sum
            double average = ((double)sum) / numList.Count();  // cast the sum to a double and calculate the average.           
            
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