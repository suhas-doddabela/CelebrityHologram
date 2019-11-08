using Rbc.Hologram.Data.ContextInterfaces;
using Rbc.Hologram.Data.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Data.Contexts
{
    public class UserContext : IUserContext
    {
        public User Get(int userId)
        {
            using (var c = new CelebrityHologramContext())
            {
                return c.User.FirstOrDefault(u => u.UserId == userId);
            }
        }

        public List<User> Get(string username)
        {
            using (var c = new CelebrityHologramContext())
            {
                return c.User.Where(u => u.UserName == username).ToList();
            }
        }

        public User Get(string username, string password)
        {
            using (var c = new CelebrityHologramContext())
            {
                return c.User.FirstOrDefault(u => u.UserName ==  username && u.Password == password);
            }
        }

        public int Save(User user)
        {
            using (var c = new CelebrityHologramContext())
            {
                c.User.Add(user);
                return c.SaveChanges();
            }
        }
    }
}
