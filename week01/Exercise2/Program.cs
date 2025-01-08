using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        string symbol = "";

        Console.Write("What is your grade percentage? ");
        string userInput =Console.ReadLine();
        int grade = int.Parse(userInput);

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        //Stretch Challenge

        if (grade % 10 >=7 && (!(letter == "A" || letter == "F")))
        {
            symbol = "+";
        }
        else if  (grade % 10 < 3 && letter != "F")
        {
            symbol = "-";
        }
        else
        {
            symbol="";
        }

        Console.WriteLine($"Your letter grade is {letter}{symbol}.");
    }
}