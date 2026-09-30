using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
       _title = title;
    }


    public string SetTitle(string title)
    {
        _title = title;
        return _title;
    }

    public string GetWritingInformation()
    {
        return $"{_title}";
    }

}