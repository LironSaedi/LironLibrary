using System;

namespace Liron_Library_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //Library
            //Library has bookshelves inside of it
            //Add and remove bookshelves into the library and get the current ones

            //Bookshelves
            //Bookshelves have Books inside of them
            //Get books inside of bookshelves.  Add and remove them

            //Books
            //Books have an author, title, page count
            //Get the author, Get the title, Get the page count

            //Program
            //display all the bookshelves and ask the user which they want to view
            //View all the books and then give them an option to checkout a book


            //Make your library and bookshelves and add boks to it

            //Library lb = new Library();
            //lb.AddBookshelf(new Bookshelf());
            //lb.GetBookshelf(0).AddBook("test", 10, "test");

            Library library = new Library();
            library.AddBookshelf(new Bookshelf());
            library.AddBookshelf(new Bookshelf());
            library.AddBookshelf(new Bookshelf());

            library.GetBookshelf(0).AddBook("Green Eggs and Ham", 25, "Dr. Seuss");
            library.GetBookshelf(0).AddBook("1 Fish 2 Fish Red Fish Blue Fish", 30, "Dr. Seuss");
            library.GetBookshelf(0).AddBook("Hop on Pop", 27, "Dr. Seuss");

            library.GetBookshelf(1).AddBook("Percy Jackson And the Lightening Theif", 350, "Rick Riordan");
            library.GetBookshelf(1).AddBook("Percy Jackson And The Sea of Monsters", 400, "Rick Riordan");
            library.GetBookshelf(1).AddBook("Percy Jackson and the Titans Curse", 450, "Rick Riordan");

            library.GetBookshelf(2).AddBook("Julius Ceaser", 250, "William Shakespear");
            library.GetBookshelf(2).AddBook("Macbeth", 375, "William Shakespear");
            library.GetBookshelf(2).AddBook("THe Biography of Abraham Lincoln", 578, "Chris Mansourian");

            while (true)
            {
                Console.WriteLine("Welcome to the Library.");
                for (int i = 0; i < library.bookshelves.Count; i++)
                {
                    Console.WriteLine($"{i}");
                }

                Console.WriteLine("Which Bookshelf would  you like to view more information on?");
                int userNum = int.Parse(Console.ReadLine());

                if (userNum > library.bookshelves.Count)
                {
                    Console.WriteLine("Please Enter A Correct Number");

                    break;
                }
            }
            //Console.WriteLine($"{}")
            /// Get the bookshelf and its nothing inside of it.
            /// Display all of the information.
        }
    }
}
