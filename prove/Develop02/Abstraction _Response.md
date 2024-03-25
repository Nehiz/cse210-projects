

# Abstraction and Its Importance
Abstraction which is a key concept in programming involves simplifying complex concepts by hiding details that are unnecessary and only focusing on those features that are essential. One importance of abstraction in programming is that it allows programmers to work with high-level concepts without needing to understand the complex details underneath the code. It thus provide a clear and simplified interface for the programmer to interact with the systems. 

**A Benefit of Abstraction**
When used correctly, one benefit of abstraction is that it makes the code to be easier to understand, maintain and extend over time.

**Application of Abstraction**
An application of abstraction in the context of the journal program assignment is the sepation of concerns between the 'Journal' class and the 'Entry' class. We saw that while the 'Entry' class represented individual journal entries, the 'Journal' class house the functionality related to managing a journal. Thus, developers are able to work with entries without the need to fully understand the internal implementation of the journal management. 

**Demonstration of Abstraction in my Journal Program**
In the code below, the 'DisplayJournal' method in the 'Journal' class abstracts away the details of how individual entries are displayed. it simply iterates over the list of entries and calls the 'DIsplay' method on each 'Entry' object. The 'Entry' class contains the details of displaying an individual entry, also abstracting them away from the journal class. this helps to improve the organization of the code and makes it easier to read.

```csharp
public class Journal
{
    private List<Entry>entries;
            //Constructor, methods, and properties have been removed for simplicity
    public void DisplayJournal()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }
}
public class Entry
{
    public string Prompt {get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}\n");
    }
} 
