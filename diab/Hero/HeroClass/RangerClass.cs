﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diab
{
    public class RangerClass : HeroClass
    {
        public override string ClassName => "Ranger";
        public override int Str => 1;
        public override int Dex => 7;
        public override int Magic => 1;

        readonly string[] armorType = { "Leather", "Mail"};
        readonly string[] weaponType = { "Bow" };
        readonly List<string> itemTypes = new();
        public override string GearRestrictions(string item)
        {
            itemTypes.AddRange(armorType.Union(weaponType));
            return itemTypes.Find(x => x == item);
        }


        /// <summary>
        ///     Calculates player dmg based on class + lvl and weapon dmg
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public override int Damage(Player player)
        {   
            return (player.Weapon!.WeaponDamage == 0 ? 1 : player.Weapon.WeaponDamage) * (1 + player.Dex / 100);
        }
        public override int TotalAttributes(Player player)
        {
           
                return (player.TotalStats() + player.Head!.TotalAttributes() + player.Body!.TotalAttributes() + player.Legs!.TotalAttributes());
          

        }
        public override int TotalAttribute(int attribute, int armorAttribute)
        {
            return attribute + armorAttribute;
        }
        public override void LevelUp(Player player)
        {
            player.Str += 1;
            player.Dex += 5;
            player.Magic += 1;

            player.Level++;
        }
    }
}
