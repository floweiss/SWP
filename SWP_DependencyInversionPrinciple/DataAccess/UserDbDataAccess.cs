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
            // Fetch users from database...
            return new() {"User1", "User2", "User3"};
        }
    }
}
