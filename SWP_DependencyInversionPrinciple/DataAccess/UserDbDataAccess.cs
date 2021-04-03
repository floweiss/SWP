using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_DependencyInversionPrinciple.DataAccess
{
    class UserDbDataAccess : IUserDataAccess
    {
        public List<string> GetUsers()
        {
            // Get data from DB
            return new() {"User1", "User2", "User3"};
        }
    }
}
