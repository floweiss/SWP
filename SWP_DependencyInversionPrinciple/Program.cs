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
            DataSource dataSource = DataSource.Database;
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
        }
    }
}
