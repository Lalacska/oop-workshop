using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPworkshop.Domain.Media
{
    public abstract class Media
    {
        public int ID;
        public string title;
        public int[] ratings;
        public bool isAvailable;

        public Media(int ID, string title, int[] ratings, bool isAvailable)
        { 
            this.ID = ID;
            this.title = title;
            this.ratings = ratings;
            this.isAvailable = isAvailable;
        }
        public void Borrow(int ID)
        {
            this.ID = ID;
        }
        public void Return(int ID)
        {
            this.ID = ID;
        }

        public void Download(int ID)
        {
            this.ID = ID;
        }
        public void Rate(int rating)
        {
            
        }
        public string GetInformation(int ID)
        {
            this.ID = ID;
        }
        public bool IsAvailable(Media media)
        {
             
        }
        public int GetRating(int ID)
        {
            this.ID = ID;
        }
        public string GetTitle(Media media)
        {
            return title;
        }
    }
}
