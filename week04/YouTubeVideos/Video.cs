public class Video
{
    private string _author;
    private string _title;
    private int _length;//seconds
    List<Comment> _comments;
    public Video(string author, string title, int length)
    {
        _author = author;
        _title = title;
        _length = length;
        _comments = new List<Comment>();
    }
    public int CountComments()
    {
        int CommentLength = _comments.Count;
        return CommentLength;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public void DisplayVideo()
    {
        Console.WriteLine($"Author: {_author}\nTitle: {_title}\nLenght of the Video: {_length}");
        Console.WriteLine(".-.-.-.-.-.-.-.");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}