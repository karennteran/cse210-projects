public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();       // Method for recording an event
    public abstract bool IsComplete();         // Method to check if the goal is complete
    public abstract string GetDetailsString(); // Method to get goal details as a string
    public abstract string GetStringRepresentation(); // Method for serialization

    public int Points => _points;             // Public property for points (read-only)
}

