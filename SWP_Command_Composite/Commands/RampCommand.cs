using System;
using System.Collections.Generic;
using System.Text;

namespace SWP_Command_Composite.Commands
{
    public class RampCommand : ICommand
    {
        public int Execute()
        {
            Console.WriteLine("Ball hits ramp! It shoots up in the sky!");
            return 0;
        }
    }
}
