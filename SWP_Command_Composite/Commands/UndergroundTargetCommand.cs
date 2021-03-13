using System;
using System.Collections.Generic;
using System.Text;

namespace SWP_Command_Composite.Commands
{
    public class UndergroundTargetCommand : ICommand
    {
        public int Execute()
        {
            Console.WriteLine("Ball hits underground target! 100 points!");
            return 100;
        }
    }
}
