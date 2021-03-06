using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWP_Adapter.Swords;

namespace SWP_Adapter
{
    public class SwordAdapter : IGlowingSword
    {
        private MiddleSword _middleSword;

        public SwordAdapter(MiddleSword ms)
        {
            _middleSword = ms;
        }

        public string GlowingFight()
        {
            return _middleSword.Fight() + "... look! It glows too!";
        }
    }
}
