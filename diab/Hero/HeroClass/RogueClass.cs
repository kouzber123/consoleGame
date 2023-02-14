namespace diab
{
    internal class RogueClass: HeroClass
    {
        public override string ClassName => "Rogue";
        public override int Str => 2;
        public override int Dex => 6;
        public override int Magic => 1;

    
        readonly string[] armorType = { "Leather" };
        readonly List<string> armorTypes = new();
        readonly string[] weaponType = { "Dagger" };
        readonly List<string> weaponTypes = new();
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
            return player.Damage + player.Dex;
        }

        public override void LevelUp(Player player)
        {
            player.Str += 1;
            player.Dex += 4;
            player.Magic += 1;


            player.Level++;
        }
    }
}
