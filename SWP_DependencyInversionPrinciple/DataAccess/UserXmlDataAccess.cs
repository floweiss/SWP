using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_DependencyInversionPrinciple.DataAccess
{
    class UserXmlDataAccess : IUserDataAccess
    {
        public List<string> GetUsers()
        {
            // Extract users from XML...
            return new() { "User97", "User98", "User99" };
        }
    }
}
