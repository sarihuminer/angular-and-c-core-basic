using server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Repository
{
    public interface IUserRepository
    {
         UserModel GetUserName(string ID);
        void Add(UserModel user);
    }
}
