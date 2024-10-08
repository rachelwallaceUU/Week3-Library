using Library;

    class Program
{ 

    static void Main(string[] args)
    {
        //create a new instance of the book class and call it book
        //book has access to the 3 strings
        Book book = new Book("C# for beginners", "Bill Gates", "1234567", 200);
        Book book2 = new Book("C# methods and classes", "Microsoft", "7578953", 50);
        Console.WriteLine("Currently available books");

        book.DisplayInfo(); 
        book2.DisplayInfo();      //output the book and book2 info to console from DisplayInfo();

        Member member = new Member(1, "John Smith", "1 High Street", 0790090090);
        Member member1 = new Member(2, "Mary Jones", "102 Garden Road", 0790345666);

        Console.WriteLine("Current library members");
        member.DisplayInfo();
        member1.DisplayInfo();
    }
}

