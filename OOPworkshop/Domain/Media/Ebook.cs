using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPworkshop.Domain.Media
{
    public class Ebook : Media
    {
        private string author;
        private string language;
        private int numberOfPages;
        private int yearOfPublication;
        private int ISBN;


        public Ebook(int ID, string title, int[] ratings, bool isAvailable, string author, string language, int numberOfPages, int yearOfPublication, int ISBN) : base(ID, title, ratings, isAvailable)
        {
            this.author = author;
            this.language = language;
            this.numberOfPages = numberOfPages;
            this.yearOfPublication = yearOfPublication;
            this.ISBN = ISBN;
        }

        public void Read()
        {
            if (isAvailable == true)
            {
                Console.WriteLine("You can now read the book");
            }
        }

        public override string ToString()
        {
            return "Title of book: " + GetTitle() + " Author: " + author + " Number of pages: " + numberOfPages+  " Language: " +language+ " Year of publication: " +yearOfPublication+ " ISBN: " + ISBN;
        }
    }
}
