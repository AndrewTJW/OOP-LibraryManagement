using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Revise
{
    internal class Author
    {
        public string author_name { get; set; }
        public string author_country { get; set; }

        public Author(string a_author_name, string a_author_country)
        {
            author_name = a_author_name;
            author_country = a_author_country;
        }

        public Author() { }
    }
}
