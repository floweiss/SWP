using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWP_DependencyInversionPrinciple.DataAccess;

namespace SWP_DependencyInversionPrinciple.BusinessLogic
{
    class UserBusinessLogic : IUserBusinessLogic
    {
        private IDataAccessFactory _dataAccessFactory;
        private IUserDataAccess _userDataAccess;

        public UserBusinessLogic(IDataAccessFactory dataAccessFactory)
        {
            _dataAccessFactory = dataAccessFactory;
            _userDataAccess = _dataAccessFactory.GetUserDataAccess();
        }

        public List<string> GetUsers()
        {
            return _userDataAccess.GetUsers();
        }
    }
}
