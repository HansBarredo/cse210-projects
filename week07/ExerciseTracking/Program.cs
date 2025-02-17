using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run1 = new Running(5000, 30);
        Cycling cycling1 = new Cycling(6, 240);
        Swimming swim1 = new Swimming (5, 15);

        activities.Add(run1);
        activities.Add(cycling1);
        activities.Add(swim1);

        foreach (Activity activity in activities)
        {
            activity.DisplaySummary();
        }

    }
}