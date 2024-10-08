namespace Library
{
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

        public void DisplayInfo()   //method called DisplayInfo inside class Book
        {
            Console.WriteLine("Book Information");
            Console.WriteLine("----------------------");
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book author: {Author}");  //refer to variables
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine($"Book Pages: {NoOfPages}");
            Console.WriteLine();
        }
    }
}