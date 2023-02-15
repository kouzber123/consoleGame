using static diab.CheckItemType;

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
                            
                            Console.WriteLine(player.CheckItemType("Sword"));
                        }
                        if (userSelectedAction == 2)
                        {
                            //Equip a gear > choose gear option > weapon or armor > inventory
                            int choose = SelectWeaponOrArmor.SelectWeaponOrArmors();
                            string playerSelectedGear;
                            if (choose == 1) //refactor later to differenct file
                            {

           
                               
                                int selectedWeaponType;
                                while (true)
                                {

                                    selectedWeaponType = ItemShopsCatalogue.ShowWeaponsCatalogue();
                                  
                                    playerSelectedGear = IsCorrectGearType(selectedWeaponType,new OptionalClassParams { Class1 = weapon, Class2= null! }, player);
                                    try
                                    {
                                        
                                        if (playerSelectedGear != "")
                                        {
                                        
                                            Console.WriteLine("Selected: " + playerSelectedGear);
                                            string selectedweapon = PlayerItemList.DisplayWeapons(playerSelectedGear, weapon, player);
                                            if(selectedweapon != null)
                                            {
                                                SelectionScreen.ShowAcquiredItem(player.Weapon!.Name!, weapon.WeaponType!); // change
                                                Console.ReadKey();
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Selected: " + playerSelectedGear + " is too high level for you, level required" + weapon.RequiredLevel);
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine(player.Class.ClassName+" cannot use this type of weapon: " + Weapon.PlayerWeapon(selectedWeaponType));
                                        }
                                       
                                    }
                                    catch (ArgumentNullException)
                                    {

                                        Console.WriteLine("Something unexpectedr");
                                    }
                                  
                                }
                            
                            }
                            if (choose == 2)
                            {
                                Console.Clear();
                                int selectedArmorType;
                               
                                while (true)
                                {
                                
                                    selectedArmorType = ItemShopsCatalogue.ShowArmorsCatalogue();

                                    playerSelectedGear = IsCorrectGearType(selectedArmorType, new OptionalClassParams { Class1 = null!, Class2 = armor }, player);
                                    try
                                    {
                                       
                                        if (playerSelectedGear != "")
                                    {
                                         
                                            Console.WriteLine("Selected: " + playerSelectedGear);
                                            string name = PlayerItemList.DisplayArmors(playerSelectedGear, player); //create head, body, legs
                                            Console.WriteLine("-------");
                                            Console.WriteLine("name "+name);
                                            Console.WriteLine("selected gear "+playerSelectedGear);

                          
                                            if(name != null)
                                            {

                                                SelectionScreen.ShowAcquiredItem(name, armor.ArmorType!); //change
                                                Console.ReadKey();
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Level is too low required level: " + name);

                                            }
                                     }
                                        else
                                        {
                                            Console.WriteLine(player.Class.ClassName+ " Cannot wear that type of armor " + Armor.PlayerArmor(selectedArmorType));
                                        }
                                  
                                    }
                                    catch (ArgumentNullException)
                                    {

                                        Console.WriteLine("Null exception");
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
                        

                    }
                    if (userSelectedAction == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("Your total stats from levels and gear: ");
                        Console.WriteLine(player.Class.TotalAttributes(player));
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

