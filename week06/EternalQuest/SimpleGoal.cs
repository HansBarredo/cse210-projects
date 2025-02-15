class SimpleGoal : Goal
{

    public SimpleGoal() : base ()
    {

    }
     public override void RecordEvent()
    {
        _isComplete = true;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return$"Simple Goal:, {_shortName}, {_description}, {_points}, {IsComplete()},";

    }

}
