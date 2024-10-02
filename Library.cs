using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Revise
{
    internal class Library
    {
        private List<Book> LibraryBooks;

        public Library ()
        {
            LibraryBooks = new List<Book>();
        }

        public void AddBooks (Book a_book)
        {
            LibraryBooks.Add(a_book);
        }

        public void RemoveBook (Book a_book)
        {
            LibraryBooks.Remove(a_book);
        }

        public void DisplayBookTitle ()
        {
            foreach (Book var_book in LibraryBooks)
            {
                Console.WriteLine(var_book.book_title);
            }
        }

        public Book findBookID (int book_id)
        {
            for (int i = 0; i < LibraryBooks.Count(); i++)
            {
                if (LibraryBooks[i].book_id == book_id)
                {
                    return LibraryBooks[i];
                }
            }
            return null;
        }
    }
}
