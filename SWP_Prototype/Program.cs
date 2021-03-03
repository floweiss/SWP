using System;
using System.IO;
using SWP_Prototype.Spears;
using SWP_Prototype.Swords;

namespace SWP_Prototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrototypeSingleton weaponManager = PrototypeSingleton.GetInstance;
            
            weaponManager.AddBasicItem(WeaponType.LongSword);
            weaponManager.AddBasicItem(WeaponType.Katana);

            weaponManager.AddBasicItem(WeaponType.Halberd);
            weaponManager.AddBasicItem(WeaponType.Poleaxe);

            Katana k = new Katana(14, 25, Material.Gold, "China", 50);
            weaponManager.AddItem(k);

            Poleaxe p = new Poleaxe(17, 50, Material.Bronze, 20, "Bronze Buster");
            weaponManager.AddItem(p);

            Console.WriteLine(weaponManager.GetAllWeapons());
        }
    }
}
