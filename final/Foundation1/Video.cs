using System;
using System.Collections.Generic;
using System.Text; // Add this for StringBuilder

public class Video
{
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    private string Title { get; set; }
    private string Author { get; set; }
    private int Length { get; set; }
    private List<Comment> Comments { get; set; }

    public void AddComment(string commenter, string text)
    {
        Comment comment = new Comment(commenter, text);
        Comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public string GetVideoInfo()
    {
        StringBuilder info = new StringBuilder();
        info.AppendLine($"Title: {Title}");
        info.AppendLine($"Author: {Author}");
        info.AppendLine($"Length (seconds): {Length}");
        info.AppendLine($"Number of Comments: {GetNumberOfComments()}");
        info.AppendLine("Comments:");
        foreach (var comment in Comments)
        {
            info.AppendLine(comment.GetCommentInfo());
        }
        return info.ToString();
    }
}
