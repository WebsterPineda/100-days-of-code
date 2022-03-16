using Day002.Classes;

Book book = new Book("Last mile", "Novel", "Jphn Doe");
Console.WriteLine("Hello, World! today was about SOLID Principle");
Console.WriteLine("Already get a read off SO,");

BookPrinter.printToConsole(book);
book = (Book) new EducationalBook("Spanish 3", "Educational", "ESA", "Language");
BookPrinter.printToConsole(book);
