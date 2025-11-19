using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPworkshop.Domain.Media
{
    public class VideoGame : Media
    {
        private string genre;
        private string publisher;
        private int yearOfRelease;
        private string[] supportedPlatforms;
        private string language; 

        public VideoGame(int ID, string title, int[] ratings, bool isAvailable, string genre, string publisher, int yearOfRelease, string[] supportedPlatforms, string language) : base(ID, title, ratings, isAvailable)
        {
            this.genre = genre;
            this.publisher = publisher;
            this.yearOfRelease = yearOfRelease;
            this.supportedPlatforms = supportedPlatforms;
            this.language = language;
        }

        public void Play()
        {

        }
        public void Complete()
        {

        }
    }
}
