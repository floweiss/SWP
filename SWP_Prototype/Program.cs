using System;
using SWP_Prototype.Swords;

namespace SWP_Prototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrototypeSingleton weaponManager = PrototypeSingleton.GetInstance();
            
            weaponManager.AddBasicItem(true);
            weaponManager.AddBasicItem(false);
            Katana k = new Katana(14, 25, Material.Gold, "China", 50);
            weaponManager.AddItem(k);

            Console.WriteLine(weaponManager.GetAllWeapons());
        }
    }
}
