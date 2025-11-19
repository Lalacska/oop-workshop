using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using OOPworkshop.Domain.Media;

namespace OOPworkshop.Domain.User
{
    public class UserDatabase 
    {
        Dictionary<int,User> userDatabase;
        public UserDatabase() { userDatabase = new Dictionary<int, User>(); }
        public void AddUser(User user) { userDatabase.Add(user); }
        public void RemoveUser(User user) { userDatabase.Remove(user); }
        public void GetUser(User user) { }
    }
    public abstract class User
    {
        protected MediaCollection mediaCollection;
        protected string name;
        protected int age;
        protected int socialSecurityNumber;

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
        void ListMediaByType<T>(T MediaType)
        {
            foreach (Media media in mediaCollection.libary) 
            { 
                if(media.GetType() == MediaType)
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
    public class Employee : User
    {
        public Employee(string name, int age, int socialSecurityNumber)
            : base(name, age, socialSecurityNumber) { }
        void AddMedia(int ID)
        {
            mediaCollection.AddMedia(ID);
        }
        void RemoveMedia(int ID)
        {
            mediaCollection.RemoveMedia(ID);
        }
    }
    public class Admin : User
    {
        public Admin(string name, int age, int socialSecurityNumber)
            : base(name, age, socialSecurityNumber) { }
        void AddMedia (int ID) 
        { 
            mediaCollection.AddMedia(ID);
        }
        void RemoveMedia(int ID) 
        { 
            mediaCollection.RemoveMedia(ID);
        }
        void ViewMedia() { }
        void AddUser() { }
    }
}
