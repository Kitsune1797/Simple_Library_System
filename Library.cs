using System;
using System.Collections.Generic;
using System.Linq;

namespace MyDotNet
{
    internal class Library
        {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(string title, string author)
        {
            books.Add(new Book(title, author));
        }

        public List<Book> SearchBooks(string query)
        {
            return books.Where(book => book.Title.Contains(query) || book.Author.Contains(query)).ToList();
        }

        public void DisplayBooks(List<Book> bookList)
        {
            Console.WriteLine("Books in the library:");
            foreach (var book in bookList)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Borrowed: {(book.IsBorrowed ? "Yes" : "No")}");
            }
        }

        public void RegisterBorrowedBook(string title)
        {
            var book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                if (!book.IsBorrowed)
                {
                    book.IsBorrowed = true;
                    Console.WriteLine($"{book.Title} is now marked as borrowed.");
                }
                else
                {
                    Console.WriteLine($"{book.Title} is already borrowed.");
                }
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
    }
}
