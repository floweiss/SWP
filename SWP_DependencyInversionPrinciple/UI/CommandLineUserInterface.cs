using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWP_DependencyInversionPrinciple.Services;

namespace SWP_DependencyInversionPrinciple.UI
{
    class CommandLineUserInterface : IUserInterface
    {
        private IProductService _productService;
        private IUserService _userService;

        public CommandLineUserInterface(DataSource dataSource)
        {
            _productService = new ProductService(dataSource);
            _userService = new UserService(dataSource);
        }

        public void ExecuteCommand(string command)
        {
            switch (command.ToLower())
            {
                case "products":
                    Console.WriteLine(_productService.GetProducts());
                    break;
                case "users":
                    Console.WriteLine(_userService.GetUsers());
                    break;
                default:
                    Console.WriteLine("Nothing to Show");
                    break;
            }
        }
    }
}
