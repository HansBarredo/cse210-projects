using System.Data;
using System.Reflection.Metadata;

class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private static List<string> _usedPrompts = new List<string>();

    public ListingActivity() : base()
    {
        _name = "Listing Activity\n";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n";

        _prompts = new List<string>
        {
            "---Who are people that you appreciate?---",
            "---What are personal strengths of yours?---",
            "---Who are people that you have helped this week?---",
            "---When have you felt the Holy Ghost this month?---",
            "--Who are some of your personal heroes?--"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        GetListFromUser();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        if (_usedPrompts.Count == _prompts.Count)
        {
            _usedPrompts.Clear(); 
        }

        Random random = new Random();
        string randomPrompt;

        do
        {
            int randomIndex = random.Next(_prompts.Count);
            randomPrompt = _prompts[randomIndex];
        } while (_usedPrompts.Contains(randomPrompt)); 

        _usedPrompts.Add(randomPrompt); 

        Console.WriteLine(randomPrompt);
        Console.Write("\nGet ready...");
        ShowCountDown(5);
    }

    public List<string> GetListFromUser()
    {

        List<string> userList = new List<string>();
        Console.WriteLine("List as much thoughts as you can within the given time:");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);

        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            userList.Add(input);
        }

        _count = userList.Count();
        if (_count > 1)
        {
            Console.WriteLine($"\nyou made {_count} entries\n");
        } else
        {
            Console.WriteLine($"\nyou made {_count} entry\n");
        }
        
        return userList;

    }


}