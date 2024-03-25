using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void WriteNewEntry()
    {
        string prompt = GenerateRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");

        Console.Write("Response: ");
        string response = Console.ReadLine();

        Entry entry = new Entry(prompt, response);
        entries.Add(entry);

        Console.WriteLine("Entry added to Journal.");

    }

    public void DisplayJournal()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries found.");
        }
        else
        {
            Console.WriteLine("Entries");
            foreach (var entry in entries)
            {
                Console.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}, Response: {entry.Response}");
                Console.WriteLine($"Prompt: {entry.Prompt}");
                Console.WriteLine($"Response: {entry.Response}");
            }

        }
    }

    public void SaveToFile(string fileName)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (Entry entry in entries)
                {
                    outputFile.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                }

            }

            Console.WriteLine("Entries saved successfully to file.");

        }
        
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving to file: {ex.Message}");
        }
    }

    public void LoadFromFile(string fileName)
    {
        try
        {
            entries.Clear();

            using (StreamReader inputFile = new StreamReader(fileName))
            {
                string line;
                while ((line = inputFile.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        Entry entry = new Entry(parts[1], parts[2]);
                        entry.Date = DateTime.Parse(parts[0]);
                        entries.Add(entry); 
                    }
                }
            }

            Console.WriteLine("Entries loaded from file.");
            
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading from file: {ex.Message}");
        }
    
    }

    private string GenerateRandomPrompt()
    {
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"

        };

        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }

    
}
