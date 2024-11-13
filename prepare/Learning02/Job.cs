using System;

// Responsibility: Keep track of the company, job title, start year, and end year.
// Behavior: Display the job information in the format "Job Title (Company) StartYear-EndYear".

public class Job
{
    // variables
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear = 0;
    public int _endYear = 0;

    public Job()
    {
    }

    // Add a Display method
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}