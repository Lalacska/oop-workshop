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
        public void Download(int ID)
        {
            this.ID = ID;
        }
        public void Rate(int rating)
        {
            
        }
        public bool IsAvailable()
        {
            return isAvailable;
        }
        public int[] GetRating(int ID)
        {
            this.ID = ID;
            return ratings;
        }
        public string GetTitle()
        {
            return title;
        }
        public int GetID()
        {
            return ID;
        }
    }
}
