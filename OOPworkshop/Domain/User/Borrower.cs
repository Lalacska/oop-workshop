using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPworkshop.Domain.Media;

namespace OOPworkshop.Domain.User
{
    public class Borrower : User
    {
        public Borrower(string name, int age) : base(name, age) { }
        void ListMediaByType<T>(T MediaType)
        {
            foreach (Media media in MediaCollection.libary)
            {
                if (media.GetType() == MediaType)
                    Console.WriteLine(media.ToString());
            }
        }
        void PreveiwMedia(int ID)
        {
            Console.WriteLine(mediaCollection.FindMedia(ID).ToString());
        }
        void RateMedia(int ID, int rating)
        {
            if (rating == null || rating < 0 || rating > 10)
                Console.WriteLine("Rating must be between 1-10");
            else
                mediaCollection.FindMedia(ID).Rate(rating);
        }
        void InteractWithMedia(int ID)
        {
            media = mediaCollection.FindMedia(ID);
            switch (media)
            {
                case media == Media.Ebook:
                    media.Read();
                    break;
                case media == Media.Image:
                    media.Display();
                    break;
                case media == Media.Movie:
                    media.Watch();
                    break;
                case media == Media.Song:
                    media.Play();
                    break;
                case media == Media.Videogame:
                    media.Play();
                    break;
                case media == Media.App:
                    media.Execute();
                    break;
                case media == Media.Podcast:
                    media.Listen();
                    break;
            }
        }
    }
}
