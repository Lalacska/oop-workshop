using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPworkshop.Domain.Media;

namespace OOPworkshop.Domain.User
{
    public class Employee : User
    {
        public Employee(string name, int age) : base(name, age) { }
        void AddMedia(int ID)
        {
            .AddMedia(ID);
        }
        void RemoveMedia(int ID)
        {
            mediaCollection.RemoveMedia(ID);
        }
    }
}
