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
        /// <summary>
        /// This handles calling correct weapon list
        /// </summary>
        /// <param name="WeaponType"></param>
        /// <param name="weapon"></param>
        /// <param name="player"></param>
       public static void DisplayWeapons(string WeaponType, Weapon weapon, Player player)
        {
            DisplayWeaponsSelection.DisplayWeaponList(WeaponType, weapon, player);
        }


        /// <summary>
        /// Handles displaying correct armor list for player
        /// </summary>
        /// <param name="ArmorType"></param>
        /// <param name="armor"></param>
        /// <param name="player"></param>
        /// <returns></returns>
       public static string DisplayArmors(string ArmorType, Armor armor, Player player)
        {
           return DisplayArmorSelection.DisplayArmorList(ArmorType, armor, player);
        }
    }
}
