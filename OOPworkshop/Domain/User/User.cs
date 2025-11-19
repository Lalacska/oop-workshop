using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using OOPworkshop.Domain.Media;
using OOPworkshop.Domain.LibrarySystem;

namespace OOPworkshop.Domain.User
{
    public abstract class User
    {
        LibrarySystem system = LibrarySystem.Instance;
        var media = system.mediacollection;
        protected string name;
        protected int age;

        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
