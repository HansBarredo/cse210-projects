abstract class Activity
{

    protected string _date = DateTime.Now.ToString("dddd, dd MMMM yyyy");
    protected int _length;
    public Activity( int length)
    {
        _length = length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract void DisplaySummary();
    // public virtual double GetDistance(double distance, int laps)
    // {
    //     return (distance * laps) / 1000;
    // }

    // public virtual double GetSpeed( double distance, int time)
    // {
    //     double speed = (GetDistance(_distance,_laps)/(time/60));
    //     return Math.Round(speed,1);
    // }

    //  public virtual double GetPace(double distance, int time)
    // {
    //     double timeDouble = (double)time;
    //     return (timeDouble / 60) / (distance / 1000);
    // }
    // public virtual void GetSummary()
    // {
    //     return;
    // }

    
}