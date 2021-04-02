using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_DependencyInversionPrinciple.DataAccess
{
    class ProductXmlDataAccess : IProductDataAccess
    {
        public Dictionary<string, double> GetProducts()
        {
            return new()
            {
                { "TV", 500.0 },
                { "Phone", 300.0 },
                { "Notebook", 700.0 }
            };
        }
    }
}
