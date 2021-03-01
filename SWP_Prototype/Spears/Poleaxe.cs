﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Prototype.Spears
{
    public class Poleaxe : Spear
    {
        public int Weight;
        public String SpecialMove;

        public Poleaxe(int hitpoints, int length, Material material, int weight, String specialMove) : base(hitpoints, length, material)
        {
            Weight = weight;
            SpecialMove = specialMove;
        }

        public Poleaxe(Poleaxe poleaxe) : base(poleaxe)
        {
            Weight = poleaxe.Weight;
            SpecialMove = poleaxe.SpecialMove;
        }

        public override Spear Clone()
        {
            return new Poleaxe(this);
        }

        public override string ToString()
        {
            return $"Poleaxe: {Hitpoints} - {Length} - {Material} / Weight: {Weight} - Special Move: {SpecialMove}";
        }
    }
}