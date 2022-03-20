using ConsoleApp.Extensions;
using ConsoleApp.Models;

namespace ConsoleApp.Services
{
    public class UserService
    {
        public bool CreateUser(UserModel userModel)
        {
            if (string.IsNullOrEmpty(userModel.Name))
                return false;

            if (userModel.Birth.Date.IsUnderage())
                return false;

            return true;
        }

        public bool UpdateUser(UserModel userModel)
        {
            if (userModel.Id > 0)
                return false;

            if (string.IsNullOrEmpty(userModel.Name))
                return false;

            if (userModel.Birth.Date.IsUnderage())
                return false;

            return true;
        }
    }
}
