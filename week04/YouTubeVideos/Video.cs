using System;
using System.Collections.Generic;

public class Video
{
    public string _title { get; set; }
    public string _author { get; set; }
    public int _length { get; set; }
    public List<Comment> _comments { get; set; }

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _length = lengthInSeconds;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment, Video video)
    {
        comment._video = video; // Associate the comment with the video
        _comments.Add(comment);
    }
   

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        int commentCount = GetCommentCount();
        Console.WriteLine($"Comments: ({commentCount})");
        foreach (var comment in _comments)
        {
            comment.DisplayComment();
            Console.WriteLine();
        }
    }

}