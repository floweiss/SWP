using System;

namespace SWP_Command_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            PointReceiver pointReceiver = new PointReceiver(0);
            FlipperInvoker flipper = new FlipperInvoker(pointReceiver);
            Console.WriteLine($"Flipper started! You start with {pointReceiver.GetPoints()} points");

            while (true)
            {
                Console.Write("Object the ball hit (bumper, ramp, target, hole, secret) or quit flipper (exit/quit): ");
                string hitObject = Console.ReadLine();
                if (hitObject.ToLower() == "quit" || hitObject.ToLower() == "exit")
                {
                    break;
                }
                flipper.HitSomething(hitObject);
                Console.WriteLine($"Your current points are {pointReceiver.GetPoints()}");
            }

            Console.WriteLine($"Flipper ended! You have reached {pointReceiver.GetPoints()} points!");
        }
    }
}
