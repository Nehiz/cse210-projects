using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new job instance named job1
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Display the company of the job above
        //Console.WriteLine(job1._company);
        
        // Call the method to display the job1 details
        // job1.Display();

        // Create a second job instance named job2
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Display the company of the job2
        //Console.WriteLine(job2._company);
        
        // Call the method to display the job2 details
        // job2.Display();

        // Write a space before displaying the resume
        Console.WriteLine();

        // Create the Resume class
        Resume myResume = new Resume();
        myResume._personName = "Nehikhare Efehi";
        myResume.AddJob(job1);
        myResume.AddJob(job2);
        myResume.Display();

        // Write a space after displaying the resume
        Console.WriteLine();
       



      

    }

}