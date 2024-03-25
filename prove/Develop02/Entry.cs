using System;

public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }
    // New property to handle additional information from user
    public string AdditionalInfo { get; set; }

    public Entry(string prompt, string response, string additionalInfo)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now;
        AdditionalInfo = additionalInfo;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\nAdditional Info: {AdditionalInfo}";
    }

}