using System;
using System.Collections.Generic;
using System.Text;

namespace SWP_Command_Composite.Commands
{
    public class BumperCommand : ICommand
    {
        public int Execute()
        {
            Console.WriteLine("Ball hits bumper! 10 points!");
            return 10;
        }
    }
}
