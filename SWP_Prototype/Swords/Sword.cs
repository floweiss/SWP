using System;
using System.Collections.Generic;
using System.Text;

namespace SWP_Prototype
{
    public abstract class Sword : IItem
    {
        public int Hitpoints;
        public int Length;
        public Material Material;

        public Sword(int hitpoints, int length, Material material)
        {
            Hitpoints = hitpoints;
            Length = length;
            Material = material;
        }

        public Sword(Sword sword)
        {
            Hitpoints = sword.Hitpoints;
            Length = sword.Length;
            Material = sword.Material;
        }

        public abstract Sword Clone();

        public abstract String ToString();
    }
}
