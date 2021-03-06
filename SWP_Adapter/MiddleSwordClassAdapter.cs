using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWP_Adapter.Swords;

namespace SWP_Adapter
{
    // Klassenbasierter Adapter
    public class MiddleSwordClassAdapter : MiddleSword, IGlowingSword
    {
        public string GlowingFight()
        {
            return Fight() + "... look! It glows like a class!";
        }
    }
}
