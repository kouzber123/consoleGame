namespace diab
{
    public class Weapon : Item
    {
        private string? weaponType = null;
        public  int damage = 0;
        public int WeaponDamage { get => damage; }
        public string? WeaponTypes { get => weaponType; set => weaponType = value; }

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

