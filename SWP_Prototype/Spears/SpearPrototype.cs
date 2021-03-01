using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Prototype.Spears
{
    public abstract class SpearPrototype : IItem
    {
        public int Hitpoints;
        public int Length;
        public Material Material;

        public SpearPrototype(int hitpoints, int length, Material material)
        {
            Hitpoints = hitpoints;
            Length = length;
            Material = material;
        }

        public SpearPrototype(SpearPrototype spear)
        {
            Hitpoints = spear.Hitpoints;
            Length = spear.Length;
            Material = spear.Material;
        }

        public abstract SpearPrototype Clone();

        public abstract String ToString();
    }
}
