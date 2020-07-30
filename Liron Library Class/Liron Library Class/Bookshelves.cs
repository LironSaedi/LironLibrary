using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Liron_Library_Class
{

    class Bookshelf
    {
        List<Book> books = new List<Book>();

        public string GetBookInfo(int index)
        {
            string info;

            info = "Title: ";
            info += books[index].GetName();
            info += " Author: ";
            info += books[index].GetAuthor();
            info += " PageCount: ";

            info += books[index].GetPageCount();

            return info;
        }

        public void AddBook(string name, int pagecount, string author)
        {
            
            books.Add(new Book(name, pagecount, author));
        }

        public void RemoveBook(int index)
        {
            books.RemoveAt(index);
        }
    }
}
