using System;
using SWP_DependencyInversionPrinciple.BusinessLogic;
using SWP_DependencyInversionPrinciple.DataAccess;
using SWP_DependencyInversionPrinciple.UI;

namespace SWP_DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSource dataSource = DataSource.Xml;
            IUserInterface ui = new CommandLineUserInterface(dataSource);
            Console.WriteLine($"Querying from {dataSource}");
            while (true)
            {
                Console.Write("What do you want to see (Products, Users)? ");
                string input = Console.ReadLine();
                if (input.ToLower() == "exit" || input.ToLower() == "quit")
                {
                    break;
                }
                ui.ExecuteCommand(input);
            }

            /*IDataAccessFactory dataAccessFactory = new DbDataAccessFactory();
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
            userBusinessLogic.GetUserNames().ForEach(user => Console.Write($"{user}\t"));*/
        }
    }
}
