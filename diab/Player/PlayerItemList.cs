using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using diab;

namespace diab
{
    internal class PlayerItemList
    {

       public static void DisplayWeapons(string WeaponType, Weapon weapon, Player player)
        {
            DisplayWeaponsSelection.DisplayWeaponList(WeaponType, weapon, player);
        }

       public static string DisplayArmors(string ArmorType, Armor armor, Player player)
        {
           return DisplayArmorSelection.DisplayArmorList(ArmorType, armor, player);
        }
    }
}
