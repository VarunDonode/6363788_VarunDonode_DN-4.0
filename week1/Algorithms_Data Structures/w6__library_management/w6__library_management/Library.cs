using System;

namespace w6__library_management
{
    public class Library
    {
        public Book LinearSearch(Book[] books, string title)
        {
            foreach (var book in books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    return book;
                }
            }
            return null;
        }

        public Book BinarySearch(Book[] books, string title)
        {
            int left = 0, right = books.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                int comparison = string.Compare(books[mid].Title, title, StringComparison.OrdinalIgnoreCase);

                if (comparison == 0)
                    return books[mid];
                else if (comparison < 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return null;
        }

        public void PrintBooks(Book[] books)
        {
            foreach (var book in books)
            {
                Console.WriteLine($"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}");
            }
        }
    }
}
