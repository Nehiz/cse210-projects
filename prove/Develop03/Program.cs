using System;

class Program
{
    static void Main(string[] args)
    {
        // int hiddenLinesCount = 0; //Declare and initialize hiddenLinesCount
        // Display program header or welcome message
        DisplayHeader();

        // Load scriptures from file or any other data source
        ScriptureManager scriptureManager = new ScriptureManager();
        if (!scriptureManager.LoadScriptureFromFile("scripture.txt"))
        {
            Console.WriteLine("Failed to load scriptures. Exiting program");
            return;
        }

        // Get the first scripture from the scripture manager
        Scripture scripture = scriptureManager.GetScripture(0);


        // Main program loop
        while (true)
        {
            // Clear console screen
            Console.Clear();

            // Display the complete scripture
            //scriptureManager.DisplayScripture();
            Console.WriteLine("Complete Scripture:");
            Console.WriteLine(scripture.GetText());

            // Prompt user to continue or quit
            Console.WriteLine("\nPress Enter to hide more lines or type 'quit' to exit");
            string userInput = Console.ReadLine();

            // Check if user wants to quit
            if (userInput.ToLower() == "quit")
            {
                Console.WriteLine("Exiting program...");
                break;
            }

            // Hide a few lines of text
            scriptureManager.HideRandomWords(0, 3);


            // Check if all lines are hidden
            if (scriptureManager.AllLinesHidden())
            {
                Console.WriteLine("All lines are hidden. Exiting program.");
                break;
            }
        }
    }

    static void DisplayHeader()
    {
        Console.WriteLine("Welcome to Scripture Memorizer!");
        Console.WriteLine("==============");
        Console.WriteLine();
    }
}