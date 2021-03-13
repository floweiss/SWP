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
                Console.Write("Object you hit: ");
                string obj = Console.ReadLine();
                if (obj.ToLower() == "quit")
                { 
                    break;   
                }
                flipper.HitSomething(obj);
                Console.WriteLine($"Your current points are {flipper.Points}");
            }

            Console.WriteLine("Flipper ended!");
        }
    }
}
