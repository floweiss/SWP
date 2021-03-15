using System;

namespace SWP_Command_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            FlipperInvoker flipper = new FlipperInvoker(0);
            Console.WriteLine($"Flipper started! You start with {flipper.Points} points");

            while (true)
            {
                Console.Write("Object the ball hit (bumper, ramp, target, hole, secret) or quit flipper (exit/quit): ");
                string hitObject = Console.ReadLine();
                if (hitObject.ToLower() == "quit" || hitObject.ToLower() == "exit")
                {
                    break;
                }
                flipper.HitSomething(hitObject);
                Console.WriteLine($"Your current points are {flipper.Points}");
            }

            Console.WriteLine($"Flipper ended! You have reached {flipper.Points} points!");
        }
    }
}
