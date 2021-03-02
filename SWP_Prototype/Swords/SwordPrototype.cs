using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Linq;

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

        public SwordPrototype(JToken token)
        {
            Hitpoints = (int) token["Hitpoints"];
            Length = (int) token["Length"];
            switch ((string) token["Material"])
            {
                case "Bronze":
                    Material = Material.Bronze;
                    break;
                case "Silver":
                    Material = Material.Silver;
                    break;
                case "Gold":
                    Material = Material.Gold;
                    break;
                case "Steel":
                    Material = Material.Steel;
                    break;
                default: // Also for Iron
                    Material = Material.Iron;
                    break;
            }
        }

        public abstract SwordPrototype Clone();

        public abstract String ToString();
    }
}
