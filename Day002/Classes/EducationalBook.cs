namespace Day002.Classes;

public class EducationalBook : Book
{
    private string _subject;

    public EducationalBook(string title, string genre, string author, string subject)
            : base(title, genre, author)
    {
        _subject = subject;
    }

    public string subject { get{ return _subject; } }
}