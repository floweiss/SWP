using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

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

        public SpearPrototype(JToken token)
        {
            Hitpoints = (int)token["Hitpoints"];
            Length = (int)token["Length"];
            switch ((string)token["Material"])
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

        public abstract SpearPrototype Clone();

        public abstract String ToString();
    }
}
