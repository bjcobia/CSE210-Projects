public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        string studentName = GetStudentName();
        string topic = GetTopic();
        return $"{_title} by {studentName}\n{topic}";
    }
}