using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWP_Adapter.Swords;

namespace SWP_Adapter
{
    public class SwordKeeper
    {
        private Dictionary<string, IGlowingSword> _swords;

        public SwordKeeper()
        {
            _swords = new Dictionary<string, IGlowingSword>();
            _swords.Add("ShortSword", new ShortSword());
            _swords.Add("LongSword", new LongSword());

            MiddleSword ms = new MiddleSword();
            _swords.Add("MiddleSwordObject", new MiddleSwordObjectAdapter(ms));

            _swords.Add("MiddleSwordClass", new MiddleSwordClassAdapter());
        }

        public IGlowingSword GetGlowingSword(SwordType swordType, bool objectAdapter = true)
        {
            switch (swordType)
            {
                case SwordType.Short:
                    return _swords["ShortSword"];
                case SwordType.Middle:
                    return (objectAdapter) ? _swords["MiddleSwordObject"] : _swords["MiddleSwordClass"];
                default:
                    return _swords["LongSword"];
            }
        }
    }
}
