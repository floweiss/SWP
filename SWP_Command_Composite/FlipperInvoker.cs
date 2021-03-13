using System;
using System.Collections.Generic;
using System.Text;
using SWP_Command_Composite.Commands;

namespace SWP_Command_Composite
{
    public class FlipperInvoker
    {
        public int Points;

        public FlipperInvoker(int initialPoints)
        {
            Points = initialPoints;
        }

        public void HitSomething(string hit)
        {
            switch (hit.ToLower())
            {
                case "bumper":
                    ExecuteCommand(new BumperCommand());
                    break;
                case "ramp":
                    ExecuteCommand(new RampCommand());
                    break;
                case "target":
                    ExecuteCommand(new TargetCommand());
                    break;
                case "hole":
                    ExecuteCommand(new HoleCommand());
                    break;
                case "secret":
                    ExecuteCommand(new SecretRoomCommand());
                    break;
                default:
                    Console.WriteLine("This object can not be hit!");
                    break;
            }
        }

        public void ExecuteCommand(ICommand command)
        {
            int addedPoints = command.Execute();
            Points += addedPoints;
        }
    }
}
