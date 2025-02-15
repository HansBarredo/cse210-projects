class ChecklistGoal : Goal
{
    protected int _amountCompleted;
    protected int _target;
    protected int _bonus;

    public ChecklistGoal() : base ()
    {

    }

    public string Target
    {
        get { return _target.ToString(); }
        set { _target = int.Parse(value); }
    }

    public string Bonus
    {
        get { return _bonus.ToString(); }
        set { _bonus = int.Parse(value); }
    }

    public string AmountCompleted
    {
        get { return _amountCompleted.ToString(); }
        set { _amountCompleted = int.Parse(value); }
    }

     public override void RecordEvent()
    {
        IsComplete();

        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
        
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public override string GetDetailString()
    {
        if(IsComplete() == false)
        {
           return $"[ ] {_shortName} ({_description}) [{_amountCompleted}/{_target}]";
        } else
        {
            return $"[X] {_shortName} ({_description}[{_amountCompleted}/{_target}])";
        }
    }
    public override string GetStringRepresentation()
    {
        return$"Simple Goal:, {_shortName}, {_description}, {_points}, {_amountCompleted}, {_target}, {IsComplete()}";

    }
}
