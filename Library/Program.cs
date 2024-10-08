class Book
{
    string Title;
    string Author;   //store 3 pieces of data about the book
    string ISBN;
    int NoOfPages;

    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        NoOfPages = bookNoOfPages;
    }

    void DisplayInfo()   //method called DisplayInfo inside class Book
    {
        Console.WriteLine("Book Information");
        Console.WriteLine("----------------------");
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book author: {Author}");  //refer to variables
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine($"Book Pages: {NoOfPages}");
        Console.WriteLine();
    }


    static void Main(string[] args)
    {
        //create a new instance of the book class and call it book
        //book has access to the 3 strings
        Book book = new Book("C# for beginners", "Bill Gates", "1234567", 200);

        Book book2 = new Book("C# methods and classes", "Microsoft", "7578953", 50);
        

        book.DisplayInfo(); 
        book2.DisplayInfo();      //output the book and book2 info to console from DisplayInfo();

    }
}
