using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWP_DependencyInversionPrinciple.DataAccess;

namespace SWP_DependencyInversionPrinciple.BusinessLogic
{
    class ProductBusinessLogic : IProductBusinessLogic
    {
        private IDataAccessFactory _dataAccessFactory;
        private IProductDataAccess _productDataAccess;

        public ProductBusinessLogic(IDataAccessFactory dataAccessFactory)
        {
            _dataAccessFactory = dataAccessFactory;
            _productDataAccess = _dataAccessFactory.GetProductDataAccess();
        }

        public Dictionary<string, double> GetProducts()
        {
            Dictionary<string, double> products = _productDataAccess.GetProducts();
            foreach (var namePrice in products)
            {
                products[namePrice.Key] = CalculateSellPrice(namePrice.Value);
            }

            return products;
        }

        public double CalculateSellPrice(double price)
        {
            return price * 1.25;
        }
    }
}
