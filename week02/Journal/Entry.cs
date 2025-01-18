using System;
using System.Collections.Generic;

public class Entry
{
    public string _date;
    public string _propmtText;
    public string _entryText;
    public double _stressLevel;
    public void Display()
    {
        Console.WriteLine($"\n Date: {_date} Prompt: {_propmtText}");
        Console.WriteLine($"{_entryText} \n");
        if (_stressLevel >= 1.0 && _stressLevel <= 2.5)
        {
            Console.WriteLine("Red: High stress \n");
        }
        else if (_stressLevel >= 2.6 && _stressLevel <= 4.0)
        {
            Console.WriteLine("Red-Orange: Moderately high stress \n");
        }
        else if (_stressLevel >= 4.1 && _stressLevel <= 5.5)
        {
            Console.WriteLine("Orange: Moderate stress \n");
        }
        else if (_stressLevel >= 5.6 && _stressLevel <= 7.0)
        {
            Console.WriteLine("Orange-Yellow: Moderately low stress \n");
        }
        else if (_stressLevel >= 7.1 && _stressLevel <= 8.5)
        {
            Console.WriteLine("Yellow: Low stress \n");
        }
        else if (_stressLevel >= 8.6 && _stressLevel <= 10.0)
        {
            Console.WriteLine("Yellow-Green: Very low stress \n");
        }
        else if (_stressLevel > 10.0)
        {
            Console.WriteLine("Green: Not stressed \n");
        }
        else
        {
            Console.Write("Invalid stress level\n");
        }
    }
}