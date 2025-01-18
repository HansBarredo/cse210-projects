using System;
using System.Runtime.InteropServices;
using System.IO;


class Program
{
    static void Main(string[] args)
    {

        Journal newJournal = new Journal();
        newJournal._entries = new List<Entry>();

        int numberInput = 0;
        while (numberInput != 5)
        {
            List<string> Menu = new List<string>{
                "Journal\n",
                "1. Write",
                "2. Display",
                "3. Load",
                "4. Save",
                "5. Quit",
            };

            for (int i = 0; i < Menu.Count; i++)
            {
                Console.WriteLine(Menu[i]);
            }

            Console.Write("What would you like to do? ");
            string userInput = Console.ReadLine();
            numberInput = int.Parse(userInput);

            if (numberInput == 1)
            {
                Console.Write("Prompt: ");
                Entry newEntry = new Entry();
                newJournal.AddEntry(newEntry);
                Console.WriteLine("Entry added successfully!\n");
            }
            else if (numberInput == 2)
            {
                newJournal.DisplayAll();
            }
            else if (numberInput == 3)
            {
                Console.Write("Name of file: ");
                string filePathLoad = Console.ReadLine();
                newJournal.LoadFromFile(filePathLoad);
            }
            else if (numberInput == 4)
            {
                Console.Write("Name your file: ");
                string filePathSave = Console.ReadLine();
                newJournal.SaveToFile(filePathSave);
            }

            else if (numberInput == 5)
            {
                Console.WriteLine("Exiting program...");
                System.Environment.Exit(0);
            }

        }

    }
}