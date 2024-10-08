namespace Library
{
    class Book
    {
        private string title;
        private string author;   //store 3 pieces of data about the book
        private string isbn;
        private int noofpages;

        public string Title
        {
            get { return title; }  // get method
            set { title = value; } // set method
        }

        public string Author
        {
            get { return author;  }
            set { author = value; }
        }

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public int NoOfPages
        {
            get { return noofpages; }
            set { noofpages = value; }
        }

        public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages)
        {
            title = bookTitle;
            author = bookAuthor;
            isbn = bookISBN;
            noofpages = bookNoOfPages;
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