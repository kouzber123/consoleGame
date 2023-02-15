namespace diab
{
    public class DisplayWeaponsSelection

    {

        /// <summary>
        /// Function handles displaying selection of weapons and changes weapon / user class related to weapon
        /// </summary>
        /// <param name="WeaponType"></param>
        /// <param name="weapon"></param>
        /// <param name="player"></param>

         public static string DisplayWeaponList(string WeaponType, Weapon weapon, Player player)
        {
            int chosenItem = 0;
            string? weapon1 ="", weapon2 = "", weapon3 = "";
            int lvlreq1 = 0, lvlreq2 = 0, lvlreq3 = 0, damage1 = 0, damage2 = 0, damage3 = 0;
            if (WeaponType == "Sword")
            {
                weapon1 = "Iron Sword"; lvlreq1 = 1; damage1 = 20;
                weapon2 = "Steel Sword"; lvlreq2 = 10; damage2 = 50;
                weapon3 = "Magic Sword"; lvlreq3 = 20; damage3 = 500;
                ShowShopItems.ShowShopItem(weapon1, lvlreq1, damage1);
                ShowShopItems.ShowShopItem(weapon2, lvlreq2, damage2);
                ShowShopItems.ShowShopItem(weapon3, lvlreq3, damage3);
                chosenItem = UserItemChoise.GetUserInput();                    
            }               
            if(WeaponType == "Axe")
            {
                weapon1 = "Iron axe"; lvlreq1 = 1; damage1 = 20;
                weapon2 = "Steel Axe"; lvlreq2 = 10; damage2 = 50;
                weapon3 = "Rune Axe"; lvlreq3 = 20; damage3 = 500;
                ShowShopItems.ShowShopItem(weapon1, lvlreq1, damage1);
                ShowShopItems.ShowShopItem(weapon2, lvlreq2, damage2);
                ShowShopItems.ShowShopItem(weapon3, lvlreq3, damage3); ;
                chosenItem = UserItemChoise.GetUserInput();
            }  
            if(WeaponType == "Hammer")
            {
                weapon1 = "wooden hammer"; lvlreq1 = 1; damage1 = 20;
                weapon2 = "Iron hammer"; lvlreq2 = 10; damage2 = 50;
                weapon3 = "Rune hammer"; lvlreq3 = 20; damage3 = 500;
                ShowShopItems.ShowShopItem(weapon1, lvlreq1, damage1);
                ShowShopItems.ShowShopItem(weapon2, lvlreq2, damage2);
                ShowShopItems.ShowShopItem(weapon3, lvlreq3, damage3);
                chosenItem = UserItemChoise.GetUserInput(); 
            }   
            if(WeaponType == "Dagger")
            {
                weapon1 = "shiv"; lvlreq1 = 1; damage1 = 20;
                weapon2 = "iron dagger"; lvlreq2 = 10; damage2 = 50;
                weapon3 = "Steel dagger"; lvlreq3 = 20; damage3 = 500;
                ShowShopItems.ShowShopItem(weapon1, lvlreq1, damage1);
                ShowShopItems.ShowShopItem(weapon2, lvlreq2, damage2);
                ShowShopItems.ShowShopItem(weapon3, lvlreq3, damage3);
                chosenItem = UserItemChoise.GetUserInput();
            }  
            if(WeaponType == "Staff")
            {
                weapon1 = "old stick"; lvlreq1 = 1; damage1 = 20;
                weapon2 = "wooden cane"; lvlreq2 = 10; damage2 = 50;
                weapon3 = "Arch wizard staff"; lvlreq3 = 20; damage3 = 500;
                ShowShopItems.ShowShopItem(weapon1, lvlreq1, damage1);
                ShowShopItems.ShowShopItem(weapon2, lvlreq2, damage2);
                ShowShopItems.ShowShopItem(weapon3, lvlreq3, damage3);
                chosenItem = UserItemChoise.GetUserInput();
            }  
            if(WeaponType == "Bow")
            {
                weapon1 = "wooden bow"; lvlreq1 = 1; damage1 = 20;
                weapon2 = "long bow"; lvlreq2 = 10; damage2 = 50;
                weapon3 = "Composite Bow"; lvlreq3 = 20; damage3 = 500;
                ShowShopItems.ShowShopItem(weapon1, lvlreq1, damage1);
                ShowShopItems.ShowShopItem(weapon2, lvlreq2, damage2);
                ShowShopItems.ShowShopItem(weapon3, lvlreq3, damage3);
                chosenItem = UserItemChoise.GetUserInput(); ;

            }   
            if(WeaponType == "Wand")
            {
                weapon1 = "Old mans wand"; lvlreq1 = 1; damage1 = 20;
                weapon2 = "Harry's wand"; lvlreq2 = 10; damage2 = 50;
                weapon3 = "Sussy wand"; lvlreq3 = 20; damage3 = 500;
                ShowShopItems.ShowShopItem(weapon1, lvlreq1, damage1);
                ShowShopItems.ShowShopItem(weapon2, lvlreq2, damage2);
                ShowShopItems.ShowShopItem(weapon3, lvlreq3, damage3);
                chosenItem = UserItemChoise.GetUserInput();          
            }
            SetWeapon.PlayerChoiseOfWeapon(ref chosenItem, ref weapon, ref weapon1, ref weapon2, ref weapon3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref damage1, ref damage2, ref damage3);
            int slot = 1;
        

            player.Weapon = weapon;
            player.PlayerWeapon = weapon.Name;
            return weapon.EquipGear(slot, player);


        }

    }
}
