using System;

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
