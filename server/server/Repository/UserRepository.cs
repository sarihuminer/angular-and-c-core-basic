using server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Repository
{
    //public sealed partial class UserRepository : IUserRepository
    public class UserRepository : IUserRepository
    {
        public UserModel GetUserName(string ID)
        {
            UserModel user = new UserModel();
            user.ID = ID;
            user.Name = "riki";
            return user;
        }
        public void Add(UserModel user)
        {
        }
    }
}
