class Cycling : Activity
{
    private double _speed;
    public Cycling(double speed, int length) 
        : base(length) 
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return Math.Round((_length/60)*GetSpeed(), 1);
    }

    public override double GetSpeed()
    {
        double speed = Math.Round(_speed,1);
        return speed;
    }
    public override double GetPace()
    {
        double pace = Math.Round(_length/GetDistance());
        return pace;
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{_date} Cycling: ({_length} min): Distance {GetDistance()}km, Speed:{GetSpeed()}kph, Pace: {GetPace()} min per km ");
    }
}


