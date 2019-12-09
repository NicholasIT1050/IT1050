using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7
{
    class BookTest
    {

        private string Title;
        private string Author;
        private int Year;
        public BookTest(string Title, string Author, int Year)
        {
            this.Title = Title;
            this.Author = Author;
            this.Year = Year;
        }
        public void Display()
        {
            Console.WriteLine("{0} was written by {1} released in {2}", Title, Author, Year);
        }
    }
} 