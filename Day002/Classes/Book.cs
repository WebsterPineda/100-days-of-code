namespace Day002.Classes;

public class Book
{
    private string _title;
    private string _genre;
    private string _author;

    public Book(string title, string genre, string author)
    {
        _title = title;
        _genre = genre;
        _author = author;
    }

    public string title { get {return _title;}}
    public string genre { get {return _genre;}}
    public string author { get {return _author;}}
}