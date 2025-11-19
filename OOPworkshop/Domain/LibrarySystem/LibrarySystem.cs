using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPworkshop.Domain.User;
using OOPworkshop.Domain.Media;

namespace OOPworkshop.Domain.LibrarySystem
{
    class LibrarySystem
    {
        MediaCollection mediaCollection;
        UserDatabase userDatabase;
        public LibrarySystem () 
        { 
            mediaCollection = new MediaCollection ();
            userDatabase = new UserDatabase();
        }
    }

}
