namespace diab
{
    internal class PlayerSelectedGear
    {
        /// <summary>
        /// Set armor or weapon stats 
        /// </summary>
        /// <param name="weapon"></param>
        /// <param name="name"></param>
        /// <param name="lvl"></param>
        /// <param name="damage"></param>
        public static void SetWeapon(Weapon weapon, string name, int lvl, int damage)
        {
            weapon.Name = name;
            weapon.RequiredLevel = lvl;
            weapon.WeaponDamage = damage;
        }
        public static void SetArmor(Armor armor, string name, int lvl, int defense)
        {
            armor.Name = name;
            armor.RequiredLevel = lvl;
            armor.ArmorDefense = defense;
        }
    }
}
