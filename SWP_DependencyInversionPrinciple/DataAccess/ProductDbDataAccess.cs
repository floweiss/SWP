using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_DependencyInversionPrinciple.DataAccess
{
    class ProductDbDataAccess : IProductDataAccess
    {
        public Dictionary<string, double> GetProducts()
        {
            return new()
            {
                {"Chair", 50.0}, 
                {"Table", 95.0},
                {"Shelf", 70.0}
            };
        }
    }
}
