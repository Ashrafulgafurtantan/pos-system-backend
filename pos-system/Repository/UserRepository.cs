using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pos_system.Model;

namespace pos_system.Repository
{
    public class UserRepository : DatabaseRepository
    {
        public bool Add(User user)
        {
            if (IsFound(user.username))
                return false;

            DatabaseContext.Users.Add(user);
            DatabaseContext.SaveChanges();
            return true;
        }

        public bool Login(User user)
        {
            foreach (var temp in DatabaseContext.Users)
            {
                if (user.username == temp.username && user.password == temp.password)
                    return true;
            }
            return false;
        }

        public bool IsFound(string username)
        {
            foreach (var user in DatabaseContext.Users)
            {
                if (user.username == username)
                    return true;
            }

            return false;
        }

        public User Search(string username)
        {
            foreach (var user in DatabaseContext.Users)
            {
                if (user.username == username)
                    return user;
            }

            return null;
        }





        public User Update(User user)
        {
            DatabaseContext.Users.Update(user);
            DatabaseContext.SaveChanges();
            return user;
        }

    }
}
