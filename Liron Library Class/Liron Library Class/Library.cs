using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Liron_Library_Class
{
    class Library
    {
        List<Bookshelf> bookshelves = new List<Bookshelf>();

        public List<string> GetBookshelfInfo(int index)//returns the list of books infos
        {
            List<string> bookInfo = new List<string>();
            for (int i = 0; i < bookshelves[index].books.Count; i++)
            {
                bookInfo.Add(bookshelves[index].GetBookInfo(i));
            }

            return bookInfo;
        }

        //Function that returns the bookshelf

        public Bookshelf GetBookshelf(int index)
        {
            return bookshelves[index];
        }

        public void AddBookshelf(Bookshelf bookshelf/*Bookshelf*/)
        {
            bookshelves.Add(bookshelf);
        }

        public void RemoveBookshelf(int index)
        {
            bookshelves.RemoveAt(index);
        }


    }
}
