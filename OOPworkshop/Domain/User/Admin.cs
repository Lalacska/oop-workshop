using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPworkshop.Domain.Media;
using OOPworkshop.Domain.LibrarySystem;

namespace OOPworkshop.Domain.User
{
    public class Admin
    {
        public class Admin : User
        {
            public Admin(string name, int age, int socialSecurityNumber)
                : base(name, age, socialSecurityNumber) { }
            void AddMedia(int ID)
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
}
