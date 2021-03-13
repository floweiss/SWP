using System;
using System.Collections.Generic;
using System.Text;

namespace SWP_Command_Composite.Commands
{
    public class ShooterCommand : ICommand
    {
        public int Execute()
        {
            Console.WriteLine("Ball hits shooter! It rushes back into game area!");
            return 0;
        }
    }
}
