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
        private int ID;
        private string title;
        private int[] ratings;
        private bool isAvailable;

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
    }
}
