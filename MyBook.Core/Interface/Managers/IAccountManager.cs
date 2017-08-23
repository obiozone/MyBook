using MyBook.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook.Core.Interface.Managers
{
    public interface IAccountManager
    {
        Operation<UserModel> CreateUser(UserModel user);
        object FindByID(int userId);
        object FindByEmail(string userName);
        object GetPasswordHash(MyBook.Web.Models.User user);
        bool IsUserInRole(MyBook.Web.Models.User user, string roleName);
        object RemoveUserFromRole(MyBook.Web.Models.User user, string roleName);
        object SetPasswordHash(MyBook.Web.Models.User user, string passwordHash);
        object UpdateUser(MyBook.Web.Models.User user);
    }
}
