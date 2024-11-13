using System;
// A code template for the category of things known as Job. The
// responsibility of a Job is to hold and display job information.

// Responsibility: Keep track of the company, job title, start year, and end year.
// Behavior: Display the job information in the format "Job Title (Company) StartYear-EndYear".

public class Job
{
    // member variables
    // The C# convention is to start member variables with an underscore _
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    // A method that displays a person's list of jobs 
    public Job()
    {
    }

    // Add a Display method
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}