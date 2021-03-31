using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWP_DependencyInversionPrinciple.DataAccess;

namespace SWP_DependencyInversionPrinciple.BusinessLogic
{
    class UserBusinessLogic
    {
        private IUserDataAccess _userDataAccess;

        public UserBusinessLogic(IDataAccessFactory dataAccessFactory)
        {
            _userDataAccess = dataAccessFactory.GetUserDataAccess();
        }

        public List<string> GetUserNames()
        {
            return _userDataAccess.GetUserNames();
        }
    }
}
