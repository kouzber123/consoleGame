using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace diab
{
    internal class HandleUserAction
    {
        public static void HandleUserActions(Hero player) 
        {
            //player.SetStatPoints(player.Class);
            PlayerClasses.SetStatPoints(player);
          
            player.ShowInformation();
            while (true)
            {
                string? userSelectedAction = SelectionScreen.ActionList();

                if (!Int32.TryParse(userSelectedAction, out int userSelectedActionInt) && userSelectedAction != null) {
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
                        int choose = Int32.Parse(Console.ReadLine()!);

                        if (choose == 1) //refactor later to differenct file
                        {                         
                            int selectedWeaponType = ItemShopsCatalogue.ShowWeaponsCatalogue();
                            string weaponType = Weapon.PlayerWeapon(selectedWeaponType);
                            Console.WriteLine("selected weapontype {0}", weaponType);
                            //create UI for singular weapon with stats requirements
                            //either weapon = type or name
                            //weapon type isnt a weapon its option > when selecting option open a new catalogue
                            Weapon weapon = new();
                            PlayerItemList.DisplayWeaponList(weaponType, weapon, player);
                            SelectionScreen.ShowAcquiredItem(player.Weapon!, weapon.WeaponType!);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        if (choose == 2)
                        {
                            int selectedArmorType = ItemShopsCatalogue.ShowArmorsCatalogue();
                            string ArmorType = Armor.PlayerArmor(selectedArmorType);

                            //create body part selection
                            int ArmorSlot = 
                            player.Body = ArmorType;
                            Armor armor = new();
                            PlayerItemList.DisplayArmorList(ArmorType, armor, player); //create head, body, legs
                            SelectionScreen.ShowAcquiredItem(player.w)
                            Console.ReadKey();
                            //Console.Clear();
                            //next create select for helmet, body, legs
                        }
                    }
                    if (userSelectedActionInt == 3)
                    {
                        //damage option show how much dmg player does
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
