namespace diab
{
    public class DisplayWeaponsSelection

    {

        /// <summary>
        /// Function handles displaying selection of weapons and give a player that weapon
        /// </summary> 
        /// <param name="WeaponType"></param>
        /// <param name="weapon"></param>
        /// <param name="player"></param>

         public static string DisplayWeaponList(string weaponType, Weapon weapon, Player player)
        {
            int chosenItem = 0;
            string? weapon1 ="", weapon2 = "", weapon3 = "", type ="";
            int lvlreq1 = 0, lvlreq2 = 0, lvlreq3 = 0;
            Weapon weapons1;
            Weapon weapons2; 
            Weapon weapons3; 
            
            if (weaponType == WeaponType.Sword.ToString())
            {


                
                weapon1 = "Iron Sword"; lvlreq1 = 1;    
                weapon2 = "Steel Sword"; lvlreq2 = 10;  
                weapon3 = "Magic Sword"; lvlreq3 = 20;  
                type= WeaponType.Sword.ToString();
                ShowShopItems.ShowShopItem(weapon1, lvlreq1);
                ShowShopItems.ShowShopItem(weapon2, lvlreq2);
                ShowShopItems.ShowShopItem(weapon3, lvlreq3);
              
                chosenItem = UserItemChoise.GetUserInput();                    
            }               
            if(weaponType == WeaponType.Axe.ToString())
            {
                weapon1 = "Iron axe"; lvlreq1 = 1;  
                weapon2 = "Steel Axe"; lvlreq2 = 10;    
                weapon3 = "Rune Axe"; lvlreq3 = 20;
                type = WeaponType.Axe.ToString();
                ShowShopItems.ShowShopItem(weapon1, lvlreq1);
                ShowShopItems.ShowShopItem(weapon2, lvlreq2);
                ShowShopItems.ShowShopItem(weapon3, lvlreq3); ;
                chosenItem = UserItemChoise.GetUserInput();
            }  
            if(weaponType == WeaponType.Hammer.ToString())
            {
                weapon1 = "wooden hammer"; lvlreq1 = 1;     
                weapon2 = "Iron hammer"; lvlreq2 = 10;  
                weapon3 = "Rune hammer"; lvlreq3 = 20;
                type = WeaponType.Hammer.ToString();
                ShowShopItems.ShowShopItem(weapon1, lvlreq1);
                ShowShopItems.ShowShopItem(weapon2, lvlreq2);
                ShowShopItems.ShowShopItem(weapon3, lvlreq3);
                chosenItem = UserItemChoise.GetUserInput(); 
            }   
            if(weaponType == WeaponType.Dagger.ToString())
            {
                weapon1 = "shiv"; lvlreq1 = 1;  
                weapon2 = "iron dagger"; lvlreq2 = 10;  
                weapon3 = "Steel dagger"; lvlreq3 = 20;
                type = WeaponType.Dagger.ToString();
                ShowShopItems.ShowShopItem(weapon1, lvlreq1);
                ShowShopItems.ShowShopItem(weapon2, lvlreq2);
                ShowShopItems.ShowShopItem(weapon3, lvlreq3);
                chosenItem = UserItemChoise.GetUserInput();
            }  
            if(weaponType == WeaponType.Staff.ToString())
            {
                weapon1 = "old stick"; lvlreq1 = 1;     
                weapon2 = "wooden cane"; lvlreq2 = 10;  
                weapon3 = "Arch wizard staff"; lvlreq3 = 20;
                type = WeaponType.Staff.ToString();
                ShowShopItems.ShowShopItem(weapon1, lvlreq1);
                ShowShopItems.ShowShopItem(weapon2, lvlreq2);
                ShowShopItems.ShowShopItem(weapon3, lvlreq3);
                chosenItem = UserItemChoise.GetUserInput();
            }  
            if(weaponType == WeaponType.Bow.ToString())
            {
                weapon1 = "wooden bow"; lvlreq1 = 1;    
                weapon2 = "long bow"; lvlreq2 = 10;     
                weapon3 = "Composite Bow"; lvlreq3 = 20;
                type = WeaponType.Bow.ToString();
                ShowShopItems.ShowShopItem(weapon1, lvlreq1);
                ShowShopItems.ShowShopItem(weapon2, lvlreq2);
                ShowShopItems.ShowShopItem(weapon3, lvlreq3);
                chosenItem = UserItemChoise.GetUserInput(); ;

            }   
            if(weaponType == WeaponType.Wand.ToString())
            {
                weapon1 = "Old mans wand"; lvlreq1 = 1; 
                weapon2 = "Harry's wand"; lvlreq2 = 10; 
                weapon3 = "Sussy wand"; lvlreq3 = 20;
                type = WeaponType.Wand.ToString();
                ShowShopItems.ShowShopItem(weapon1, lvlreq1);
                ShowShopItems.ShowShopItem(weapon2, lvlreq2);
                ShowShopItems.ShowShopItem(weapon3, lvlreq3);
            
                chosenItem = UserItemChoise.GetUserInput();          
            }

            weapons1 = new() { Name = weapon1, RequiredLevel = lvlreq1, damage = RandomGenerator.RandomStat(), WeaponTypes = type};
            weapons2 = new() { Name = weapon2, RequiredLevel = lvlreq2, damage = RandomGenerator.RandomStat(), WeaponTypes = type };
            weapons3 = new() { Name = weapon3, RequiredLevel = lvlreq3, damage = RandomGenerator.RandomStat(), WeaponTypes = type };

          

                if (chosenItem == 1 && weapons1.RequiredLevel <= player.Level)
                {

                    player.Weapon = weapons1;
                    return weapons1.Name;

                }
                if (chosenItem == 2 && weapons2.RequiredLevel <= player.Level)
                {

                    player.Weapon = weapons2;
                    return weapons2.Name;

                }
                if (chosenItem == 2 && weapons3.RequiredLevel <= player.Level)
                {
                    player.Weapon = weapons3;
                    return weapons3.Name;
                }
 
        
         
            return null!;
          
            
        }

    }
}
