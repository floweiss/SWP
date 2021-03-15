using System;
using System.Collections.Generic;
using System.Text;

namespace SWP_Command_Composite.Commands
{
    public class TargetCommand : ICommand
    {
        private PointReceiver _pointReceiver;

        public TargetCommand(PointReceiver pointReceiver)
        {
            _pointReceiver = pointReceiver;
        }

        public void Execute()
        {
            Console.WriteLine("Ball hits target! 50 points!");
            _pointReceiver.AddPoints(50);
        }
    }
}
