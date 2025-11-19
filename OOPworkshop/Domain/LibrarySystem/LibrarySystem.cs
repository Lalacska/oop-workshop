using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPworkshop.Domain.User;
using OOPworkshop.Domain.Media;

namespace OOPworkshop.Domain.LibrarySystem
{
    public class LibrarySystem
    {
        private static LibrarySystem _instance = new LibrarySystem();
        public static LibrarySystem Instance => _instance;

        public MediaCollection mediaCollection { get; }
        public UserDatabase userDatabase { get; }

        public LibrarySystem () 
        { 
            mediaCollection = new MediaCollection ();
            userDatabase = new UserDatabase();
        }
    }

}
