using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPworkshop.Domain.Media
{
    public class Song : Media
    {
        private string genre;
        private string composer;
        private string singer;
        private string fileType;
        private double duration;
        private string language; 

        public Song(string genre, string composer, string singer, string fileType, double duration, string language)
        {
            this.genre = genre;
            this.composer = composer;
            this.singer = singer;
            this.fileType = fileType;
            this.duration = duration;
            this.language = language;
        }

        public void Play()
        {

        }
    }
}
