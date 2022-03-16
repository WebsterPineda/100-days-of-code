namespace Day002.Classes;

public class BookPrinter
{
    public static void printToConsole(Book book)
    {
        string text = "The book title is: " + book.title + ". It genre is: " + book.genre
            + ", and it was write by: " + book.author;

        Console.WriteLine(text);
    }
}