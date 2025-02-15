using System.Security.Cryptography.X509Certificates;

abstract class Goal{
    protected string _shortName;
    protected string _description;
    protected string _points;
    protected bool _isComplete;

    public Goal()
    {

    }

    public string Name
    {
        get { return _shortName; }
        set { _shortName = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public string Points
    {
        get { return _points; }
        set { _points = value; }
    }

     public string isComplete
    {
        get { return _isComplete.ToString(); }
        set { _isComplete = bool.Parse(value); }
    }

    public virtual void RecordEvent()
    {
        int points = int.Parse(_points);
    }
    public virtual bool IsComplete()
    {
        return _isComplete;
    }
    public virtual string GetDetailString()
    {
        if(IsComplete() == false)
        {
           return $"[ ] {_shortName} ({_description})";
        } else
        {
            return $"[X] {_shortName} ({_description})";
        }
    }
    public abstract string GetStringRepresentation();


}