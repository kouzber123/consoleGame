namespace diab
{
    public class Weapon : Item
    {
        private string? weaponType = null;
        public int damage = 0;
        public int WeaponDamage { get => damage; }
        public string? WeaponType { get => weaponType; }

        /// <summary>
        /// This is against incorrect user select relation to class and weapon type
        /// </summary>
        /// <param name="weapon"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        /// 
        public string SetWeaponType(string type)
        {
            return weaponType = type;
        }
        public int SetDamage(int dmg)
        {
            return damage = dmg;
        }

        /// <summary>
        /// return the weapon type in string
        /// </summary>
        /// <param name="selectedWeaponType"></param>
        /// <returns></returns>
        public static string PlayerWeapon(int selectedWeaponType)
        {
            return ((WeaponType)selectedWeaponType).ToString();
            
        }
    }
}

