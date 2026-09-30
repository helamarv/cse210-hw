using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {

        _textbookSection = textbookSection;
        _problems = problems;
    }


    public string SetTextbookSection(string textbookSection)
    {
        _textbookSection = textbookSection;
        return _textbookSection;
    }

    public string SetProblems(string problems)
    {
        _problems = problems;
        return _problems;
    }
    public string GetHomeworkList()
    {
        return $"{_textbookSection} - {_problems}";
    }

}