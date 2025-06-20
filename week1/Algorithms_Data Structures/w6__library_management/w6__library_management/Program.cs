using System;

namespace w6__library_management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[]
            {
                new Book { BookId = 1, Title = "C# Fundamentals", Author = "John Doe" },
                new Book { BookId = 2, Title = "AI with Python", Author = "Jane Smith" },
                new Book { BookId = 3, Title = "Machine Learning", Author = "Tom Johnson" },
                new Book { BookId = 4, Title = "Data Structures", Author = "Alice White" },
                new Book { BookId = 5, Title = "Algorithms", Author = "Bob Brown" }
            };

            Array.Sort(books, (a, b) => a.Title.CompareTo(b.Title));

            Library library = new Library();

            Console.WriteLine("All Books (Sorted):");
            library.PrintBooks(books);

            Console.WriteLine("\n🔍 Linear Search for 'AI with Python':");
            var result1 = library.LinearSearch(books, "AI with Python");
            Console.WriteLine(result1 != null ? $"Found: {result1.Title} by {result1.Author}" : "Book not found");

            Console.WriteLine("\n🔍 Binary Search for 'Data Structures':");
            var result2 = library.BinarySearch(books, "Data Structures");
            Console.WriteLine(result2 != null ? $"Found: {result2.Title} by {result2.Author}" : "Book not found");
        }
    }
}
