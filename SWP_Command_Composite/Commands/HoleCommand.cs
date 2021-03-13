using System;
using System.Collections.Generic;
using System.Text;

namespace SWP_Command_Composite.Commands
{
    public class HoleCommand : CompositeCommand, ICommand
    {
        public HoleCommand()
        {
            AddCommand(new UndergroundTargetCommand());
            AddCommand(new RampCommand());
        }

        public int Execute()
        {
            Console.WriteLine("Ball hits hole! What wil happen next...");

            int addedPoints = 0;
            foreach (var command in _commands)
            {
                addedPoints += command.Execute();
            }

            return addedPoints;
        }

        
    }
}
