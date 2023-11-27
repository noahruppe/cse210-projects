using System;

public class Comment {
    public Comment(string commenter, string text) {
        Commenter = commenter;
        Text = text;
    }

    public string Commenter { get; }
    public string Text { get; }
}
