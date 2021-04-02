using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWP_DependencyInversionPrinciple.BusinessLogic;
using SWP_DependencyInversionPrinciple.DataAccess;

namespace SWP_DependencyInversionPrinciple.Services
{
    class UserService : IUserService
    {
        private IUserBusinessLogic _userBusinessLogic;

        public UserService(DataSource dataSource)
        {
            IDataAccessFactory dataAccessFactory;
            if (dataSource == DataSource.Database)
            {
                dataAccessFactory = new DbDataAccessFactory();
            }
            else
            {
                dataAccessFactory = new XmlDataAccessFactory();
            }

            _userBusinessLogic = new UserBusinessLogic(dataAccessFactory);
        }

        public string GetUsers()
        {
            List<string> users = _userBusinessLogic.GetUserNames();
            string result = "";
            users.ForEach(user =>
            {
                result += user;
                if (users.Count-1 != users.LastIndexOf(user))
                {
                    result += ",\n";
                }
            });
            return result;
        }
    }
}
