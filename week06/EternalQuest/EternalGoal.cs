class EternalGoal : Goal
{

    public EternalGoal() : base()
    {

    }
    public override void RecordEvent()
    {
        
    }
    public override bool IsComplete()
    {
        return base.IsComplete();
    }
    public override string GetStringRepresentation()
    {
        return$"Eternal Goal:, {_shortName}, {_description}, {_points}";

    }
}
