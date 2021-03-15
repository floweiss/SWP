using System;
using System.Collections.Generic;
using System.Text;

namespace SWP_Command_Composite.Commands
{
    public class SecretRoomCommand : CompositeCommand, ICommand
    {
        private PointReceiver _pointReceiver;
        public SecretRoomCommand(PointReceiver pointReceiver)
        {
            _pointReceiver = pointReceiver;
            AddCommand(new SecretBumperCommand(_pointReceiver));
            AddCommand(new SecretBumperCommand(_pointReceiver));
            AddCommand(new SecretBumperCommand(_pointReceiver));
            AddCommand(new ShooterCommand(_pointReceiver));
        }

        public void Execute()
        {
            Console.WriteLine("Ball vanishes in secret room! What will happen next...");

            int addedPoints = 0;
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }
    }
}
