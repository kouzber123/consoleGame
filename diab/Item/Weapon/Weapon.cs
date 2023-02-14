namespace diab
{
    public class Weapon : Item
    {
        private string? weaponType;
        public int WeaponDamage { get; set; }
        public string? WeaponType { get => weaponType; }

        /// <summary>
        /// This is against incorrect user select relation to class and weapon type
        /// </summary>
        /// <param name="weapon"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        public string EquipWeapon(int weapon, Player player)
        {
            string CurrentEquippedWeapon = PlayerWeapon(weapon);
            while (true)
            {
                if (player.CheckWeaponType(CurrentEquippedWeapon)) {

                    return weaponType = CurrentEquippedWeapon;
                }
                else
                {
              
                    return ""; 
                }
            }
           
            
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

