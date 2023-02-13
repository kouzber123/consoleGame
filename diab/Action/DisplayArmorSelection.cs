﻿using diab.ConsoleTexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diab
{
    public class DisplayArmorSelection
    {
        /// <summary>
        /// Shows the options of the armor this function handles changing user gear
        /// </summary>
        /// <param name="ArmorType"></param>
        /// <param name="armor"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        public static string DisplayArmorList(string ArmorType, Armor armor, Hero player)
        {
            string? gear1="", gear2="", gear3 = "";
            int lvlreq1=0, lvlreq2=0, lvlreq3 = 0, defense1 = 0, defense2 = 0, defense3 = 0, chosenItem = 0, armorType = 0, slot = 0;
            switch (ArmorType)
            {
                case "cloth":
                    Console.Clear();
                    armorType = 1;
                    int choise = ShowGearSlotsOptions.ShowGearSlotOption();

                    if (choise == 1)
                    {
                        gear1 = "wool hat"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "Wizard hat"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "Arch wizard"; lvlreq3 = 20; defense3 = 500;
                        ShowShopItems.ShowShopItem(gear1, lvlreq1, defense1);
                        ShowShopItems.ShowShopItem(gear2, lvlreq2, defense2);
                        ShowShopItems.ShowShopItem(gear3, lvlreq3, defense3);
                        chosenItem = UserItemChoise.GetUserInput();
                        slot = 2;

                    }

                    if (choise == 2)
                    {
                        gear1 = "wool shirt"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "Rune Cloth robe"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "Ultamage shirt"; lvlreq3 = 20; defense3 = 500;
                        ShowShopItems.ShowShopItem(gear1, lvlreq1, defense1);
                        ShowShopItems.ShowShopItem(gear2, lvlreq2, defense2);
                        ShowShopItems.ShowShopItem(gear3, lvlreq3, defense3);
                        chosenItem = UserItemChoise.GetUserInput();
                        slot = 3;
                    }
                    if (choise == 3)
                    {

                        gear1 = "Wool pants"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "Wizard robe"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "Ultimate soft pants"; lvlreq3 = 20; defense3 = 500;
                        ShowShopItems.ShowShopItem(gear1, lvlreq1, defense1);
                        ShowShopItems.ShowShopItem(gear2, lvlreq2, defense2);
                        ShowShopItems.ShowShopItem(gear3, lvlreq3, defense3);
                        chosenItem = UserItemChoise.GetUserInput(); ;                      
                        slot = 4;
                    }
                    SetArmor.PlayerChoiseOfArmor(ref chosenItem, ref armor, ref gear1, ref gear2, ref gear3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref defense1, ref defense2, ref defense3);
                    armor.Equip(armorType);
                    player.Defense += armor.ArmorDefense;
                    armor.EquipGear(slot, player);
                    return armor.Name!;


                case "leather":
                    Console.Clear();
                    armorType = 2;
                    choise = ShowGearSlotsOptions.ShowGearSlotOption();
                    if (choise == 1)
                    {
                        gear1 = "leather Helmet"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "Thick hide helmet"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "Venomsaur helmet"; lvlreq3 = 20; defense3 = 500;
                        ShowShopItems.ShowShopItem(gear1, lvlreq1, defense1);
                        ShowShopItems.ShowShopItem(gear2, lvlreq2, defense2);
                        ShowShopItems.ShowShopItem(gear3, lvlreq3, defense3);
                        chosenItem = UserItemChoise.GetUserInput();
                        slot = 2;

                    }
                    if (choise == 2)
                    {
                        gear1 = "leather shirt"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "leather winter robe"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "Ulrics shirt"; lvlreq3 = 20; defense3 = 500;
                        ShowShopItems.ShowShopItem(gear1, lvlreq1, defense1);
                        ShowShopItems.ShowShopItem(gear2, lvlreq2, defense2);
                        ShowShopItems.ShowShopItem(gear3, lvlreq3, defense3);
                        chosenItem = UserItemChoise.GetUserInput();
                        slot = 3;

                    }
                    if (choise == 3)
                    {
                        gear1 = "leather pants"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "heavy hide pants"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "Anzients pants"; lvlreq3 = 20; defense3 = 500;
                        ShowShopItems.ShowShopItem(gear1, lvlreq1, defense1);
                        ShowShopItems.ShowShopItem(gear2, lvlreq2, defense2);
                        ShowShopItems.ShowShopItem(gear3, lvlreq3, defense3);
                        chosenItem = UserItemChoise.GetUserInput();
                        slot = 4;
                    }
                    SetArmor.PlayerChoiseOfArmor(ref chosenItem, ref armor, ref gear1, ref gear2, ref gear3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref defense1, ref defense2, ref defense3);
                    player.Defense += armor.ArmorDefense;
                    armor.Equip(armorType);
                    armor.EquipGear(slot, player);
                    return armor.Name!;

                case "mail":
                    Console.Clear();
                    armorType = 3;
                    choise = ShowGearSlotsOptions.ShowGearSlotOption();

                    if (choise == 1)
                    {
                        gear1 = "iron helmet"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "steel cuffed helmet"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "God of war helmet"; lvlreq3 = 20; defense3 = 5000;
                        ShowShopItems.ShowShopItem(gear1, lvlreq1, defense1);
                        ShowShopItems.ShowShopItem(gear2, lvlreq2, defense2);
                        ShowShopItems.ShowShopItem(gear3, lvlreq3, defense3);
                        chosenItem = UserItemChoise.GetUserInput();
                            
                        slot = 2;

                    }
                    if (choise == 2)
                    {
                        gear1 = "iron chainmail"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "steel chainmail"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "God of war shirt"; lvlreq3 = 20; defense3 = 5000;
                        ShowShopItems.ShowShopItem(gear1, lvlreq1, defense1);
                        ShowShopItems.ShowShopItem(gear2, lvlreq2, defense2);
                        ShowShopItems.ShowShopItem(gear3, lvlreq3, defense3);
                        chosenItem = UserItemChoise.GetUserInput();
                        slot = 3;

                    }
                    if (choise == 3)
                    {
                        gear1 = "iron pants"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "steel pants"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "God of war pants"; lvlreq3 = 20; defense3 = 5000;
                        ShowShopItems.ShowShopItem(gear1, lvlreq1, defense1);
                        ShowShopItems.ShowShopItem(gear2, lvlreq2, defense2);
                        ShowShopItems.ShowShopItem(gear3, lvlreq3, defense3);
                        chosenItem = UserItemChoise.GetUserInput();
                        slot = 4;
                    };
                    SetArmor.PlayerChoiseOfArmor(ref chosenItem, ref armor, ref gear1, ref gear2, ref gear3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref defense1, ref defense2, ref defense3);
                    player.Defense += armor.ArmorDefense;
                    armor.Equip(armorType);
                    armor.EquipGear(slot, player);
                    return armor.Name!;

                case "plate":
                    Console.Clear();
                    armorType = 4;
                    choise = ShowGearSlotsOptions.ShowGearSlotOption();

                    if (choise == 1)
                    {
                        gear1 = "Plated helmet"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "heacy plate helmet"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "Ancient plate helmet"; lvlreq3 = 20; defense3 = 5000;
                        ShowShopItems.ShowShopItem(gear1, lvlreq1, defense1);
                        ShowShopItems.ShowShopItem(gear2, lvlreq2, defense2);
                        ShowShopItems.ShowShopItem(gear3, lvlreq3, defense3);
                        chosenItem = UserItemChoise.GetUserInput();
                        slot = 2;
                    }
                    if (choise == 2)
                    {
                        gear1 = "plate armor"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "knight armor"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "Paladin armor"; lvlreq3 = 20; defense3 = 500;
                        ShowShopItems.ShowShopItem(gear1, lvlreq1, defense1);
                        ShowShopItems.ShowShopItem(gear2, lvlreq2, defense2);
                        ShowShopItems.ShowShopItem(gear3, lvlreq3, defense3);
                        chosenItem = UserItemChoise.GetUserInput();
                      
                        slot = 3;
                    }
                    if (choise == 3)
                    {
                        gear1 = "Plate leggings"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "Agumus plated leggings"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "Lost gods legs"; lvlreq3 = 20; defense3 = 5000;
                        ShowShopItems.ShowShopItem(gear1, lvlreq1, defense1);
                        ShowShopItems.ShowShopItem(gear2, lvlreq2, defense2);
                        ShowShopItems.ShowShopItem(gear3, lvlreq3, defense3);
                        chosenItem = UserItemChoise.GetUserInput();
                        
                        slot = 4;
                    }
                    SetArmor.PlayerChoiseOfArmor(ref chosenItem, ref armor, ref gear1, ref gear2, ref gear3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref defense1, ref defense2, ref defense3);
                    armor.Equip(armorType);
                    player.Defense = armor.ArmorDefense;
                    armor.EquipGear(slot, player);

                    return armor.Name!;

                default:
                    return "";

            }

        }

    }
}
