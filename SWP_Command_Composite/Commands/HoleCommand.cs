using System;
using System.Collections.Generic;
using System.Text;

namespace SWP_Command_Composite.Commands
{
    public class HoleCommand : CompositeCommand, ICommand
    {
        private PointReceiver _pointReceiver;

        public HoleCommand(PointReceiver pointReceiver)
        {
            _pointReceiver = pointReceiver;
            AddCommand(new UndergroundTargetCommand(_pointReceiver));
            AddCommand(new ShooterCommand(_pointReceiver));
        }

        public void Execute()
        {
            Console.WriteLine("Ball hits hole! What wil happen next...");

            int addedPoints = 0;
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        
    }
}
