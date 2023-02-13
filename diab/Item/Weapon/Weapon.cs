using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diab
{
    public class Weapon : Item
    {
        private string? weaponType;
        public int WeaponDamage { get; set; }
        public string? WeaponType { get => weaponType; }

        /// <summary>
        /// This is against incorrect user select relation to class and weapon type
        /// </summary>
        /// <param name="weapon"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        public string EquipWeapon(int weapon, Player player)
        {
            string? heroClass = player.Class;      
            while (true)
            {
                if (weapon == 5 && heroClass == "Mage" || weapon == 7 && heroClass == "Mage")
                {
                 
                    return weaponType = PlayerWeapon(weapon);
                }
                if ( weapon == 6 && heroClass == "Warrior" || weapon == 3 && heroClass == "Warrior" || weapon == 1 && heroClass == "Warrior" || weapon == 4 && heroClass == "Warrior")
                {
                    return weaponType = PlayerWeapon(weapon);
                }

                if (weapon == 3 && heroClass == "Rogue" || weapon == 2 && heroClass == "Rogue")
                {
                    return weaponType = PlayerWeapon(weapon);
                }
                if (weapon == 2 && heroClass == "Ranger")
                {
                    return weaponType = PlayerWeapon(weapon);
                }
               
                else
                {
              
                    return ""; 
                }
            }
           
            
        }

        /// <summary>
        /// return the weapon type in string
        /// </summary>
        /// <param name="selectedWeaponType"></param>
        /// <returns></returns>
        public static string PlayerWeapon(int selectedWeaponType)
        {
            return ((WeaponType)selectedWeaponType).ToString();
            
        }
    }
}

