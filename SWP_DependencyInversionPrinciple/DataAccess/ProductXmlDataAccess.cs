using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_DependencyInversionPrinciple.DataAccess
{
    class ProductXmlDataAccess : IProductDataAccess
    {
        public List<string> GetProducts()
        {
            return new() {"TV", "Phone", "Notebook"};
        }
    }
}
