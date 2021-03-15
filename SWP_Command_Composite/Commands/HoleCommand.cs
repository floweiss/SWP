using System;
using System.Collections.Generic;
using System.Text;

namespace SWP_Command_Composite.Commands
{
    public class HoleCommand : CompositeCommand
    {
        public HoleCommand(PointReceiver pointReceiver) : base(pointReceiver)
        {
            AddCommand(new UndergroundTargetCommand(_pointReceiver));
            AddCommand(new ShooterCommand(_pointReceiver));
        }

        public override void Execute()
        {
            Console.WriteLine("Ball hits hole! What wil happen next...");
            base.Execute();
        }

        
    }
}
