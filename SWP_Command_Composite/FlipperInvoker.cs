using System;
using System.Collections.Generic;
using System.Text;
using SWP_Command_Composite.Commands;

namespace SWP_Command_Composite
{
    public class FlipperInvoker
    {
        private PointReceiver _pointReceiver;
        private Dictionary<string, ICommand> _commands;

        public FlipperInvoker(PointReceiver pointReceiver)
        {
            _pointReceiver = pointReceiver;
            _commands = new Dictionary<string, ICommand>();
            _commands.Add("bumper", new BumperCommand(_pointReceiver));
            _commands.Add("ramp", new RampCommand(_pointReceiver));
            _commands.Add("target", new TargetCommand(_pointReceiver));
            _commands.Add("hole", new HoleCommand(_pointReceiver));
            _commands.Add("secret", new SecretRoomCommand(_pointReceiver));
        }

        public void HitSomething(string hit)
        {
            switch (hit.ToLower())
            {
                case "bumper":
                    _commands["bumper"].Execute();
                    break;
                case "ramp":
                    _commands["ramp"].Execute();
                    break;
                case "target":
                    _commands["target"].Execute();
                    break;
                case "hole":
                    _commands["hole"].Execute();
                    break;
                case "secret":
                    _commands["secret"].Execute();
                    break;
                default:
                    Console.WriteLine("This object can not be hit!");
                    break;
            }
        }
    }
}
