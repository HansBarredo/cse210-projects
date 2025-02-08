using System;
using System.Runtime.InteropServices;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        int numberInput = 0;
        while (numberInput != 4)
        {
            List<string> Menu = new List<string>{
                "Main Menu\n",
                "1. Breathing Activity",
                "2. Reflection Activity",
                "3. Listing Activity",
                "4. Quit\n",
            };

            for (int i = 0; i < Menu.Count; i++)
            {
                Console.WriteLine(Menu[i]);
            }

            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();
            numberInput = int.Parse(userInput);
            Console.WriteLine();
            

            if (numberInput == 1)
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                Console.Write("Returning to Main Menu ");
                Activity.SpinnerGenerator.GenerateSpinner(10);

            }
            else if (numberInput == 2)
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
                Console.WriteLine("Returning to Main Menu ");
                Activity.SpinnerGenerator.GenerateSpinner(10);

            }
            else if (numberInput == 3)
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                Console.WriteLine("Returning to Main Menu ");
                Activity.SpinnerGenerator.GenerateSpinner(10);

            }
            else if (numberInput == 4)
            {
                Console.WriteLine("Exiting program ");
                Activity.SpinnerGenerator.GenerateSpinner(10);
                System.Environment.Exit(0);
            }

        }
        
        
    }
}