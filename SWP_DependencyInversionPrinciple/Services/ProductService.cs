using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWP_DependencyInversionPrinciple.BusinessLogic;
using SWP_DependencyInversionPrinciple.DataAccess;

namespace SWP_DependencyInversionPrinciple.Services
{
    class ProductService : IProductService
    {
        private IProductBusinessLogic _productBusinessLogic;

        public ProductService(DataSource dataSource)
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

            _productBusinessLogic = new ProductBusinessLogic(dataAccessFactory);
        }

        public string GetProducts()
        {
            Dictionary<string, double> products = _productBusinessLogic.GetProducts();
            string result = "";
            foreach (var namePrice in products)
            {
                result += $"{namePrice.Key}: {namePrice.Value}";
                if (!Equals(products.Last(), namePrice))
                {
                    result += ",\n";
                }
            }

            return result;
        }
    }
}
