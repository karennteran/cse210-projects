public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override void RecordEvent() { /* Logic for eternal goal */ }

    public override bool IsComplete() => false; // Never complete

    public override string GetDetailsString() => $"{_shortName} - {_description} (Eternal Goal)";
    
    public override string GetStringRepresentation() => $"EternalGoal:{_shortName},{_description},{_points}";
}


