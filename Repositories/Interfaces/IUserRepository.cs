using LibraryWebApi.Models.AuthModels;

namespace LibraryWebApi.Repositories.Interfaces
{
    internal interface IUserRepository
    {
        public UserDTO GetUser(UserModel userModel);
    }
}
