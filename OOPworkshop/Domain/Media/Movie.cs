using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPworkshop.Domain.Media
{
    public class Movie :Media
    {
        private string director;
        private string genre;
        private int releaseYear;
        private string language;
        private double duration; 

        public Movie(int ID, string title, int[] ratings, bool isAvailable, string director, string genre, int releaseYear, string language, double duration) : base(ID, title, ratings, isAvailable)
        {
            this.director = director;
            this.genre = genre;
            this.releaseYear = releaseYear;
            this.language = language;
            this.duration = duration;
        }

        public void Watch()
        {

        }
    }

}
