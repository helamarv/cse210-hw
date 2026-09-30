using System;

public class Comment
{
    public string _author { get; set; }
    public string _text { get; set; }

    //connect the comment to the video
    public Video _video { get; set; }

    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Comment: {_text}");
    }
}