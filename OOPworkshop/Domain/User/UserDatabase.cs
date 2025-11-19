using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPworkshop.Domain.Media;
using OOPworkshop.Domain.LibrarySystem;

namespace OOPworkshop.Domain.User
{
    public class UserDatabase
    {
        protected Dictionary<int, User> users;
        public UserDatabase() { users = new Dictionary<int, User>(); }
        protected void AddUser(int SSN, User user) { users.Add(SSN, user); }
        protected void RemoveUser(int SSN) { users.Remove(SSN); }
        protected User GetUser(int SSN)
        {
            if (users.TryGetValue(SSN, out User user))
                return user;
            else
                return null;
        }
    }
}
