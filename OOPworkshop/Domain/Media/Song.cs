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

        public Song(int ID, string title, int[] ratings, bool isAvailable, string genre, string composer, string singer, string fileType, double duration, string language) : base(ID, title, ratings, isAvailable)
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
            Console.WriteLine("Play the song now");
        }
        public override string ToString()
        {
            return "Title of song: " + GetTitle() + " Composer: " + composer + " Singer: " + singer + " Genre: " + genre + " Duration: " + duration + " Language: " + language + " File type: " + fileType;
        }
    }
}
