using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWP_DependencyInversionPrinciple.DataAccess;

namespace SWP_DependencyInversionPrinciple.BusinessLogic
{
    class ProductBusinessLogic
    {
        private IProductDataAccess _productDataAccess;

        public ProductBusinessLogic(IDataAccessFactory dataAccessFactory)
        {
            _productDataAccess = dataAccessFactory.GetProductDataAccess();
        }

        public List<string> GetProducts()
        {
            return _productDataAccess.GetProducts();
        }
    }
}
