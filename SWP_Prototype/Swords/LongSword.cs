using System;
using Newtonsoft.Json.Linq;

namespace SWP_Prototype.Swords
{
    public class LongSword : SwordPrototype
    {
        public int Weight;
        public String SpecialPower;

        public LongSword(int hitpoints, int length, Material material, int weight, String specialPower) : base(hitpoints, length, material)
        {
            Weight = weight;
            SpecialPower = specialPower;
        }

        public LongSword(LongSword longsword) : base(longsword)
        {
            Weight = longsword.Weight;
            SpecialPower = longsword.SpecialPower;
        }

        public LongSword(JToken token) : base(token)
        {
            Weight = (int) token["Weight"];
            SpecialPower = (string) token["SpecialPower"];
        }

        public override SwordPrototype Clone()
        {
            return new LongSword(this);
        }

        public override string ToString()
        {
            return $"Longsword: {Hitpoints} - {Length} - {Material} / Made of: {Material} - Power: {SpecialPower}";
        }
    }
}
