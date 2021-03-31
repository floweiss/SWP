using System;
using SWP_DependencyInversionPrinciple.BusinessLogic;
using SWP_DependencyInversionPrinciple.DataAccess;

namespace SWP_DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataAccessFactory dataAccessFactory = new DbDataAccessFactory();
            ProductBusinessLogic productBusinessLogic = new ProductBusinessLogic(dataAccessFactory);
            UserBusinessLogic userBusinessLogic = new UserBusinessLogic(dataAccessFactory);

            Console.Write("Products DB:\t");
            productBusinessLogic.GetProducts().ForEach(product => Console.Write($"{product}\t"));
            Console.Write("\nUsernames DB:\t");
            userBusinessLogic.GetUserNames().ForEach(user => Console.Write($"{user}\t"));



            dataAccessFactory = new XmlDataAccessFactory();
            productBusinessLogic = new ProductBusinessLogic(dataAccessFactory);
            userBusinessLogic = new UserBusinessLogic(dataAccessFactory);

            Console.Write("\n\nProducts XML:\t");
            productBusinessLogic.GetProducts().ForEach(product => Console.Write($"{product}\t"));
            Console.Write("\nUsernames XML:\t");
            userBusinessLogic.GetUserNames().ForEach(user => Console.Write($"{user}\t"));
        }
    }
}
