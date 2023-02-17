namespace diab
{ 

    internal class HandleUserAction
    {
        /// <summary>
        /// This is action bar for user actions
        /// 6 options
        /// 1) 1 level up, 2) Equip a gear > armor or weapon, 3) shows total damage, 4) total attributes, 5) status 6) quit game
        /// 
        /// we create new armor and weapon class, armor we only need to check the type and weapon will be user weapon
        /// </summary>
        /// <param name="player"></param>
        /// 

        public static void HandleUserActions(Player player)
        {
            Armor armor = new();
            Weapon weapon = new();
         

            while (true)
            {
               try
                {              
                 int userSelectedAction = int.Parse(SelectionScreen.ActionList()!);

                    if (userSelectedAction >=1 && userSelectedAction <=6)
                    {
                        if (userSelectedAction == 6)
                        {
                            Console.Clear();
                            Console.WriteLine("Shutting down...");
                            break;
                        }
                        if (userSelectedAction == 1)
                        {
                            Console.Clear();
                            player.LevelUp(player);
                            Console.WriteLine("Level up! " + player.Level);
                        }
                        if (userSelectedAction == 2)
                        {
                            //Equip a gear > choose gear option > weapon or armor > inventory
                            int choose = SelectWeaponOrArmor.SelectWeaponOrArmors();
                            string playerSelectedGear = string.Empty;
                            if (choose == 1) //refactor later to differenct file
                            {  
                                int selectedWeaponType;
                                while (true)
                                {

                                    selectedWeaponType = ItemShopsCatalogue.ShowWeaponsCatalogue();
                                    string weaponType = Weapon.PlayerWeapon(selectedWeaponType);                                
                                    try
                                    {
                                        
                                        if (!player.Class.GearRestrictions(weaponType))
                                        {
                                        
                                           throw new InvalidWeaponException(weaponType + "Cannot be worn by " + player.HeroClass);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Selected: " + weaponType);
                                            string selectedweapon = PlayerItemList.DisplayWeapons(weaponType, weapon, player);
                                            Console.WriteLine(selectedweapon);
                                            if (selectedweapon != null)
                                            {
                                                SelectionScreen.ShowAcquiredItem(player.Weapon?.Name!, player.Weapon?.WeaponTypes!); // change
                                                Console.ReadKey();
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Selected: weapon is too high level for you, level required");
                                            }
                                        }
                                    }
                                    catch (InvalidWeaponException m)
                                    {

                                        Console.WriteLine(m.Message);
                                    }                                
                                }
                            
                            }
                            if (choose == 2)
                            {
                                Console.Clear();
                                int selectedArmorType;
                               
                                while (true)
                                {                             
                                    selectedArmorType = ItemShopsCatalogue.ShowArmorsTypeCatalogue(); // return 
                                    string armorType = Armor.PlayerArmor(selectedArmorType);
                                   
                                    try
                                    {                                    
                                        if (!player.Class.GearRestrictions(armorType))
                                    {

                                            throw new InvalidArmorException(armorType + " cannot be worn by " + player.HeroClass);                                                                                 
                                        }
                                        else 
                                        {

                                            Console.WriteLine("Selected: " + armorType );
                                            string name = PlayerItemList.DisplayArmors(armorType, player); //create head, body, legs
                                            Console.WriteLine("-------");
                                            Console.WriteLine("name " + name);
                                            Console.WriteLine("selected gear " +  armor.ArmorType);
                                            if (name != null)
                                            {

                                                SelectionScreen.ShowAcquiredItem(name, armorType); //change
                                                Console.ReadKey();
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Level is too low for item ");
                                            }
                                        }
                                  
                                    }
                                    catch (InvalidArmorException m)
                                    {

                                        Console.WriteLine(m.Message);
                                    }
                                 
                                }               
                            }
                        }
                    }
                    if (userSelectedAction == 3)
                    {
                      
                        Console.Clear();
                        int damage = player.Damage(player);
                        Console.WriteLine("Total damage : " + damage);
                        Console.WriteLine();
                    }
                    if (userSelectedAction == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("Your total stats from levels and gear: "+  player.Class.TotalAttributes(player));
                        Console.WriteLine();
                    }
                    if (userSelectedAction == 5)
                    {
                        ShowPlayerInformation.ShowInformation(player);
                    }

                }
                
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a number");
                }
               

                }
            }

        }
    }

