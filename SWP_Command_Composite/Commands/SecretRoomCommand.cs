using System;
using System.Collections.Generic;
using System.Text;

namespace SWP_Command_Composite.Commands
{
    public class SecretRoomCommand : CompositeCommand
    {
        public SecretRoomCommand(PointReceiver pointReceiver) : base(pointReceiver)
        {
            AddCommand(new SecretBumperCommand(_pointReceiver));
            AddCommand(new SecretBumperCommand(_pointReceiver));
            AddCommand(new SecretBumperCommand(_pointReceiver));
            AddCommand(new ShooterCommand(_pointReceiver));
        }

        public override void Execute()
        {
            Console.WriteLine("Ball vanishes in secret room! What will happen next...");
            base.Execute();
        }
    }
}
