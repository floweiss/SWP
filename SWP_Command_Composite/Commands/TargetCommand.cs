using System;
using System.Collections.Generic;
using System.Text;

namespace SWP_Command_Composite.Commands
{
    public class TargetCommand : ICommand
    {
        public int Execute()
        {
            Console.WriteLine("Ball hits target! 50 points!");
            return 50;
        }
    }
}
