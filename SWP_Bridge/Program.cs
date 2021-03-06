using System;
using System.Collections.Generic;
using SWP_Adapter.Swords;

namespace SWP_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IGlowingSword> swordList = new List<IGlowingSword>();

            swordList.Add(new LongSword());
            swordList.Add(new ShortSword());

            MiddleSword middleSword = new MiddleSword();
            swordList.Add(new SwordAdapter(middleSword));

            foreach (var sword in swordList)
            {
                Console.WriteLine(sword.GlowingFight());
            }
        }
    }
}
