using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SWP_Prototype.Spears;
using SWP_Prototype.Swords;

namespace SWP_Prototype
{
    public sealed class PrototypeSingleton
    {
        private PrototypeSingleton(string filename)
        {
            string content = File.ReadAllText(filename);
            JObject obj = JObject.Parse(content);

            _basicLongSword = new LongSword(obj["LongSword"]);
            _basicKatana = new Katana(obj["Katana"]);
            _basicHalberd = new Halberd(obj["Halberd"]);
            _basicPoleaxe = new Poleaxe(obj["Poleaxe"]);
        }

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
                            _instance = new PrototypeSingleton("config.json"); // Pathname for config.json file (properties of basic items)
                        }
                    }
                }
                return _instance;
            }
        }

        private List<SwordPrototype> _swords = new List<SwordPrototype>();
        private LongSword _basicLongSword;
        private Katana _basicKatana;

        private List<SpearPrototype> _spears = new List<SpearPrototype>();
        private Halberd _basicHalberd;
        private Poleaxe _basicPoleaxe;

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
                default: // Also for LongSword
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
