using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables
    public string _personName;
    private List<Job> _jobs;

    // Constructor
    public Resume()
    {
        _personName = "";
        _jobs = new List<Job>();
    }

    // Adding the two jobs created earlier to the list of jobs in the resume
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    public void Display()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs: ");
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
        

}