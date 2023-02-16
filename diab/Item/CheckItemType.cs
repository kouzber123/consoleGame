namespace diab
{
    public class CheckItemType
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
                    try
                    {
                        {
                            CurrentEquippepItem = Weapon.PlayerWeapon(itemType);
                            if (player.CheckItemType(CurrentEquippepItem))
                            {

                                return item.Class1.SetWeaponType(CurrentEquippepItem);
                            }
                            else
                            {
                               throw new InvalidWeaponException( CurrentEquippepItem+" Cannot be worn by "+player.HeroClass);
                                
                            }
                        }
                    }
                    catch (InvalidWeaponException m)
                    {

                        Console.WriteLine(m.Message);
                        return "";
                    }
             
                if (item.Class1 == null)          
                {
                    try
                    {
                        CurrentEquippepItem = Armor.PlayerArmor(itemType);
                        if (player.CheckItemType(CurrentEquippepItem))
                        {

                            return item.Class2.SetArmorType(CurrentEquippepItem);
                        }
                        else
                        {
                            throw new InvalidArmorException(CurrentEquippepItem + " Cannot be worn by " + player.HeroClass);
                        }
                    }
                    catch (Exception m)
                    {

                        Console.WriteLine(m.Message);
                        return "";
                    }
                   

                }
            
            }
        }
    }
}
