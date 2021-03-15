using System;
using System.Collections.Generic;
using System.Text;

namespace SWP_Command_Composite.Commands
{
    public class BumperCommand : ICommand
    {
        private PointReceiver _pointReceiver;

        public BumperCommand(PointReceiver pointReceiver)
        {
            _pointReceiver = pointReceiver;
        }

        public void Execute()
        {
            Console.WriteLine("Ball hits bumper! 10 points!");
            _pointReceiver.AddPoints(10);
        }
    }
}
