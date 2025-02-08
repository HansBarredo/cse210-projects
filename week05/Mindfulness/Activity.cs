using System;
using System.Diagnostics;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    private readonly char[] spinnerFrames = { '|', '/', '-', '\\' };


    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine($"{_description}");
        do
        {
            Console.Write("Enter duration: (at least 20 seconds): ");
            string input = Console.ReadLine();
            Console.WriteLine();

            if (!int.TryParse(input, out _duration) || _duration < 20)
            {
                Console.WriteLine("❌ Invalid input. Please enter a number that is 20 or more.");
            }

        } while (_duration < 20);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done! \n");
        Console.WriteLine($"You have completed another {_duration} seconds of {_name} \n");
    }

    public static class SpinnerGenerator
{
    public static void GenerateSpinner(int duration)
{
    int spinnerPos = Console.CursorLeft;

    for (int i = 0; i < duration; i++)
    {
        Console.SetCursorPosition(spinnerPos, Console.CursorTop);
        Console.Write("/"); Thread.Sleep(100);
        Console.SetCursorPosition(spinnerPos, Console.CursorTop);
        Console.Write("-"); Thread.Sleep(100);
        Console.SetCursorPosition(spinnerPos, Console.CursorTop);
        Console.Write("\\"); Thread.Sleep(100);
        Console.SetCursorPosition(spinnerPos, Console.CursorTop);
        Console.Write("|"); Thread.Sleep(100);
    }
    Console.SetCursorPosition(spinnerPos, Console.CursorTop);
    Console.Write(" "); 
    Console.WriteLine();
}
}
    public void ShowCountDown(int seconds)
    {
        while (seconds > 0)
        {
            Console.Write(seconds.ToString().PadLeft(2, ' ') + " ");
            Thread.Sleep(1000);
            Console.Write("\b\b\b");
            seconds--;
        }
        Console.WriteLine();
    }
}
