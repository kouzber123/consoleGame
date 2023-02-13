using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diab
{
    public class SetWeapon
    {
        /// <summary>
        /// Pass values to setweapon for the corresponding chosenitem int
        /// </summary>
        /// <param name="chosenItem"></param>
        /// <param name="weapon"></param>
        /// <param name="weapon1"></param>
        /// <param name="weapon2"></param>
        /// <param name="weapon3"></param>
        /// <param name="lvlreq1"></param>
        /// <param name="lvlreq2"></param>
        /// <param name="lvlreq3"></param>
        /// <param name="damage1"></param>
        /// <param name="damage2"></param>
        /// <param name="damage3"></param>
        public static void PlayerChoiseOfWeapon(ref int chosenItem, ref Weapon weapon, ref string weapon1, ref string weapon2, ref string weapon3, ref int lvlreq1, ref int lvlreq2, ref int lvlreq3, ref int damage1, ref int damage2, ref int damage3)
        {
            
            if (chosenItem == 1)
            {
                PlayerSelectedGear.SetWeapon(weapon, weapon1, lvlreq1, damage1);
            }
            if (chosenItem == 2)
            {
                PlayerSelectedGear.SetWeapon(weapon, weapon2, lvlreq2, damage2);
            }
            if (chosenItem == 3)
            {
                PlayerSelectedGear.SetWeapon(weapon, weapon3, lvlreq3, damage3);
            }
        }
    }
}
