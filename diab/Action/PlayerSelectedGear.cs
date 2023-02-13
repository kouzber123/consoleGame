namespace diab
{
    internal class PlayerSelectedGear
    {
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
