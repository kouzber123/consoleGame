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
        readonly List<string> weaponTypes = new();
        readonly List<string> armorTypes = new();
        public override string ArmorRestrictions(string armor) //cloth
        {
            armorTypes.AddRange(armorType);

            return armorTypes.Find(x => x == armor); //return if doesnt exist here
        }

        public override string WeaponRestrictions(string weapon)
        {
            weaponTypes.AddRange(weaponType);
            return weaponTypes.Find(x => x == weapon);

        }
        /// <summary>
        ///     Calculates player dmg based on class + lvl and weapon dmg
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public override int Damage(Player player)
        {
            return player.Damage + player.Str;
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
