using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using OOPworkshop.Domain.Media;

namespace OOPworkshop.Domain.User
{
    public abstract class User
    {
        protected MediaCollection mediaCollection;
        protected string name;
        protected int age;

        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
