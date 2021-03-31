using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_DependencyInversionPrinciple.DataAccess
{
    class XmlDataAccessFactory : IDataAccessFactory
    {
        public IUserDataAccess GetUserDataAccess()
        {
            return new UserXmlDataAccess();
        }

        public IProductDataAccess GetProductDataAccess()
        {
            return new ProductXmlDataAccess();
        }
    }
}
