using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Adapter.Swords
{
    public class ShortSword : IGlowingSword
    {
        public string GlowingFight()
        {
            return "Fight with glowing Short Sword";
        }
    }
}
