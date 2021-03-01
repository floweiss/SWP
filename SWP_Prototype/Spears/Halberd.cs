using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Prototype.Spears
{
    public class Halberd : Spear
    {
        public int Blades;
        public String Origin;

        public Halberd(int hitpoints, int length, Material material, int blades, String origin) : base(hitpoints, length, material)
        {
            Blades = blades;
            Origin = origin;
        }

        public Halberd(Halberd halberd) : base(halberd)
        {
            Blades = halberd.Blades;
            Origin = halberd.Origin;
        }

        public override Spear Clone()
        {
            return new Halberd(this);
        }

        public override string ToString()
        {
            return $"Halberd: {Hitpoints} - {Length} - {Material} / Blades: {Blades} - Original Carrier: {Origin}";
        }
    }
}
