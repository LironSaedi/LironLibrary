using System;
using System.Collections.Generic;
using System.Text;

namespace Liron_Library_Class
{
    class Book
    {
        string name;
        int pagecount;
        string author;

        public Book(string name, int pagecount, string author)
        {
            this.name = name;
            this.pagecount = pagecount;
            this.author = author;
        }

        public string GetName()
        {
            return name;
        }

        public int GetPageCount()
        {
            return pagecount;
        }

        public string GetAuthor()
        {
            return author;
        }

    }
}
