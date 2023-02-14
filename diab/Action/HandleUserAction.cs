namespace diab
{ 

    internal class HandleUserAction
    {
        /// <summary>
        /// This is action bar for user actions
        /// 6 options
        /// 1) 1 level up, 2) Equip a gear > armor or weapon, 3) shows total damage, 4) total attributes, 5) status 6) quit game
        /// </summary>
        /// <param name="player"></param>
        public static void HandleUserActions(Player player)
        {
            
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
                            string playerSelectedGear;
                            if (choose == 1) //refactor later to differenct file
                            {

                                Weapon weapon = new();
                                int selectedWeaponType;
                                while (true)
                                {

                                    selectedWeaponType = ItemShopsCatalogue.ShowWeaponsCatalogue();
                                    playerSelectedGear = weapon.EquipWeapon(selectedWeaponType, player);
                                    try
                                    {
                                        
                                        if (playerSelectedGear != "")
                                        {
                                            Console.WriteLine("Selected: " + playerSelectedGear);
                                            string selectedweapon = PlayerItemList.DisplayWeapons(playerSelectedGear, weapon, player);
                                            if(selectedweapon != null)
                                            {
                                                SelectionScreen.ShowAcquiredItem(player.Weapon!, weapon.WeaponType!); // change
                                                Console.ReadKey();
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Selected: " + playerSelectedGear + " is not eligible for you!");
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
                                Armor armor = new();
                                while (true)
                                {
                                    selectedArmorType = ItemShopsCatalogue.ShowArmorsCatalogue();
                                    playerSelectedGear = armor.Equip(selectedArmorType, player);
                                    try
                                    {
                                       
                                        if (playerSelectedGear != "")
                                    {
                                            Console.WriteLine("Selected: " + playerSelectedGear);
                                            string name = PlayerItemList.DisplayArmors(playerSelectedGear, armor, player); //create head, body, legs
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
                                                Console.WriteLine("Level is too low");

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
                        //damage option show how much dmg player does
                        Console.Clear();
                        int damage = player.Damage(player);
                        Console.WriteLine("Total damage : " + damage);
                        

                    }
                    if (userSelectedAction == 4)
                    {
                        //total attributes = show total attribute
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

