using System;
using Microsoft.VisualBasic;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }
    static string PropmtUserName()
    {
        Console.Write("Please enter your name: ");
        string userName=Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string numberInput=Console.ReadLine();
        int userNumber = int.Parse(numberInput);
        return userNumber;
    }
    static int SquareNumber(int num)
    {
        int numberSquared = num*num;
        return numberSquared;
    } 

    static void DisplayResult(string userName, int numberSquared)
    {
        Console.WriteLine($"{userName}, the square of your number is {numberSquared}");
    }
    
        static void Main(string[] args)
    {
    
        DisplayWelcome();

        string userName = PropmtUserName();
        int userNumber = PromptUserNumber();

        int numberSquared = SquareNumber(userNumber);

        DisplayResult(userName, numberSquared);
    }
}