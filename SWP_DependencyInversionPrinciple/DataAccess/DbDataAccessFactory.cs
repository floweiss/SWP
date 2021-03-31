using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_DependencyInversionPrinciple.DataAccess
{
    class DbDataAccessFactory : IDataAccessFactory
    {
        public IUserDataAccess GetUserDataAccess()
        {
            return new UserDbDataAccess();
        }

        public IProductDataAccess GetProductDataAccess()
        {
            return new ProductDbDataAccess();
        }
    }
}
