﻿using System.Collections.Immutable;

namespace diab
{
    internal class MageClass : HeroClass
    {
        public override string ClassName => "Mage";
        public override int Str => 1;
        public override int Dex => 1;
        public override int Magic => 8;

        readonly string[] armorType = { "Cloth" };
        readonly string[] weaponType = { "Staff", "Wand" };

        readonly List<string> itemTypes = new();

        public override string GearRestrictions(string item)
        {
            itemTypes.AddRange(armorType.Union(weaponType));
            return itemTypes.Find(x => x == item)!;
        }


        /// <summary>
        ///     Calculates player dmg based on class + lvl and weapon dmg
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public override int Damage(Player player)
        {
            return (player.Weapon.WeaponDamage == 0 ? 1 : player.Weapon.WeaponDamage) * (1 + player.Magic / 100);
        }
       
        public override void LevelUp(Player player)
        {
            player.Str +=1;
            player.Dex +=1;
            player.Magic +=5;

            player.Level++;
        }

    }
}
