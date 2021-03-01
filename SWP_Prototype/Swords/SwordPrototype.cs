using System;
using System.Collections.Generic;
using System.Text;

namespace SWP_Prototype
{
    public abstract class SwordPrototype : IItem
    {
        public int Hitpoints;
        public int Length;
        public Material Material;

        public SwordPrototype(int hitpoints, int length, Material material)
        {
            Hitpoints = hitpoints;
            Length = length;
            Material = material;
        }

        public SwordPrototype(SwordPrototype sword)
        {
            Hitpoints = sword.Hitpoints;
            Length = sword.Length;
            Material = sword.Material;
        }

        public abstract SwordPrototype Clone();

        public abstract String ToString();
    }
}
