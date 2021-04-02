using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_DependencyInversionPrinciple.BusinessLogic
{
    interface IProductBusinessLogic
    {
        Dictionary<string, double> GetProducts();
        double CalculateSellPrice(double price);
    }
}
