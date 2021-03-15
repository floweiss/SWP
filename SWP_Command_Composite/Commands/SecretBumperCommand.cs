using System;
using System.Collections.Generic;
using System.Text;

namespace SWP_Command_Composite.Commands
{
    public class SecretBumperCommand : ICommand
    {
        public int Execute()
        {
            Console.WriteLine("   Ball hits secret bumper! 150 points!");
            return 150;
        }
    }
}
