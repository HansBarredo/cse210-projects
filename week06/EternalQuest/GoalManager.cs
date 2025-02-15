using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    public double _score;
    public int _level;
    public double _expReq;

    public GoalManager()
    {
        _score = 0;
        _level=1;
        _expReq=1000;
    }

    public void Start()
    {
        List<string> activities = new List<string> { "Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Events", "Quit" };
        int number = 0;
        while (number != 6)
        {
            Console.WriteLine("Menu Option:");
            DisplayPlayerInfo();
            LevelUpDisplay();
            for (int i = 0; i < activities.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {activities[i]}");
            }
            Console.Write("Select an option from the menu: ");
            string userInput = Console.ReadLine();
            Console.WriteLine();
            number = int.Parse(userInput);
            if (number == 1)
            {
                CreateGoal();
            }
            if (number == 2)
            {
                ListGoalDetail();
            }
            if (number == 3)
            {
                SaveGoals();
            }
            if (number == 4)
            {
                LoadGoals();
            }
            if (number == 5)
            {
                RecordEvent();
            }
        }

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points\n");
    }
    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            
            Console.WriteLine(goal.Name);
        }
    }
    public void ListGoalDetail()
    {
        int i=1;
        foreach (var goal in _goals)
        {
            Console.WriteLine($"{i}.{goal.GetDetailString()}");
            i++;
        }
         Console.WriteLine();
    }
    public void CreateGoal()
    {
        List<string> _goalTypes = new List<string> { "Simple Goal", "Eternal Goal", "Checklist Goal" };
        Console.WriteLine("The type of goals are:");
        for (int i = 0; i < _goalTypes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goalTypes[i]}");
        }
        Console.Write("Whih type of goal would you like to create? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        if (number == 1)
        {
            SimpleGoal myGoal = new SimpleGoal();
            Console.Write("Goal name: ");
            myGoal.Name = Console.ReadLine();
            Console.Write("Goal description: ");
            myGoal.Description = Console.ReadLine();
            Console.Write("Points: ");
            myGoal.Points = Console.ReadLine();
            _goals.Add(myGoal);
            Console.WriteLine();
        }
        if (number == 2)
        {
            EternalGoal myGoal = new EternalGoal();
            Console.Write("Goal name: ");
            myGoal.Name = Console.ReadLine();
            Console.Write("Goal Description: ");
            myGoal.Description = Console.ReadLine();
            Console.Write("Points: ");
            myGoal.Points = Console.ReadLine();
            _goals.Add(myGoal);
            Console.WriteLine();
        }
        if (number == 3)
        {
            ChecklistGoal myGoal = new ChecklistGoal();
            Console.Write("Gaol name: ");
            myGoal.Name = Console.ReadLine();
            Console.Write("Goal description: ");
            myGoal.Description = Console.ReadLine();
            Console.Write("Points: ");
            myGoal.Points = Console.ReadLine();
            Console.Write("Occurence to be accomplished: ");
            myGoal.Target = Console.ReadLine();
            Console.Write("Bonus points from completing: ");
            myGoal.Bonus = Console.ReadLine();
            myGoal.AmountCompleted = "0";
            _goals.Add(myGoal);
            Console.WriteLine();
        }

    }
    public void RecordEvent()
    {
        int i = 1;
        foreach (var goal in _goals)
        {
            if (!goal.IsComplete())
            {
                Console.WriteLine($"{i}. {goal.Name} {goal.Description}");
                i++;
            }
            Console.WriteLine();
        }

        Console.Write("Record event: ");
        string userInput = Console.ReadLine();
        if (int.TryParse(userInput, out int number) && number > 0 && number <= _goals.Count)
        {
            Goal selectedGoal = _goals[number - 1];

            selectedGoal.RecordEvent();

            string score = selectedGoal.Points;
            _score += int.Parse(score);

            if (selectedGoal is ChecklistGoal checklistGoal)
            {
                int amountCompleted = int.Parse(checklistGoal.AmountCompleted);
                int target = int.Parse(checklistGoal.Target);
                int bonus = int.Parse(checklistGoal.Bonus);
                if (amountCompleted == target)
                {
                    _score += bonus;
                }
            }

            Console.WriteLine("Event recorded successfully!\n");
            CheckLevelUp();
        }
    }


    public void SaveGoals()
    {
        Console.WriteLine("Load File ");
        Console.Write("File name: ");
        string fileName = Console.ReadLine();
        Console.WriteLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_level);
            outputFile.WriteLine(_expReq);
            outputFile.WriteLine(_score);
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("File saved.\n");
        

    }
    public void LoadGoals()
    {   
        Console.WriteLine("Load File ");
        Console.Write("File name: ");
        string fileName = Console.ReadLine();
        Console.WriteLine();
        
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File not found!");
            return;
        }
        string[] lines = System.IO.File.ReadAllLines(fileName);

        if (int.TryParse(lines[0], out int level))
        {
            _level = level;
        }

        if (double.TryParse(lines[1], out double expReq))
        {
            _expReq = expReq;
        }

        if (double.TryParse(lines[2], out double score))
        {
            _score = score;
        }
    
        for (int i = 2; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(",");

            if (parts.Length < 5)
            {
                Console.WriteLine("Skipping invalid line: " + line);
                continue;
            }

            string goalType = parts[0].Trim();
            Goal myGoal = null;

            if (goalType == "Simple Goal:")
            {
                myGoal = new SimpleGoal();
            }
            else if (goalType == "Eternal Goal:")
            {
                myGoal = new EternalGoal();
            }
            else if (goalType == "Checklist Goal:" && parts.Length >= 7)
            {
                myGoal = new ChecklistGoal
                {
                    Target = parts[4].Trim(),
                    Bonus = parts[5].Trim(),
                    AmountCompleted = parts[6].Trim()
                };
            }

            if (myGoal != null)
            {
                myGoal.Name = parts[1].Trim();
                myGoal.Description = parts[2].Trim();
                myGoal.Points = parts[3].Trim();
                myGoal.isComplete = parts[4].ToLower().Trim();
                _goals.Add(myGoal);
            }
            else
            {
                Console.WriteLine("Unknown goal type: " + goalType);
            }
        }

        Console.WriteLine($"Total goals loaded: {_goals.Count}");
    }
    public void CheckLevelUp()
{
    while (_score >= _expReq)
    {
        _score -= _expReq;  
        _level++; 
        _expReq = _expReq*Math.Pow(_level,_level);

        Console.WriteLine($"Congratulations! You leveled up to Level {_level}!");
    }
}
    public void LevelUpDisplay(){
        if(_score >= _expReq)
        {
            Console.WriteLine($"You just leveled up, you are now level {_level}");
        }
        Console.WriteLine($"Level: {_level}" );
        Console.WriteLine($"Exp Required: {_expReq}\n");
    }

}