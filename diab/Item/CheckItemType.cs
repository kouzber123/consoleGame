namespace diab
{
    internal class CheckItemType
    {
       /// <summary>
       /// Pass optional class because we have two types of class that needs checking - weapon and armor;
       /// </summary>
       /// <param name="itemType"></param>
       /// <param name="item"></param>
       /// <param name="player"></param>
       /// <returns></returns>
        public static string IsCorrectGearType(int itemType, OptionalClassParams item, Player player)
        {
            string CurrentEquippepItem;
            while (true)
            {
                if (item.Class2 == null)

                {
                    CurrentEquippepItem = Weapon.PlayerWeapon(itemType);
                    if (player.CheckItemType(CurrentEquippepItem))
                    {

                        return item.Class1.SetWeaponType(CurrentEquippepItem);
                    }
                    else
                    {
                        return "";
                    }                
                }
                if (item.Class1 == null)          
                {
                    CurrentEquippepItem = Armor.PlayerArmor(itemType);
                    if (player.CheckItemType(CurrentEquippepItem))
                    {

                       return item.Class2.SetArmorType(CurrentEquippepItem);
                    }
                    else
                    {
                        return "";
                    }

                }
            
            }
        }
    }
}
