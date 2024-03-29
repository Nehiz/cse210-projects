using System;
using System.Collections.Generic;
using System.IO;

public class ScriptureManager
{
    private List<string> scripture;

    public ScriptureManager()
    {
        scripture = new List<string>();
    }

    public bool LoadScriptureFromFile(string filePath)
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                scripture.Add(line);
            }
            return true;

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading from file: {ex.Message}");
            return false;
        }
    }

    public void DisplayScripture(int index)
    {
        if (index >= 0 && index < scripture.Count)
        {
            Console.WriteLine(scripture[index]);
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }

    public Scripture GetScripture(int index)
    {
        if (index >= 0 && index < scripture.Count)
        {
            // assuming each scripture is represented as a single string
            string scriptureText = scripture[index];
            //extract reference and text from the scripture, example "John 3:16"
            string[] parts = scriptureText.Split('|');
            string reference = parts[0];
            string text = parts[1];
            return new Scripture(reference, text);
        }
        else
        {
            Console.WriteLine("Invalid index.");
            return null;

        }
    }

    public void HideRandomWords(int index, int count)
    {
        Random rand = new Random();
        if (index >= 0 && index < scripture.Count)
        {
            string[] words = scripture[index].Split(' ');
            for (int i = 0; i < count; i++)
            {
                int wordIndex = rand.Next(words.Length);
                words[wordIndex] = new string('*', words[wordIndex].Length);
            }
            string newScripture = string.Join(" ", words);
        }
    }

    public bool AllWordsHidden(int index)
    {
        if (index >= 0 && index < scripture.Count)
        {
           return !scripture[index].Contains('*');
        }
        return false;
    }

}