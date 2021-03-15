using System;
using System.Collections.Generic;
using System.Text;

namespace SWP_Command_Composite.Commands
{
    public class UndergroundTargetCommand : ICommand
    {
        private PointReceiver _pointReceiver;

        public UndergroundTargetCommand(PointReceiver pointReceiver)
        {
            _pointReceiver = pointReceiver;
        }

        public void Execute()
        {
            Console.WriteLine("   Ball hits underground target! 100 points!"); 
            _pointReceiver.AddPoints(100);
        }
    }
}
