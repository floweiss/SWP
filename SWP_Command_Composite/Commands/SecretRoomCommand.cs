using System;
using System.Collections.Generic;
using System.Text;

namespace SWP_Command_Composite.Commands
{
    public class SecretRoomCommand : CompositeCommand, ICommand
    {
        public SecretRoomCommand()
        {
            AddCommand(new SecretBumperCommand());
            AddCommand(new SecretBumperCommand());
            AddCommand(new SecretBumperCommand());
            AddCommand(new ShooterCommand());
        }

        public int Execute()
        {
            Console.WriteLine("Ball vanishes in secret room! What will happen next...");

            int addedPoints = 0;
            foreach (var command in _commands)
            {
                addedPoints += command.Execute();
            }

            return addedPoints;
        }
    }
}
