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


        public Ebook(string author, string language, int numberOfPages, int yearOfPublication, int iSBN)
        {
            this.author = author;
            this.language = language;
            this.numberOfPages = numberOfPages;
            this.yearOfPublication = yearOfPublication;
            this.ISBN = iSBN;
        }

        public void Read()
        {

        }
        public override string ToString()
        {

        }
    }
}
