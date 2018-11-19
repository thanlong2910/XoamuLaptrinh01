using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStructLab02
{
    // Create struct Books: title, author, subject, bookID

    // define a structure
    public struct Books
    {
        public string bookTitle;
        public string bookAuthor;
            public string bookSubject;
            public int bookID;

            //Constructor
            public Books(string tempTitle, string tempAuthor, string tempSubject, int tempID)
            {
                bookTitle = tempTitle;
                bookAuthor = tempAuthor;
                bookSubject = tempSubject;
                bookID = tempID;
            }

            public void DisplayBookInfo()
        {
            Console.WriteLine("Book Title:  {0}", bookTitle);
            Console.WriteLine("Book Author:  {0}", bookAuthor);
            Console.WriteLine("Book Subject:  {0}", bookSubject);
            Console.WriteLine("Book ID:  {0}", bookID);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Books book1, book2;
            book1 = new Books();
            book1.bookTitle = "C# Programming";
            book1.bookAuthor = "IT Author";
            book1.bookSubject = "C# Tutorial";
            book1.bookID = 1;
            book1.DisplayBookInfo();

            book2 = new Books("Python Programming", "Python Author", "Python Tutorial", 2);
            book2.DisplayBookInfo();

            Console.ReadLine();
        }
    }
}
