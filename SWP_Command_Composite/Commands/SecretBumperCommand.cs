using System;
using System.Collections.Generic;
using System.Text;

namespace SWP_Command_Composite.Commands
{
    public class SecretBumperCommand : ICommand
    {
        private PointReceiver _pointReceiver;

        public SecretBumperCommand(PointReceiver pointReceiver)
        {
            _pointReceiver = pointReceiver;
        }

        public void Execute()
        {
            Console.WriteLine("   Ball hits secret bumper! 150 points!");
            _pointReceiver.AddPoints(150);
        }
    }
}
