using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OOPworkshop.Domain.User
{
    public abstract class User
    {
        string name;
        int age;
        int socialSecurityNumber;

        public User(string name, int age, int socialSecurityNumber)
        {
            this.name = name;
            this.age = age;
            this.socialSecurityNumber = socialSecurityNumber;
        }

    }
    public class Borrower : User
    {
        public Borrower(string name, int age, int socialSecurityNumber)
            : base(name, age, socialSecurityNumber) { }
        void ListMediaByType()
        { }
        void PreveiwMedia(Media media)
        {
            Console.WriteLine(media.GetInformation());
        }
        void RateMedia(Media media)
        {
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
        void InteractWithMedia()
        {

        }
    }
    public class Employee : User
    {
        public Employee(string name, int age, int socialSecurityNumber)
            : base(name, age, socialSecurityNumber) { }

    }
    public class Admin : User
    {
        public Admin(string name, int age, int socialSecurityNumber)
            : base(name, age, socialSecurityNumber) { }
    }
}
