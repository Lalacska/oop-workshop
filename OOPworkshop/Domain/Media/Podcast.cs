using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPworkshop.Domain.Media
{
    public class Podcast : Media
    {
        private int releaseYear;
        private string[] hosts;
        private string[] guests;
        private int episodeNumber;
        private string language;

        public Podcast(int ID, string title, int[] ratings, bool isAvailable, int releaseYear, string[] hosts, string[] guests, int episodeNumber, string language) : base(ID, title, ratings, isAvailable)
        {
            this.releaseYear = releaseYear;
            this.hosts = hosts;
            this.guests = guests;
            this.episodeNumber = episodeNumber;
            this.language = language;
        }
        public void Listen()
        {

        }
        public void Complete()
        {

        }
    }
}
