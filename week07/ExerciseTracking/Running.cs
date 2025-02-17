class Running : Activity
{
    private double _distance;
    public Running(double distance, int length) 
        : base(length) 
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return Math.Round(_distance/1000, 1);
    }

    public override double GetSpeed()
    {
        double speed = Math.Round((GetDistance()/_length)*60,1);
        return speed;
    }
    public override double GetPace()
    {
        double pace = Math.Round((_length/GetDistance()),1);
        return pace;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{_date} Running ({_length} min): Distance {GetDistance()}km, Speed:{GetSpeed()}kph, Pace: {GetPace()} min per km ");
    }
}


