using Rbc.Hologram.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rbc.Hologram.Data.ContextInterfaces
{
    public interface IUserContext
    {
        User Get(int userId);
        List<User> Get(string userId);
        User Get(string username, string password);
        int Save(User user);

    }
}
