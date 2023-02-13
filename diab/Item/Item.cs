using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static diab.Armor;

namespace diab
{
    public class Item
    {
        public string? Name { get; set; } //helmet of speed
        public int RequiredLevel { get; set; } //8
        public string? Slot { get; set; } //head


        public enum Slots
        {
            Weapon = 1,
            Head = 2,
            Body = 3,
            Legs = 4,
        }



        public string EquipGear(int gear, Hero player)
            //here use conditionals
        {
            var result = PlayerGear(gear);
            if (result != null)
            {
                if (result == "Weapon")
                {
                    player.Weapon = Name;
                }
                if (result == "Head")
                {
                    player.Head = Name;
                }
                if (result == "Body")
                {
                    player.Body = Name;
                }
                if (result == "Legs")
                {
                    player.Legs = Name;
                }
                return Slot = result;
            }

            return null!;
        }

        public static string PlayerGear(int slot)
        {
            string heroWeaponChoise = ((Slots)slot).ToString();
            return heroWeaponChoise;
        }
    }
}
