public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true; // Mark the goal as complete
    }

    public override bool IsComplete() => _isComplete;

    public override string GetDetailsString() => $"{_shortName} - {_description} (Simple Goal) - {(IsComplete() ? "[X]" : "[ ]")}";

    public override string GetStringRepresentation() => $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
}

