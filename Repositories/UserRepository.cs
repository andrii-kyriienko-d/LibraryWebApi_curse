using LibraryWebApi.Models.AuthModels;
using LibraryWebApi.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace LibraryWebApi.Repositories
{
    internal sealed class UserRepository : IUserRepository
    {
        private readonly IEnumerable<UserDTO> users = new List<UserDTO>();

        public UserRepository()
        {
            users.ToList().Add(new UserDTO
            {
                UserName = "admin",
                Password = "admin",
                Role = "admin"
            });
        }
        public UserDTO GetUser(UserModel userModel)
        {
            return users.Where(x => x.UserName.ToLower() == userModel.UserName.ToLower()
                && x.Password == userModel.Password).FirstOrDefault();
        }
    }
}
