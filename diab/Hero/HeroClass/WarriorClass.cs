namespace diab
{
    internal class WarriorClass: HeroClass
    {
        public override string ClassName => "Warrior";
        public override int Str => 5;
        public override int Dex => 2;
        public override int Magic => 1;
  
        readonly string[] armorType = { "Leather", "Mail", "Plate" };
        readonly string[] weaponType = { "Sword", "Dagger", "Axe", "Hammer" };
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
            return (player.Weapon.WeaponDamage == 0 ? 1 : player.Weapon.WeaponDamage)  * (1 + player.Str / 100);
        }

        public override void LevelUp(Player player)
        {
            player.Str += 3;
            player.Dex += 2;
            player.Magic += 1;
            player.Level++;
        }


    }
}
