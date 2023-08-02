namespace ConsoleApp_HommeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookList bookList = new BookList();
            // Adding books to the list
            Books book1 = new Books("Harry Potter", "J.K. Rowling", "Fantasy", 1997, 223, 100);
            Books book2 = new Books("The Lord of the Rings", "J.R.R. Tolkien", "Fantasy", 1954, 1178, 200);
            Books book3 = new Books("The Hobbit", "J.R.R. Tolkien", "Fantasy", 1937, 310, 150);
            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);
            bookList.Print();
            // // Checking the number of books in the list
            Console.WriteLine($"Count of books: {bookList.Count}");
            // Remove the book from the list
            bookList.Remove(book1);
            //check if the book is in the list
            if (bookList.Contains(book1))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The book {book1.Name} is on the list");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The book {book1.Name} is not listed");
            }
            Console.ResetColor();
            bookList.Print();
        }
    }
}