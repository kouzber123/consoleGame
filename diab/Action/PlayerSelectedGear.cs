namespace diab
{
    internal class PlayerSelectedGear
    {
        /// <summary>
        /// Set weapon stats 
        /// </summary>
        /// <param name="weapon"></param>
        /// <param name="name"></param>
        /// <param name="lvl"></param>
        /// <param name="damage"></param>
        public static void SetWeapon(Weapon weapon)
        {
            //weapon.Name = name;
            //weapon.RequiredLevel = lvl;
            //weapon.SetDamage(damage);
        }

        /// <summary>
        /// Set armor status
        /// </summary>
        /// <param name="armor"></param>
        /// <param name="name"></param>
        /// <param name="lvl"></param>
        /// <param name="defense"></param>
        public static void SetArmor(Armor armor, string name, int lvl, int gearStats)
        {
            armor.Name = name;
            armor.RequiredLevel = lvl;
            armor.GearStats = gearStats;

        }
    }
}
