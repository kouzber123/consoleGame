namespace diab
{
    internal class HandleUserAction
    {
        public static void HandleUserActions(Hero player)
        {
            //player.SetStatPoints(player.Class);
          
            while (true)
            {
                string? userSelectedAction = SelectionScreen.ActionList();

                if (!int.TryParse(userSelectedAction, out int userSelectedActionInt) && userSelectedAction != null)
                {
                    Console.WriteLine("Pls write a number FROM 1-6 and not alphabets.");

                }
                else
                {
                    //create another function
                    if (userSelectedActionInt == 6)
                    {
                        Console.Clear();
                        Console.WriteLine("Shutting down...");
                        break;
                    }
                    if (userSelectedActionInt == 1)
                    {
                        Console.Clear();
                        PlayerClasses.LevelUp(ref player);
                        Console.WriteLine("Level up! " + player.Level);
                    }
                    if (userSelectedActionInt == 2)
                    {
                        //Equip a gear > choose gear option > weapon or armor > inventory
                        Console.Clear();
                        Console.WriteLine("|GEAR HUB|");
                        Console.WriteLine("(1) Weapons");
                        Console.WriteLine("(2) Gears");
                        int choose = int.Parse(Console.ReadLine()!);

                        if (choose == 1) //refactor later to differenct file
                        {
                            int selectedWeaponType = ItemShopsCatalogue.ShowWeaponsCatalogue();
                            string weaponType = Weapon.PlayerWeapon(selectedWeaponType);
                            Console.WriteLine("selected weapontype {0}", weaponType);
                            Weapon weapon = new();
                            PlayerItemList.DisplayWeapons(weaponType, weapon, player);
                            SelectionScreen.ShowAcquiredItem(player.Weapon!, weapon.WeaponType!);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        if (choose == 2)
                        {
                            Console.Clear();
                            int selectedArmorType = ItemShopsCatalogue.ShowArmorsCatalogue();
                            string ArmorType = Armor.PlayerArmor(selectedArmorType);
                            Console.WriteLine("selected armorType {0}", ArmorType);
                            Armor armor = new();
                            string name = PlayerItemList.DisplayArmors(ArmorType, armor, player); //create head, body, legs
                            SelectionScreen.ShowAcquiredItem(name, armor.ArmorType!);
                            Console.ReadKey();
                         
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
                        Console.Clear();
                        Console.WriteLine("Hero Current Status");
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
}
