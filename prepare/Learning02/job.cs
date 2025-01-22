using System;
using System.ComponentModel.DataAnnotations;
/*
    Variables:
    Company
    Job Title
    Start Year
    End year

    Methods
    Displays information in said format "Job Title (Company) StartYear-EndYear"
*/

public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    
    public void display()
    {
        // Console.WriteLine(_jobTitle);
        // Console.WriteLine(_company);
        // Console.WriteLine(_startYear);
        // Console.WriteLine(_endYear);
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}