using System;
using System.Collections.Generic;
using System.Text;
using SWP_Command_Composite.Commands;

namespace SWP_Command_Composite
{
    public class FlipperInvoker
    {
        private PointReceiver _pointReceiver;

        public FlipperInvoker(PointReceiver pointReceiver)
        {
            _pointReceiver = pointReceiver;
        }

        public void HitSomething(string hit)
        {
            switch (hit.ToLower())
            {
                case "bumper":
                    ExecuteCommand(new BumperCommand(_pointReceiver));
                    break;
                case "ramp":
                    ExecuteCommand(new RampCommand(_pointReceiver));
                    break;
                case "target":
                    ExecuteCommand(new TargetCommand(_pointReceiver));
                    break;
                case "hole":
                    ExecuteCommand(new HoleCommand(_pointReceiver));
                    break;
                case "secret":
                    ExecuteCommand(new SecretRoomCommand(_pointReceiver));
                    break;
                default:
                    Console.WriteLine("This object can not be hit!");
                    break;
            }
        }

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
        }
    }
}
