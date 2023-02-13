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

        public string EquipWeapon(int weapon)
        {
            var result = PlayerWeapon(weapon);
            if (result != null)
            {
                return weaponType = result;
            }

            return null!;
        }

        public static string PlayerWeapon(int selectedWeaponType)
        {
            string heroWeaponChoise = ((WeaponType)selectedWeaponType).ToString();
            return heroWeaponChoise;
        }
    }
}

