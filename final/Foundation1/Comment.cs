using System.Security.Cryptography.X509Certificates;

public class Comment
{
    private string _name;
    private string _comment;

    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    public void Display()
    {
        Console.WriteLine($"Comment: {_name} {_comment}");
    }
}