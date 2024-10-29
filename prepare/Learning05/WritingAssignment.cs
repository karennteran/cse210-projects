public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }

    // Option 1: Make GetStudentName() public in base class if _studentName is private
    public string GetStudentName()
    {
        return _studentName;
    }

    // OR Option 2: Change _studentName to protected in base class
}
