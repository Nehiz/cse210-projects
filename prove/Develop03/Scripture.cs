using System;
using System.IO;


public class Scripture
{
    private string _reference;
    private string _text;

    // Constructors
    public Scripture(string reference, string text)
    {
        _reference = reference;
        _text = text;
    }

    //Methods
    public string GetReference()
    {
        return _reference;

    }

    public string GetText()
    {
        return _text;
    }

    // Creativity: loading scripture from file
    public static Scripture LoadFromFile(string filePath)
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);
            string reference = lines[0];
            string text = string.Join(Environment.NewLine, lines[1..]);
            return new Scripture(reference, text);
            
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading from file: {ex.Message}");
            return null;
        }
    }

   
    

}