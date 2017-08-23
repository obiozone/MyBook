using MyBook.Core.Interface.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBook.Core.Models;

namespace MyBook.Core.Managers
{
    public class AccountManager: IAccountManager
    {
        private IAccountQueries _queries;

        public AccountManager(IAccountQueries queries)
        {
            _queries = queries;
        }

        public Operation<UserModel> CreateUser(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}
