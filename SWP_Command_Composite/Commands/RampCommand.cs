using System;
using System.Collections.Generic;
using System.Text;

namespace SWP_Command_Composite.Commands
{
    public class RampCommand : ICommand
    {
        private PointReceiver _pointReceiver;

        public RampCommand(PointReceiver pointReceiver)
        {
            _pointReceiver = pointReceiver;
        }

        public void Execute()
        {
            Console.WriteLine("Ball hits ramp! It shoots up in the sky!");
            _pointReceiver.AddPoints(0); // just to demonstrate
        }
    }
}
