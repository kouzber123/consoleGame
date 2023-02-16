namespace diab
{
    public class DisplayArmorSelection
    {
        /// <summary>
        /// Shows the options of the armor this function handles changing user gear this is repetive code
        /// </summary>
        /// <param name="ArmorType"></param>
        /// <param name="armor"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        public static string DisplayArmorList(string ArmorType, Player player)
        {
            string? gear1="", gear2="", gear3 = "";
            int lvlreq1 = 0, lvlreq2 = 0, lvlreq3 = 0, chosenItem = 0, slot = 0;
            int choise;
            Armor armor1;
            Armor armor2;
            Armor armor3;
            if (ArmorType == "Cloth")
            {
                Console.Clear();
                choise = ShowGearSlotsOptions.ShowGearSlotOption();

                if (choise == 1)
                {
                    gear1 = "wool hat"; lvlreq1 = 1;    
                    gear2 = "Wizard hat"; lvlreq2 = 10; 
                    gear3 = "Arch wizard"; lvlreq3 = 20;    
                    ShowShopItems.ShowShopItem(gear1, lvlreq1);
                    ShowShopItems.ShowShopItem(gear2, lvlreq2);
                    ShowShopItems.ShowShopItem(gear3, lvlreq3);
                    chosenItem = UserItemChoise.GetUserInput();
                    slot = 2;

                }

                if (choise == 2)
                {
                    gear1 = "wool shirt"; lvlreq1 = 1;  
                    gear2 = "Rune Cloth robe"; lvlreq2 = 10;    
                    gear3 = "Ultamage shirt"; lvlreq3 = 20; ;
                    ShowShopItems.ShowShopItem(gear1, lvlreq1);
                    ShowShopItems.ShowShopItem(gear2, lvlreq2);
                    ShowShopItems.ShowShopItem(gear3, lvlreq3);
                    chosenItem = UserItemChoise.GetUserInput();
                    slot = 3;
                }
                if (choise == 3)
                {

                    gear1 = "Wool pants"; lvlreq1 = 1; 
                    gear2 = "Wizard robe"; lvlreq2 = 10; 
                    gear3 = "Ultimate soft pants"; lvlreq3 = 20; 
                    ShowShopItems.ShowShopItem(gear1, lvlreq1);
                    ShowShopItems.ShowShopItem(gear2, lvlreq2);
                    ShowShopItems.ShowShopItem(gear3, lvlreq3);
                    chosenItem = UserItemChoise.GetUserInput(); 
                    slot = 4;
                }
            }
               
                if (ArmorType == "Leather") {
                    Console.Clear();
                    choise = ShowGearSlotsOptions.ShowGearSlotOption();
                    if (choise == 1)
                    {
                        gear1 = "leather Helmet"; lvlreq1 = 1; 
                        gear2 = "Thick hide helmet"; lvlreq2 = 10; 
                        gear3 = "Venomsaur helmet"; lvlreq3 = 20;
                        ShowShopItems.ShowShopItem(gear1, lvlreq1);
                        ShowShopItems.ShowShopItem(gear2, lvlreq2);
                        ShowShopItems.ShowShopItem(gear3, lvlreq3);
                        chosenItem = UserItemChoise.GetUserInput();
                        slot = 2;

                    }
                    if (choise == 2)
                    {
                        gear1 = "leather shirt"; lvlreq1 = 1; 
                        gear2 = "leather winter robe"; lvlreq2 = 10; 
                        gear3 = "Ulrics shirt"; lvlreq3 = 20;
                        ShowShopItems.ShowShopItem(gear1, lvlreq1);
                        ShowShopItems.ShowShopItem(gear2, lvlreq2);
                        ShowShopItems.ShowShopItem(gear3, lvlreq3);
                        chosenItem = UserItemChoise.GetUserInput();
                        slot = 3;

                    }
                    if (choise == 3)
                    {
                        gear1 = "leather pants"; lvlreq1 = 1;   
                        gear2 = "heavy hide pants"; lvlreq2 = 10;   
                        gear3 = "Anzients pants"; lvlreq3 = 20;     
                        ShowShopItems.ShowShopItem(gear1, lvlreq1);
                        ShowShopItems.ShowShopItem(gear2, lvlreq2);
                        ShowShopItems.ShowShopItem(gear3, lvlreq3);
                        chosenItem = UserItemChoise.GetUserInput();
                        slot = 4;
                    }
    
                  
                }
                if (ArmorType == "Mail")
                {
                    Console.Clear();
                    choise = ShowGearSlotsOptions.ShowGearSlotOption();

                    if (choise == 1)
                    {
                        gear1 = "iron helmet"; lvlreq1 = 1;                   
                        gear2 = "steel cuffed helmet"; lvlreq2 = 10;    
                        gear3 = "God of war helmet"; lvlreq3 = 20;  
                        ShowShopItems.ShowShopItem(gear1, lvlreq1);
                        ShowShopItems.ShowShopItem(gear2, lvlreq2);
                        ShowShopItems.ShowShopItem(gear3, lvlreq3);
                        chosenItem = UserItemChoise.GetUserInput();
                        slot = 2;

                    }
                    if (choise == 2)
                    {
                        gear1 = "iron chainmail"; lvlreq1 = 1;  
                        gear2 = "steel chainmail"; lvlreq2 = 10;    
                        gear3 = "God of war shirt"; lvlreq3 = 20;   
                        ShowShopItems.ShowShopItem(gear1, lvlreq1);
                        ShowShopItems.ShowShopItem(gear2, lvlreq2);
                        ShowShopItems.ShowShopItem(gear3, lvlreq3);
                        chosenItem = UserItemChoise.GetUserInput();
                        slot = 3;

                    }
                    if (choise == 3)
                    {
                        gear1 = "iron pants"; lvlreq1 = 1; 
                        gear2 = "steel pants"; lvlreq2 = 10; 
                        gear3 = "God of war pants"; lvlreq3 = 20; 
                        ShowShopItems.ShowShopItem(gear1, lvlreq1);
                        ShowShopItems.ShowShopItem(gear2, lvlreq2);
                        ShowShopItems.ShowShopItem(gear3, lvlreq3);
                        chosenItem = UserItemChoise.GetUserInput();
                        slot = 4;
                    };
                
                }
                if (ArmorType == "Plate")
                {
                    Console.Clear();
                    choise = ShowGearSlotsOptions.ShowGearSlotOption();

                    if (choise == 1)
                    {
                        gear1 = "Plated helmet"; lvlreq1 = 1; 
                        gear2 = "heacy plate helmet"; lvlreq2 = 10; 
                        gear3 = "Ancient plate helmet"; lvlreq3 = 20; 
                        ShowShopItems.ShowShopItem(gear1, lvlreq1);
                        ShowShopItems.ShowShopItem(gear2, lvlreq2 );
                        ShowShopItems.ShowShopItem(gear3, lvlreq3);
                        chosenItem = UserItemChoise.GetUserInput();
                        slot = 2;
                    }
                    if (choise == 2)
                    {
                        gear1 = "plate armor"; lvlreq1 = 1; 
                        gear2 = "knight armor"; lvlreq2 = 10; 
                        gear3 = "Paladin armor"; lvlreq3 = 20; 
                        ShowShopItems.ShowShopItem(gear1, lvlreq1);
                        ShowShopItems.ShowShopItem(gear2, lvlreq2);
                        ShowShopItems.ShowShopItem(gear3, lvlreq3);
                        chosenItem = UserItemChoise.GetUserInput();
                        slot = 3;
                    }
                    if (choise == 3)
                    {
                        gear1 = "Plate leggings"; lvlreq1 = 1; 
                        gear2 = "Agumus plated leggings"; lvlreq2 = 10;
                        gear3 = "Lost gods legs"; lvlreq3 = 20; 
                        ShowShopItems.ShowShopItem(gear1, lvlreq1);
                        ShowShopItems.ShowShopItem(gear2, lvlreq2);
                        ShowShopItems.ShowShopItem(gear3, lvlreq3);
                        chosenItem = UserItemChoise.GetUserInput();
                        slot = 4;
                    }
                
         
                }
            armor1 = new() { Name = gear1, RequiredLevel = lvlreq1, Dex = RandomGenerator.RandomStat(), Magic = RandomGenerator.RandomStat(), Str = RandomGenerator.RandomStat() };
            armor2 = new() { Name = gear2, RequiredLevel = lvlreq2, Dex = RandomGenerator.RandomStat(), Magic = RandomGenerator.RandomStat(), Str = RandomGenerator.RandomStat() };
            armor3 = new() { Name = gear3, RequiredLevel = lvlreq3, Dex = RandomGenerator.RandomStat(), Magic = RandomGenerator.RandomStat(), Str = RandomGenerator.RandomStat() };
            
            if (chosenItem == 1)
            {

               return  SetArmor.EquipGear(slot, player, armor1);
               
            }
            if (chosenItem == 2)
            {
               return SetArmor.EquipGear(slot, player, armor2);
                
            }
            if (chosenItem == 3)
            {
                return SetArmor.EquipGear(slot, player, armor3);
            }
                return null!;
 

        }

    }
}
