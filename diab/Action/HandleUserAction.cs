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
                string? userSelectedAction = SelectionScreen.ActionList();

                if (!int.TryParse(userSelectedAction, out int userSelectedActionInt) && userSelectedAction != null)
                {
                    Console.WriteLine("Pls write a number FROM 1-6 and not alphabets.");

                }
                else
                {
                    if (userSelectedActionInt == 6)
                    {
                        Console.Clear();
                        Console.WriteLine("Shutting down...");
                        break;
                    }
                    if (userSelectedActionInt == 1)
                    {
                        Console.Clear();
                        LevelingAttribute.LevelUp(ref player);
                        Console.WriteLine("Level up! " + player.Level);
                    }
                    if (userSelectedActionInt == 2)
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
                                playerSelectedGear= weapon.EquipWeapon(selectedWeaponType, player);
                                Console.WriteLine($"hello {playerSelectedGear}");
                                if (playerSelectedGear == "")
                                {
                                    Console.WriteLine("You arent fit for that item type");
                                    continue;                                
                                }
                                else
                                {                               
                                    break;
                                }                          
                            }
                            Console.WriteLine("Selected: " + playerSelectedGear );
                            PlayerItemList.DisplayWeapons(playerSelectedGear, weapon, player);
                            SelectionScreen.ShowAcquiredItem(player.Weapon!, weapon.WeaponType!); // change
                            Console.ReadKey();                     
                        }
                        if (choose == 2)
                        {
                            Console.Clear();
                            int selectedArmorType;
                        
                            Armor armor = new();
                            while (true)
                            {
                                selectedArmorType = ItemShopsCatalogue.ShowArmorsCatalogue();
                                playerSelectedGear =  armor.Equip(selectedArmorType, player);
                                if (playerSelectedGear == "")
                                {
                                    Console.WriteLine("You arent fit for that item type");
                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            Console.WriteLine("Selected: " + playerSelectedGear);
                            string name = PlayerItemList.DisplayArmors(playerSelectedGear, armor, player); //create head, body, legs
                            SelectionScreen.ShowAcquiredItem(name, armor.ArmorType!); //change
                            Console.ReadKey();
                        }
                                                  
                        }
                    }
                    if (userSelectedActionInt == 3)
                    {
                        //damage option show how much dmg player does
                        Console.Clear();
                        int damage = player.GetTotalDamage(player.Class!);
                        Console.WriteLine("Total damage : "+ damage);
                      
                    }
                    if (userSelectedActionInt == 4)
                    {
                        //total attributes = show total attribute
                    }
                    if (userSelectedActionInt == 5)
                    {                       
                        player.ShowInformation();
                    }
                    else
                    {
                        Console.WriteLine("PLEASE A SELECT A CORRECT Action 1-5");
                        continue;
                    };

                }
            }

        }
    }

