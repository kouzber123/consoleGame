using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diab
{
    internal class PlayerItemList
    {
        public static void DisplayWeaponList(string weaponType, Weapon weapon, Hero player)
        {
            switch (weaponType)
            {
                case "Sword":
                    SelectionScreen.ShowShopItems("Wooden Sword", 1, 20);
                    SelectionScreen.ShowShopItems("Steel Sword", 10, 50);
                    SelectionScreen.ShowShopItems("Adamite Sword", 20, 500);
                    Console.WriteLine("Choose weapon 1-3");
                    int chosenItem = Int32.Parse(Console.ReadLine()!);
                    if (chosenItem == 1)
                    {
                        PlayerSelectedGear.SetWeapon(weapon, "Wooden Sword", 1, 20);
                    }
                    if (chosenItem == 2)
                    {
                        PlayerSelectedGear.SetWeapon(weapon, "Steel Sword", 1, 20);
                    }
                    if (chosenItem == 3)
                    {
                        PlayerSelectedGear.SetWeapon(weapon, "Adamite sword", 1, 20);
                    }
                    weapon.EquipWeapon(6);
                    player.Weapon = weapon.Name;
                    player.Damage = weapon.WeaponDamage;
                    break;
                case "Axe":
                    SelectionScreen.ShowShopItems("Wooden Axe", 1, 20);
                    SelectionScreen.ShowShopItems("Steel Axe", 10, 50);
                    SelectionScreen.ShowShopItems("Adamite Axe", 20, 500);
                    Console.WriteLine("Choose weapon 1-3");
                    chosenItem = Int32.Parse(Console.ReadLine()!);
                    if (chosenItem == 1)
                    {
                        PlayerSelectedGear.SetWeapon(weapon, "Wooden Axe", 1, 20);
                    }
                    if (chosenItem == 2)
                    {
                        PlayerSelectedGear.SetWeapon(weapon, "Steel Axe", 10, 50);
                    }
                    if (chosenItem == 3)
                    {

                        PlayerSelectedGear.SetWeapon(weapon, "Adamite Axe", 20, 500);
                    }
                    weapon.EquipWeapon(1);
                    player.Weapon = weapon.Name;
                    player.Damage = weapon.WeaponDamage;
                    break;
                case "Hammer":
                    SelectionScreen.ShowShopItems("Wooden Hammer", 1, 20);
                    SelectionScreen.ShowShopItems("Steel Hammer", 10, 50);
                    SelectionScreen.ShowShopItems("Adamite Hammer", 20, 500);
                    Console.WriteLine("Choose weapon 1-3");
                    chosenItem = Int32.Parse(Console.ReadLine()!);
                    if (chosenItem == 1)
                    {
                        PlayerSelectedGear.SetWeapon(weapon, "Wooden hammer", 1, 10);
                    }
                    if (chosenItem == 2)
                    {
                        PlayerSelectedGear.SetWeapon(weapon, "hammer", 10, 50);
                    }
                    if (chosenItem == 3)
                    {
                        PlayerSelectedGear.SetWeapon(weapon, "Giga hammer", 20, 500);
                    }
                    weapon.EquipWeapon(4);
                    player.Weapon = weapon.Name;
                    player.Damage = weapon.WeaponDamage;

                    break;
                case "Dagger":
                    SelectionScreen.ShowShopItems("Shiv", 1, 20);
                    SelectionScreen.ShowShopItems("Steel Dagger", 10, 50);
                    SelectionScreen.ShowShopItems("Adamite dagger", 20, 500);
                    Console.WriteLine("Choose weapon 1-3");
                    chosenItem = Int32.Parse(Console.ReadLine()!);
                    if (chosenItem == 1)
                    {
                        PlayerSelectedGear.SetWeapon(weapon, "Shiv", 1, 20);
                    }
                    if (chosenItem == 2)
                    {
                        PlayerSelectedGear.SetWeapon(weapon, "Steel Dagger", 10, 50);
                    }
                    if (chosenItem == 3)
                    {

                        PlayerSelectedGear.SetWeapon(weapon, "Adamite dagger", 20, 500);
                    }
                    weapon.EquipWeapon(3);
                    player.Weapon = weapon.Name;
                    player.Damage = weapon.WeaponDamage;

                    break;
                case "Staff":
                    SelectionScreen.ShowShopItems("Wooden Staff", 1, 20);
                    SelectionScreen.ShowShopItems("Steel  staff", 10, 50);
                    SelectionScreen.ShowShopItems("Halberdier", 20, 500);
                    Console.WriteLine("Choose weapon 1-3");
                    chosenItem = Int32.Parse(Console.ReadLine()!);
                    if (chosenItem == 1)
                    {
                        PlayerSelectedGear.SetWeapon(weapon, "wooden staff", 1, 20);
                    }
                    if (chosenItem == 2)
                    {
                        PlayerSelectedGear.SetWeapon(weapon, "Steel staff", 10, 50);
                    }
                    if (chosenItem == 3)
                    {
                        PlayerSelectedGear.SetWeapon(weapon, "wooden staff", 20, 500);
                    }
                    weapon.EquipWeapon(5);
                    player.Weapon = weapon.Name;
                    player.Damage = weapon.WeaponDamage;

                    break;
                case "Bow":
                    SelectionScreen.ShowShopItems("Wooden Bow", 1, 20);
                    SelectionScreen.ShowShopItems("Long Bow", 10, 50);
                    SelectionScreen.ShowShopItems("Composite Bow", 20, 500);
                    Console.WriteLine("Choose weapon 1-3");
                    chosenItem = Int32.Parse(Console.ReadLine()!);

                    if (chosenItem == 1)
                    {
                        PlayerSelectedGear.SetWeapon(weapon, "wooden bow", 1, 20);
                    }
                    if (chosenItem == 2)
                    {
                        PlayerSelectedGear.SetWeapon(weapon, "Long bow", 10, 50);
                    }
                    if (chosenItem == 3)
                    {

                        PlayerSelectedGear.SetWeapon(weapon, "Composite bow", 20, 500);
                    }
                    weapon.EquipWeapon(2);
                    player.Weapon = weapon.Name;
                    player.Damage = weapon.WeaponDamage;
                    break;
                case "Wand":
                    SelectionScreen.ShowShopItems("Broken wand", 1, 20);
                    SelectionScreen.ShowShopItems("Old mans wand", 10, 50);
                    SelectionScreen.ShowShopItems("Liqurice", 20, 500);
                    Console.WriteLine("Choose weapon 1-3");
                    chosenItem = Int32.Parse(Console.ReadLine()!);
                    if (chosenItem == 1)
                    {
                        PlayerSelectedGear.SetWeapon(weapon, "Broken wand", 1, 20);
                    }
                    if (chosenItem == 2)
                    {
                        PlayerSelectedGear.SetWeapon(weapon, "Old mans wand", 10, 50);
                    }
                    if (chosenItem == 3)
                    {

                        PlayerSelectedGear.SetWeapon(weapon, "Liqurice", 20, 500);
                    }
                    weapon.EquipWeapon(7);
                    player.Weapon = weapon.Name;
                    player.Damage = weapon.WeaponDamage;

                    break;

                default:
                    break;
            }
        } 
        public static string DisplayArmorList(string ArmorType, Armor armor, Hero player)
        {
            string? gear1,gear2, gear3, choise;
            int lvlreq1, lvlreq2, lvlreq3, defense1, defense2, defense3, chosenItem, armorType;

            switch (ArmorType)
            {
                case "cloth":
                    armorType = 1;
                    Console.WriteLine("What type of defense are you looking for?");
                    Console.WriteLine("(1) head protection?");
                    Console.WriteLine("(2) body protection?");
                    Console.WriteLine("(3) leg protection?");
                    choise =  Console.ReadLine();

                    if(choise == "1")
                    {
                        gear1 = "wool shirt"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "Rune Cloth robe"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "Ultamage shirt"; lvlreq3 = 20; defense3 = 500;
                        
                        SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                        SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                        SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                        Console.WriteLine("Choose Armor 1-3");
                        chosenItem = Int32.Parse(Console.ReadLine()!);
                        if (chosenItem == 1)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear1, lvlreq1, defense1);
                        }
                        if (chosenItem == 2)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear2, lvlreq2, defense2);
                        }
                        if (chosenItem == 3)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear3, lvlreq3, defense3);
                        }
                    
                        player.Head = armor.Name;
                                         
                    }

                    if(choise == "2")
                    {
                        gear1 = "wool shirt"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "Rune Cloth robe"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "Ultamage shirt"; lvlreq3 = 20; defense3 = 500;
                        SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                        SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                        SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                        Console.WriteLine("Choose Armor 1-3");
                        chosenItem = Int32.Parse(Console.ReadLine()!);
                        if (chosenItem == 1)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear1, lvlreq1, defense1);
                        }
                        if (chosenItem == 2)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear2, lvlreq2, defense2);
                        }
                        if (chosenItem == 3)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear3, lvlreq3, defense3);
                        }
                      
                        player.Body = armor.Name;
                       
                                       
                    }
                    if(choise == "3")
                    {
                       
                            gear1 = "wool shirt"; lvlreq1 = 1; defense1 = 20;
                            gear2 = "Rune Cloth robe"; lvlreq2 = 10; defense2 = 50;
                            gear3 = "Ultamage shirt"; lvlreq3 = 20; defense3 = 500;
                            SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                            SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                            SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                            Console.WriteLine("Choose Armor 1-3");
                            chosenItem = Int32.Parse(Console.ReadLine()!);
                            if (chosenItem == 1)
                            {
                                PlayerSelectedGear.SetArmor(armor, gear1, lvlreq1, defense1);
                            }
                            if (chosenItem == 2)
                            {
                                PlayerSelectedGear.SetArmor(armor, gear2, lvlreq2, defense2);
                            }
                            if (chosenItem == 3)
                            {
                                PlayerSelectedGear.SetArmor(armor, gear3, lvlreq3, defense3);
                            }
                        
                            player.Legs = armor.Name;
                        
                    }
                    
                    armor.Equip(armorType);
                    player.Defense += armor.ArmorDefense;
                    return armor.Name;
                    break;
                   
                case "leather":
                    armorType = 2;
                    Console.WriteLine("What type of defense are you looking for?");
                    Console.WriteLine("(1) head protection?");
                    Console.WriteLine("(2) body protection?");
                    Console.WriteLine("(3) leg protection?");
                    choise = Console.ReadLine();

                    if (choise == "1")
                    {
                        gear1 = "leather shirt"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "leather winter robe"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "Ulrics shirt"; lvlreq3 = 20; defense3 = 500;
                        SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                        SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                        SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                        Console.WriteLine("Choose Armor 1-3");
                        chosenItem = Int32.Parse(Console.ReadLine()!);
                        if (chosenItem == 1)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear1, lvlreq1, defense1);
                        }
                        if (chosenItem == 2)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear2, lvlreq2, defense2);
                        }
                        if (chosenItem == 3)
                        {

                            PlayerSelectedGear.SetArmor(armor, gear3, lvlreq3, defense3);
                        }
                        
                        player.Head = armor.Name;
                   
                    }
                    if (choise == "2")
                    {
                        gear1 = "leather shirt"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "leather winter robe"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "Ulrics shirt"; lvlreq3 = 20; defense3 = 500;
                        SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                        SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                        SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                        Console.WriteLine("Choose Armor 1-3");

                        chosenItem = Int32.Parse(Console.ReadLine()!);
                        if (chosenItem == 1)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear1, lvlreq1, defense1);
                        }
                        if (chosenItem == 2)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear2, lvlreq2, defense2);
                        }
                        if (chosenItem == 3)
                        {

                            PlayerSelectedGear.SetArmor(armor, gear3, lvlreq3, defense3);
                        }
                        player.Body = armor.Name;
                      
                   

                    }
                    if (choise == "3")
                    {
                        gear1 = "leather shirt"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "leather winter robe"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "Ulrics shirt"; lvlreq3 = 20; defense3 = 500;
                        SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                        SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                        SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                        Console.WriteLine("Choose Armor 1-3");

                        chosenItem = Int32.Parse(Console.ReadLine()!);
                        if (chosenItem == 1)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear1, lvlreq1, defense1);
                        }
                        if (chosenItem == 2)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear2, lvlreq2, defense2);
                        }
                        if (chosenItem == 3)
                        {

                            PlayerSelectedGear.SetArmor(armor, gear3, lvlreq3, defense3);
                        }
                        player.Legs = armor.Name;
                    }
                    player.Defense += armor.ArmorDefense;
                    armor.Equip(armorType);
                    return armor.Name;
                    break;
                case "mail":
                    armorType = 3;
                    Console.WriteLine("What type of defense are you looking for?");
                    Console.WriteLine("(1) head protection?");
                    Console.WriteLine("(2) body protection?");
                    Console.WriteLine("(3) leg protection?");
                    choise = Console.ReadLine();

                    if (choise == "1")
                    {
                        gear1 = "iron chainmail"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "steel chainmail"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "God of war shirt"; lvlreq3 = 20; defense3 = 5000;
                        SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                        SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                        SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                        Console.WriteLine("Choose Armor 1-3");
                        chosenItem = Int32.Parse(Console.ReadLine()!);
                        if (chosenItem == 1)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear1, lvlreq1, defense1);
                        }
                        if (chosenItem == 2)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear2, lvlreq2, defense2);
                        }
                        if (chosenItem == 3)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear3, lvlreq3, defense3);
                        }
                        
                        player.Head = armor.Name;
                        
                    }
                    if (choise == "2")
                    {
                        gear1 = "iron chainmail"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "steel chainmail"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "God of war shirt"; lvlreq3 = 20; defense3 = 5000;
                        SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                        SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                        SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                        Console.WriteLine("Choose Armor 1-3");
                        chosenItem = Int32.Parse(Console.ReadLine()!);
                        if (chosenItem == 1)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear1, lvlreq1, defense1);
                        }
                        if (chosenItem == 2)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear2, lvlreq2, defense2);
                        }
                        if (chosenItem == 3)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear3, lvlreq3, defense3);
                        }
                        player.Body = armor.Name;
                
                    }
                    if (choise == "3")
                    {
                        gear1 = "iron chainmail"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "steel chainmail"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "God of war shirt"; lvlreq3 = 20; defense3 = 5000;
                        SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                        SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                        SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                        Console.WriteLine("Choose Armor 1-3");
                        chosenItem = Int32.Parse(Console.ReadLine()!);
                        if (chosenItem == 1)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear1, lvlreq1, defense1);
                        }
                        if (chosenItem == 2)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear2, lvlreq2, defense2);
                        }
                        if (chosenItem == 3)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear3, lvlreq3, defense3);
                        }
                        player.Legs = armor.Name;
                    };
                 
                    player.Defense += armor.ArmorDefense;
                    armor.Equip(armorType);
                    return armor.Name;
                    break;
                case "plate":
                    armorType = 4;
                    Console.WriteLine("What type of defense are you looking for?");
                    Console.WriteLine("(1) head protection?");
                    Console.WriteLine("(2) body protection?");
                    Console.WriteLine("(3) leg protection?");
                    choise = Console.ReadLine();

                    if (choise == "1")
                    {
                        gear1 = "iron chainmail"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "steel chainmail"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "God of war shirt"; lvlreq3 = 20; defense3 = 5000;
                        SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                        SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                        SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                        Console.WriteLine("Choose Armor 1-3");
                        chosenItem = Int32.Parse(Console.ReadLine()!);
                        if (chosenItem == 1)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear1, lvlreq1, defense1);
                        }
                        if (chosenItem == 2)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear2, lvlreq2, defense2);
                        }
                        if (chosenItem == 3)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear3, lvlreq3, defense3);
                        }
                        player.Head = armor.Name;
                    }
                    if (choise == "2")
                    {
                        gear1 = "plate armor"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "knight armor"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "Paladin armor"; lvlreq3 = 20; defense3 = 500;
                        SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                        SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                        SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                        Console.WriteLine("Choose Armor 1-3");
                        chosenItem = Int32.Parse(Console.ReadLine()!);
                        if (chosenItem == 1)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear1, lvlreq1, defense1);
                        }
                        if (chosenItem == 2)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear2, lvlreq2, defense2);
                        }
                        if (chosenItem == 3)
                        {

                            PlayerSelectedGear.SetArmor(armor, gear3, lvlreq3, defense3);
                        }
                        player.Body = armor.Name;
                
                    }
                    if (choise == "3")
                    {
                        gear1 = "iron chainmail"; lvlreq1 = 1; defense1 = 20;
                        gear2 = "steel chainmail"; lvlreq2 = 10; defense2 = 50;
                        gear3 = "God of war shirt"; lvlreq3 = 20; defense3 = 5000;
                        SelectionScreen.ShowShopItems(gear1, lvlreq1, defense1);
                        SelectionScreen.ShowShopItems(gear2, lvlreq2, defense2);
                        SelectionScreen.ShowShopItems(gear3, lvlreq3, defense3);
                        Console.WriteLine("Choose Armor 1-3");
                        chosenItem = Int32.Parse(Console.ReadLine()!);
                        if (chosenItem == 1)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear1, lvlreq1, defense1);
                        }
                        if (chosenItem == 2)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear2, lvlreq2, defense2);
                        }
                        if (chosenItem == 3)
                        {
                            PlayerSelectedGear.SetArmor(armor, gear3, lvlreq3, defense3);
                        }
                        player.Body = armor.Name;
                    }
                    armor.Equip(armorType);         
                    player.Defense = armor.ArmorDefense;
                    return armor.Name;

                    break;
              
                default:
                    return "";
                    break;
            }
        }
    }
}
