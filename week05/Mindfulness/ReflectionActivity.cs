class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    private static List<string> _usedPrompts = new List<string>();

    public ReflectionActivity() : base()
    {
        _name = "Listing Activity\n";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n";

        _prompts = new List<string>
        {
            "---Think of a time when you stood up for someone else.---",
            "---Think of a time when you did something really difficult.---",
            "---Think of a time when you helped someone in need.---",
            "---Think of a time when you did something truly selfless.---"
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Getting ready!");
        SpinnerGenerator.GenerateSpinner(10);
        Console.WriteLine();
        DisplayRandomPrompt();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            DisplayRandomQuestion();
            Console.Write("> ");
            Console.ReadLine();
        }

        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
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
        Console.Write("Get ready...");
        ShowCountDown(5);

        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        List<int> indexArray = new List<int>();
        if (indexArray.Count() == _questions.Count)
        {
            indexArray.Clear();
        }

        Random random = new Random();
        int randomIndex = random.Next(_questions.Count);


        while (indexArray.Contains(randomIndex))
        {
            randomIndex = random.Next(_questions.Count);
        }

        indexArray.Add(randomIndex);
        string randomQuestion = _questions[randomIndex];
        return randomQuestion;


    }

    public void DisplayRandomPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
    }

    public void DisplayRandomQuestion()
    {
        string question = GetRandomQuestion();
        Console.WriteLine(question);
    }
}

