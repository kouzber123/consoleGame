using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diab
{
    internal class PlayerItemList
    {
       
        public static void DisplayWeaponList(string WeaponType, Weapon weapon, Hero player)
        {
            int chosenItem;

            string? weapon1, weapon2, weapon3;
            int lvlreq1, lvlreq2, lvlreq3, damage1, damage2, damage3, weaponType;
            switch (WeaponType)
            {
                case "Sword":
                    weaponType = 6;
                    weapon1 = "Iron Sword"; lvlreq1 = 1; damage1 = 20;
                    weapon2 = "Steel Sword"; lvlreq2 = 10; damage2 = 50;
                    weapon3 = "Magic Sword"; lvlreq3 = 20; damage3 = 500;
                    SelectionScreen.ShowShopItems(weapon1, lvlreq1, damage1);
                    SelectionScreen.ShowShopItems(weapon2, lvlreq2, damage2);
                    SelectionScreen.ShowShopItems(weapon3, lvlreq3, damage3);
                    chosenItem = SelectionScreen.GetUserInput();
                    ItemShopsCatalogue.PlayerChoiseOfWeapon(ref chosenItem, ref weapon, ref weapon1, ref weapon2, ref weapon3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref damage1, ref damage2, ref damage3);

                    player.Weapon = weapon.Name;
                    player.Damage = weapon.WeaponDamage;
                    weapon.EquipWeapon(weaponType);
                    break;
                case "Axe":
                    weaponType = 1;
                    weapon1 = "Iron axe"; lvlreq1 = 1; damage1 = 20;
                    weapon2 = "Steel Axe"; lvlreq2 = 10; damage2 = 50;
                    weapon3 = "Rune Axe"; lvlreq3 = 20; damage3 = 500;
                    SelectionScreen.ShowShopItems(weapon1, lvlreq1, damage1);
                    SelectionScreen.ShowShopItems(weapon2, lvlreq2, damage2);
                    SelectionScreen.ShowShopItems(weapon3, lvlreq3, damage3); ;
                    chosenItem = SelectionScreen.GetUserInput();
                    ItemShopsCatalogue.PlayerChoiseOfWeapon(ref chosenItem, ref weapon, ref weapon1, ref weapon2, ref weapon3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref damage1, ref damage2, ref damage3);
                    weapon.EquipWeapon(weaponType);
                    player.Weapon = weapon.Name;
                    player.Damage = weapon.WeaponDamage;
                    break;
                case "Hammer":
                    weaponType = 4;
                    weapon1 = "wooden hammer"; lvlreq1 = 1; damage1 = 20;
                    weapon2 = "Iron hammer"; lvlreq2 = 10; damage2 = 50;
                    weapon3 = "Rune hammer"; lvlreq3 = 20; damage3 = 500;
                    SelectionScreen.ShowShopItems(weapon1, lvlreq1, damage1);
                    SelectionScreen.ShowShopItems(weapon2, lvlreq2, damage2);
                    SelectionScreen.ShowShopItems(weapon3, lvlreq3, damage3);
                    chosenItem = SelectionScreen.GetUserInput();
                    ItemShopsCatalogue.PlayerChoiseOfWeapon(ref chosenItem, ref weapon, ref weapon1, ref weapon2, ref weapon3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref damage1, ref damage2, ref damage3);
                    weapon.EquipWeapon(weaponType);
                    player.Weapon = weapon.Name;
                    player.Damage = weapon.WeaponDamage;

                    break;
                case "Dagger":
                    weaponType = 3;
                    weapon1 = "shiv"; lvlreq1 = 1; damage1 = 20;
                    weapon2 = "iron dagger"; lvlreq2 = 10; damage2 = 50;
                    weapon3 = "Steel dagger"; lvlreq3 = 20; damage3 = 500;
                    SelectionScreen.ShowShopItems(weapon1, lvlreq1, damage1);
                    SelectionScreen.ShowShopItems(weapon2, lvlreq2, damage2);
                    SelectionScreen.ShowShopItems(weapon3, lvlreq3, damage3);
                    chosenItem = SelectionScreen.GetUserInput(); ;
                    ItemShopsCatalogue.PlayerChoiseOfWeapon(ref chosenItem, ref weapon, ref weapon1, ref weapon2, ref weapon3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref damage1, ref damage2, ref damage3);
                    weapon.EquipWeapon(weaponType);
                    player.Weapon = weapon.Name;
                    player.Damage = weapon.WeaponDamage;

                    break;
                case "Staff":
                    weaponType = 5;
                    weapon1 = "old stick"; lvlreq1 = 1; damage1 = 20;
                    weapon2 = "wooden cane"; lvlreq2 = 10; damage2 = 50;
                    weapon3 = "Arch wizard staff"; lvlreq3 = 20; damage3 = 500;
                    SelectionScreen.ShowShopItems(weapon1, lvlreq1, damage1);
                    SelectionScreen.ShowShopItems(weapon2, lvlreq2, damage2);
                    SelectionScreen.ShowShopItems(weapon3, lvlreq3, damage3);
                    chosenItem = SelectionScreen.GetUserInput();
                    ItemShopsCatalogue.PlayerChoiseOfWeapon(ref chosenItem, ref weapon, ref weapon1, ref weapon2, ref weapon3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref damage1, ref damage2, ref damage3);
                    weapon.EquipWeapon(weaponType);
                    player.Weapon = weapon.Name;
                    player.Damage = weapon.WeaponDamage;

                    break;
                case "Bow":
                    weaponType = 2;
                    weapon1 = "wooden bow"; lvlreq1 = 1; damage1 = 20;
                    weapon2 = "long bow"; lvlreq2 = 10; damage2 = 50;
                    weapon3 = "Composite Bow"; lvlreq3 = 20; damage3 = 500;
                    SelectionScreen.ShowShopItems(weapon1, lvlreq1, damage1);
                    SelectionScreen.ShowShopItems(weapon2, lvlreq2, damage2);
                    SelectionScreen.ShowShopItems(weapon3, lvlreq3, damage3);
                    chosenItem = SelectionScreen.GetUserInput(); ;

                    ItemShopsCatalogue.PlayerChoiseOfWeapon(ref chosenItem, ref weapon, ref weapon1, ref weapon2, ref weapon3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref damage1, ref damage2, ref damage3);
                    weapon.EquipWeapon(weaponType);
                    player.Weapon = weapon.Name;
                    player.Damage = weapon.WeaponDamage;
                    break;
                case "Wand":
                    weaponType = 7;
                    weapon1 = "Old mans wand"; lvlreq1 = 1; damage1 = 20;
                    weapon2 = "Harry's wand"; lvlreq2 = 10; damage2 = 50;
                    weapon3 = "Sussy wand"; lvlreq3 = 20; damage3 = 500;
                    SelectionScreen.ShowShopItems(weapon1, lvlreq1, damage1);
                    SelectionScreen.ShowShopItems(weapon2, lvlreq2, damage2);
                    SelectionScreen.ShowShopItems(weapon3, lvlreq3, damage3);
                    chosenItem = SelectionScreen.GetUserInput();
                    ItemShopsCatalogue.PlayerChoiseOfWeapon(ref chosenItem, ref weapon, ref weapon1, ref weapon2, ref weapon3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref damage1, ref damage2, ref damage3);
                    weapon.EquipWeapon(weaponType);
                    player.Weapon = weapon.Name;
                    player.Damage = weapon.WeaponDamage;
                    break;

                default:
                    break;
            }
        } 
        public static string DisplayArmorList(string ArmorType, Armor armor, Hero player)
        {
            string? gear1,gear2, gear3;
            int lvlreq1, lvlreq2, lvlreq3, defense1, defense2, defense3, chosenItem, armorType;     
            switch (ArmorType)
            {
                case "cloth":
                    Console.Clear();
                    armorType = 1;
                   int choise = SelectionScreen.ShowGearSlotOption();

                    if(choise == 1)
                    {
                        gear1 = "wool hat"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "Wizard hat"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "Arch wizard"; lvlreq3 = 20; defense3 = 500;
                        
                        SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                        SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                        SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                        chosenItem = SelectionScreen.GetUserInput();
                        ItemShopsCatalogue.PlayerChoiseOfArmor(ref chosenItem, ref armor, ref gear1, ref gear2, ref gear3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref defense1, ref defense2, ref defense3);                                   
                        player.Head = armor.Name;
                                         
                    }

                    if(choise == 2)
                    {
                        gear1 = "wool shirt"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "Rune Cloth robe"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "Ultamage shirt"; lvlreq3 = 20; defense3 = 500;
                        SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                        SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                        SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                        chosenItem = SelectionScreen.GetUserInput();
                        ItemShopsCatalogue.PlayerChoiseOfArmor(ref chosenItem, ref armor, ref gear1, ref gear2, ref gear3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref defense1, ref defense2, ref defense3);
                        player.Body = armor.Name;                                                           
                    }
                    if(choise == 3)
                    {
                       
                            gear1 = "Wool pants"; lvlreq1 = 1; defense1 = 20;
                            gear2 = "Wizard robe"; lvlreq2 = 10; defense2 = 50;
                            gear3 = "Ultimate soft pants"; lvlreq3 = 20; defense3 = 500;
                            SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                            SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                            SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                            chosenItem = SelectionScreen.GetUserInput(); ;
                        ItemShopsCatalogue.PlayerChoiseOfArmor(ref chosenItem, ref armor, ref gear1, ref gear2, ref gear3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref defense1, ref defense2, ref defense3);
                        player.Legs = armor.Name;
                        
                    }
                    
                    armor.Equip(armorType);
                    player.Defense += armor.ArmorDefense;
                    return armor.Name!;
                   
                   
                case "leather":
                    Console.Clear();
                    armorType = 2;
                    choise = SelectionScreen.ShowGearSlotOption();
                    if (choise == 1)
                    {
                        gear1 = "leather Helmet"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "Thick hide helmet"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "Venomsaur helmet"; lvlreq3 = 20; defense3 = 500;
                        SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                        SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                        SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                        chosenItem = SelectionScreen.GetUserInput();
                        ItemShopsCatalogue.PlayerChoiseOfArmor(ref chosenItem, ref armor, ref gear1, ref gear2, ref gear3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref defense1, ref defense2, ref defense3);

                        player.Head = armor.Name;
                   
                    }
                    if (choise == 2)
                    {
                        gear1 = "leather shirt"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "leather winter robe"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "Ulrics shirt"; lvlreq3 = 20; defense3 = 500;
                        SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                        SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                        SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                        chosenItem = SelectionScreen.GetUserInput();
                        ItemShopsCatalogue.PlayerChoiseOfArmor(ref chosenItem, ref armor, ref gear1, ref gear2, ref gear3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref defense1, ref defense2, ref defense3);
                        player.Body = armor.Name;
                      
                    }
                    if (choise == 3)
                    {
                        gear1 = "leather pants"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "heavy hide pants"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "Anzients pants"; lvlreq3 = 20; defense3 = 500;
                        SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                        SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                        SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                        chosenItem = SelectionScreen.GetUserInput();
                        ItemShopsCatalogue.PlayerChoiseOfArmor(ref chosenItem, ref armor, ref gear1, ref gear2, ref gear3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref defense1, ref defense2, ref defense3);
                        player.Legs = armor.Name;
                    }
                    player.Defense += armor.ArmorDefense;
                    armor.Equip(armorType);
                    return armor.Name!;
                    
                case "mail":
                    Console.Clear();
                    armorType = 3;
                    choise = SelectionScreen.ShowGearSlotOption();

                    if (choise == 1)
                    {
                        gear1 = "iron helmet"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "steel cuffed helmet"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "God of war helmet"; lvlreq3 = 20; defense3 = 5000;
                        SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                        SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                        SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                        chosenItem = SelectionScreen.GetUserInput();
                        ItemShopsCatalogue.PlayerChoiseOfArmor(ref chosenItem, ref armor, ref gear1, ref gear2, ref gear3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref defense1, ref defense2, ref defense3);
                        player.Head = armor.Name;
                        
                    }
                    if (choise == 2)
                    {
                        gear1 = "iron chainmail"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "steel chainmail"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "God of war shirt"; lvlreq3 = 20; defense3 = 5000;
                        SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                        SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                        SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                        chosenItem = SelectionScreen.GetUserInput();
                        ItemShopsCatalogue.PlayerChoiseOfArmor(ref chosenItem, ref armor, ref gear1, ref gear2, ref gear3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref defense1, ref defense2, ref defense3);
                        player.Body = armor.Name;
                
                    }
                    if (choise == 3)
                    {
                        gear1 = "iron pants"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "steel pants"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "God of war pants"; lvlreq3 = 20; defense3 = 5000;
                        SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                        SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                        SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                        chosenItem = SelectionScreen.GetUserInput();
                        ItemShopsCatalogue.PlayerChoiseOfArmor(ref chosenItem, ref armor, ref gear1, ref gear2, ref gear3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref defense1, ref defense2, ref defense3);
                        player.Legs = armor.Name;
                    };
                 
                    player.Defense += armor.ArmorDefense;
                    armor.Equip(armorType);
                    return armor.Name!;
                   
                case "plate":
                    Console.Clear();
                    armorType = 4;

                    choise  = SelectionScreen.ShowGearSlotOption();

                    if (choise == 1)
                    {
                        gear1 = "Plated helmet"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "heacy plate helmet"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "Ancient plate helmet"; lvlreq3 = 20; defense3 = 5000;
                        SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                        SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                        SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                        chosenItem = SelectionScreen.GetUserInput();
                        ItemShopsCatalogue.PlayerChoiseOfArmor(ref chosenItem, ref armor, ref gear1, ref gear2, ref gear3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref defense1, ref defense2, ref defense3);
                        player.Head = armor.Name;
                    }
                    if (choise == 2)
                    {
                        gear1 = "plate armor"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "knight armor"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "Paladin armor"; lvlreq3 = 20; defense3 = 500;
                        SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                        SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                        SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                        chosenItem = SelectionScreen.GetUserInput();
                        ItemShopsCatalogue.PlayerChoiseOfArmor(ref chosenItem, ref armor, ref gear1, ref gear2, ref gear3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref defense1, ref defense2, ref defense3);
                        player.Body = armor.Name;
                
                    }
                    if (choise == 3)
                    {
                        gear1 = "Plate leggings"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "Agumus plated leggings"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "Lost gods legs"; lvlreq3 = 20; defense3 = 5000;
                        SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                        SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                        SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                        chosenItem = SelectionScreen.GetUserInput();
                        ItemShopsCatalogue.PlayerChoiseOfArmor(ref chosenItem, ref armor, ref gear1, ref gear2, ref gear3, ref lvlreq1, ref lvlreq2, ref lvlreq3, ref defense1, ref defense2, ref defense3);
                        player.Body = armor.Name;
                    }
                    armor.Equip(armorType);         
                    player.Defense = armor.ArmorDefense;
                    return armor.Name!;
              
                default:
                    return "";
                   
            }
        }
    }
}
