public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment()
    {
        _topic = "unknown";
        _studentName = "unknown";
    }
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public void GetSummary()
    {
        Console.WriteLine($"{_studentName} - {_topic}");
    }


}