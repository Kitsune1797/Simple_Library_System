using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {

        Library library = new Library();

        // Add some books to the library
        library.AddBook("The Catcher in the Rye", "J.D. Salinger");
        library.AddBook("To Kill a Mockingbird", "Harper Lee");
        library.AddBook("1984", "George Orwell");

        // Search for books
        Console.Write("Enter a book title or author to search: ");
        string searchQuery = Console.ReadLine();
        var searchResults = library.SearchBooks(searchQuery);

        library.DisplayBooks(searchResults);

        // Register a borrowed book
        Console.Write("Enter the title of the book to register as borrowed: ");
        string borrowedBook = Console.ReadLine();
        library.RegisterBorrowedBook(borrowedBook);

        // Display updated book list
        library.DisplayBooks(library.SearchBooks(""));
        }
        
    }
}
