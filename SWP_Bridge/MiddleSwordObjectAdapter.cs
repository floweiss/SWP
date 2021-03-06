using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWP_Adapter.Swords;

namespace SWP_Adapter
{
    // Objektbasierter Adapter
    public class MiddleSwordObjectAdapter : IGlowingSword
    {
        private MiddleSword _middleSword;

        public MiddleSwordObjectAdapter(MiddleSword ms)
        {
            _middleSword = ms;
        }

        public string GlowingFight()
        {
            return _middleSword.Fight() + "... look! It glows like an object!";
        }
    }
}
