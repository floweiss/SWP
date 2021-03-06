using System;
using System.Collections.Generic;
using SWP_Adapter.Swords;

namespace SWP_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            SwordKeeper swordKeeper = new SwordKeeper();

            Console.WriteLine(swordKeeper.GetGlowingSword(SwordType.Short).GlowingFight());
            Console.WriteLine(swordKeeper.GetGlowingSword(SwordType.Middle).GlowingFight());
            Console.WriteLine(swordKeeper.GetGlowingSword(SwordType.Middle, false).GlowingFight());
            Console.WriteLine(swordKeeper.GetGlowingSword(SwordType.Long).GlowingFight());
        }
    }
}
