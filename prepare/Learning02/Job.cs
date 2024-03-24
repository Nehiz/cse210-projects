using System;

public class Job 
{
    // Create member variables in the Job class for each of the following: company, job title, start year, end year.
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    

    public Job()
    {
        _company = "N/A";
        _jobTitle = "N/A";
        _startYear = 0;
        _endYear = 0;
    }

    public Job(string company, string jobTitle, int startYear, int endYear)
    {
        _company = company;
        _jobTitle = jobTitle;
        _startYear = startYear;
        _endYear = endYear;
    }

     // Add a display method to display the job details
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}