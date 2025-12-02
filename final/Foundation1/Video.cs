using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _duration;
    private List<Comment> _comments;


    public Video(string title, string author, int duration)
    {
        _title = title;
        _author = author;
        _duration = duration;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayVideo(bool includeComments)
    {
        Console.WriteLine($"Video: {_title} {_author} {_duration}");
        if (includeComments)
        {
            DisplayComments();
        }
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}