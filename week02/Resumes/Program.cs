using System;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();
        myResume._name = "Hans Barredo";

        Job job1 = new Job()
        {
        _jobTitle ="Sotware Engineer",
        _company = "Apple",
        _startYear = 2019,
        _endYear = 2020,
        };

        Job job2 = new Job
        {
            _jobTitle = "Software Engineer",
            _company = "Microsoft",
            _startYear = 2020,
            _endYear = 2021
        };

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();

    }
}