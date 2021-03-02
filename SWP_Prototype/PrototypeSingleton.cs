using System;
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
        private static readonly object _lock = new object();

        public static PrototypeSingleton GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new PrototypeSingleton();
                        }
                    }
                }
                return _instance;
            }
        }

        private List<SwordPrototype> _swords = new List<SwordPrototype>();
        private LongSword _basicLongSword = new LongSword(10, 20, Material.Steel, 30, "Steel Swing");
        private Katana _basicKatana = new Katana(15, 15, Material.Iron, "Japan", 100);

        private List<SpearPrototype> _spears = new List<SpearPrototype>();
        private Halberd _basicHalberd = new Halberd(18, 30, Material.Silver, 2, "Alexander The Great");
        private Poleaxe _basicPoleaxe = new Poleaxe(16, 40, Material.Iron, 30, "Hell Hammer");


        public void AddItem(SwordPrototype sword)
        {
            _swords.Add(sword);
        }

        public void RemoveSword(int index)
        {
            _swords.RemoveAt(index);
        }

        public SwordPrototype GetSword(int index)
        {
            return _swords[index];
        }


        public void AddItem(SpearPrototype spear)
        {
            _spears.Add(spear);
        }

        public void RemoveSpear(int index)
        {
            _spears.RemoveAt(index);
        }

        public SpearPrototype GetSpear(int index)
        {
            return _spears[index];
        }

        public void AddBasicItem(WeaponType type)
        {
            switch (type)
            {
                case WeaponType.LongSword:
                    _swords.Add(_basicLongSword.Clone());
                    break;
                case WeaponType.Katana:
                    _swords.Add(_basicKatana.Clone());
                    break;
                case WeaponType.Halberd:
                    _spears.Add(_basicHalberd.Clone());
                    break;
                case WeaponType.Poleaxe:
                    _spears.Add(_basicPoleaxe.Clone());
                    break;
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
