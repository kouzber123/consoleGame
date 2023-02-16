namespace diab
{
    public class PlayerItemList
    {
        /// <summary>
        /// This handles calling correct weapon list
        /// </summary>
        /// <param name="WeaponType"></param>
        /// <param name="weapon"></param>
        /// <param name="player"></param>
       public static string DisplayWeapons(string WeaponType, Weapon weapon, Player player)
        {
           return  DisplayWeaponsSelection.DisplayWeaponList(WeaponType, weapon, player);
        }


        /// <summary>
        /// Handles displaying correct armor list for player
        /// </summary>
        /// <param name="ArmorType"></param>
        /// <param name="armor"></param>
        /// <param name="player"></param>
        /// <returns></returns>
       public static string DisplayArmors(string ArmorType, Player player)
        {
           return DisplayArmorSelection.DisplayArmorList(ArmorType ,player);
        }
    }
}
