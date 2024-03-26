
public class Video
{
    private string Title { get; }
    private string Author { get; }
    private int LengthSeconds { get; }
    private List<Comment> Comments { get; }

    public Video(string title, string author, int lengthSeconds)
    {
        Title = title;
        Author = author;
        LengthSeconds = lengthSeconds;
        Comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string text)
    {
        Comments.Add(new Comment(commenterName, text));
    }

    public int GetNumComments()
    {
        return Comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Length (seconds): " + LengthSeconds);
        Console.WriteLine("Number of comments: " + GetNumComments());
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Commenter: " + comment.CommenterName);
            Console.WriteLine("Text: " + comment.Text);
        }
        Console.WriteLine("================");
    }
}