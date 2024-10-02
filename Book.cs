using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Revise
{
    internal class Book
    {
        public int book_id { get; set; }
        public string book_title { get; set; }
        public Author book_author { get; set; }

        public Book (int a_book_id, string a_book_title, Author a_book_author)
        {
            book_id = a_book_id;
            book_title = a_book_title;
            book_author = a_book_author;
        }

        public Book() { }
    }
}
