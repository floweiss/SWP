﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWP_Prototype.Spears;
using SWP_Prototype.Swords;

namespace SWP_Prototype
{
    public sealed class PrototypeSingleton
    {
        private PrototypeSingleton() { }

        private static PrototypeSingleton _instance = null;

        public static PrototypeSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PrototypeSingleton();
            }
            return _instance;
        }

        private List<Sword> _swords = new List<Sword>();
        private LongSword _basicLongSword = new LongSword(10, 20, Material.Steel, 30, "Steel Swing");
        private Katana _basicKatana = new Katana(15, 15, Material.Iron, "Japan", 100);

        public void AddItem(Sword sword)
        {
            _swords.Add(sword);
        }

        public void RemoveSword(int index)
        {
            _swords.RemoveAt(index);
        }

        public Sword GetSword(int index)
        {
            return _swords[index];
        }


        private List<Spear> _spears = new List<Spear>();
        private Halberd _basicHalberd = new Halberd(18, 30, Material.Silver, 2, "Alexander The Great");
        private Poleaxe _basicPoleaxe = new Poleaxe(16, 40, Material.Iron, 30, "Hell Hammer");

        public void AddItem(Spear spear)
        {
            _spears.Add(spear);
        }

        public void RemoveSpear(int index)
        {
            _spears.RemoveAt(index);
        }

        public Spear GetSpear(int index)
        {
            return _spears[index];
        }

        public void AddBasicItem(bool isSword)
        {
            if (isSword)
            {
                AddItem(_basicLongSword.Clone());
            }
            else
            {
                AddItem(_basicHalberd.Clone());
            }
        }

        public String GetAllWeapons()
        {
            String result = "Swords:\n";
            foreach (var sword in _swords)
            {
                result += (sword.ToString() + "\n");
            }

            result += "\nSpears:\n";
            foreach (var spear in _spears)
            {
                result += (spear.ToString() + "\n");
            }

            return result;
        }
    }
}