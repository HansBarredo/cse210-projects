class Swimming : Activity
{
    private int _laps;
    public Swimming(int laps, int length) 
        : base(length) 
    {
        _laps = laps;
    }

   public override double GetDistance()
    {
       return Math.Round(_laps * (50.0 / 1000), 1); 
         
    }

    public override double GetSpeed()
    {
        double speed = Math.Round((GetDistance()/_length)*60,1);
        return speed;
    }
    public override double GetPace()
    {
        return Math.Round(_length/ GetDistance(), 1);
    }

    public override void DisplaySummary()
    {
        Console.WriteLine($"{_date} Swimming: ({_length} min): Distance {GetDistance()}km, Speed:{GetSpeed()}kph, Pace: {GetPace()} min per km ");
    }
}


