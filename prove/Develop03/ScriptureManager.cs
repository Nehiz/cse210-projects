using System;
using System.Collections.Generic;
using System.IO;

public class ScriptureManager
{
    private List<string> scripture;

    private int hiddenLinesCount;

    public ScriptureManager()
    {
        scripture = new List<string>();
        hiddenLinesCount = 0;
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

    public void DisplayScripture()
    {
        Console.Clear();
        foreach (string line in scripture)
        {
            Console.WriteLine(line);
        }
    }

    public void HideLines(int count)
    {
        if (count <= 0 || count > scripture.Count)
        {
            Console.WriteLine("Invalid number of Lines to hide.");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            int index = hiddenLinesCount + i;
            if (index < scripture.Count)
            {
                string hiddenLine = new string('*', scripture[index].Length);
                scripture[index] = hiddenLine;
            }
        }

        hiddenLinesCount += count;
    }

    public bool AllLinesHidden()
    {
        return hiddenLinesCount >= scripture.Count;
    }
    

    public Scripture GetScripture(int index)
    {
        if (index >= 0 && index < scripture.Count)
        {
            // assuming each scripture is represented as a single string
            string scriptureText = scripture[index];
            //extract reference and text from the scripture, example "John 3:16"
            string[] parts = scriptureText.Split('|');
            
            if (parts.Length >= 2)
            {
                string reference = parts[0];
                string text = parts[1];
                return new Scripture(reference, text);
            }
            else
            {
                Console.WriteLine("Invalid scripture format:" + scriptureText);
                return null;
            }
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
            
            scripture[index] = string.Join(" ", words); // Assign the modified text back to the scripture list
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