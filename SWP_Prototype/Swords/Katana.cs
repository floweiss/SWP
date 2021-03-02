using System;
using Newtonsoft.Json.Linq;

namespace SWP_Prototype.Swords
{
    public class Katana : SwordPrototype
    {
        public String Source;
        public int Sharpness;

        public Katana(int hitpoints, int length, Material material, String source, int sharpness) : base(hitpoints, length, material)
        {
            Source = source;
            Sharpness = sharpness;
        }

        public Katana(Katana katana) : base(katana)
        {
            Source = katana.Source;
            Sharpness = katana.Sharpness;
        }

        public Katana(JToken token) : base(token)
        {
            Source = (string )token["Source"];
            Sharpness = (int)token["Sharpness"];
        }

        public override SwordPrototype Clone()
        {
            return new Katana(this);
        }

        public override string ToString()
        {
            return $"Katana: {Hitpoints} - {Length} - {Material} / From: {Source} - Sharpness: {Sharpness}";
        }
    }
}
