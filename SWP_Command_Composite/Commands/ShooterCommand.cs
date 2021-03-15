using System;
using System.Collections.Generic;
using System.Text;

namespace SWP_Command_Composite.Commands
{
    public class ShooterCommand : ICommand
    {
        private PointReceiver _pointReceiver;

        public ShooterCommand(PointReceiver pointReceiver)
        {
            _pointReceiver = pointReceiver;
        }

        public void Execute()
        {
            Console.WriteLine("   Ball hits shooter! It rushes back into game area!");
            _pointReceiver.AddPoints(0); // just to demonstrate
        }
    }
}
