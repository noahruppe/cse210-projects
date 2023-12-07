public class Comment
{
    private string Commenter { get; }
    private string Text { get; }

    public Comment(string commenter, string text)
    {
        Commenter = commenter;
        Text = text;
    }

    public string GetCommentInfo()
    {
        return $"{Commenter}: {Text}";
    }
}
