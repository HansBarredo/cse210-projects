using System;
class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity\n";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n";
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.Write("Getting ready! ");
        SpinnerGenerator.GenerateSpinner(10);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            Console.Write("Breathe in...");
            int breatheInTime = (int)Math.Round((_duration / 19) / 0.41);
            ShowCountDown(breatheInTime);

            Console.Write("Hold...");
            int holdTime = (int)Math.Round((_duration / 19) / 0.37);
            ShowCountDown(holdTime);

            Console.Write("Breathe out...");
            int breatheOutTime = (int)Math.Round((_duration / 19) / 0.21);
            ShowCountDown(breatheOutTime);

            Console.WriteLine();
        }
        DisplayEndingMessage();
    }
}
