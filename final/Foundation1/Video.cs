// Video.cs
using System;
using System.Collections.Generic;

public class Video {
    public Video(string title, string author, int length) {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public string Title { get; }
    public string Author { get; }
    public int Length { get; }
    public List<Comment> Comments { get; }

    public void AddComment(string commenter, string text) {
        Comment comment = new Comment(commenter, text);
        Comments.Add(comment);
    }

    public int GetNumberOfComments() {
        return Comments.Count;
    }

    public void DisplayInfo() {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length (seconds): {Length}");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments) {
            Console.WriteLine($"{comment.Commenter}: {comment.Text}");
        }
    }
}
