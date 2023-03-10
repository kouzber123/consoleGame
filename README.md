# consoleGame
NOROFOFF BACKEND ASSIGNMENT

Goal: 
1) create diablo3 like console game. 
2) Game contains 4 classes (MAGE, WARRIOR, ROGUE and RANGER)
3) All classes are unique they have seperate attributes (str, dex, magic) and depending on classtype limits your weareable items
4) Player who can then become a selected hero type and player can use equip items and level up and level up increases statpoints depending on classtype
5) Display player overall status in a game like situation and also display damage

# Technologies
C# and xUnit framework

# Exceptions and testing
Exceptions -
Are thrown when play decides to choose invalid item type for its current heroclass
1) invalidArmorException
2) invalidWeaponException

Testing - 
Tests have been conducted with xUnit Framework for the most important classes and method totaling 43ish. 
E.g. Player -and Hero weapon .and armor classes but overall all classes were tested that had a fatal part in the game.
All tests were successful.

# Items
Armor
Hero can wear/fill 3 armor slot which are: 1) Head, 2) Body, and 3) Legs. 
ArmorTypes are 1) Plate. 2) Mail. 3) Leather. and 4) Cloth
Armors have level requirements and classtype requirements which player class has to fulfill order to use

Weapon
There are only equip one weapon at the time, weapons arent save. 
Weapontypes are: 1) axe, 2) sword, 3) hammer, 4) dagger, 5) bow, 6) staff and 7) wand.
Weapons have level requirements and classtype requirements which player class has to fulfill order to use

# Hero/player Corner
Hero's attributes
Classes/hero contains following attributes strength, dexterity, and magic attributes.
Player can manipulate these values by wearing an armor or by leveling up.

HeroClass e.g. warrior class, mageclass...
Has following properties: Heroclass name, , valid weapon and armor types.

Damage method is created with the following formula
Hero damage = WeaponDamage * (1 + DamagingAttribute/100). weapons increase damage and level ups increase % of the damage

As mentioned each class starts with unique allocated stats and allowed equipments.

All following classes starts with level one
Str = Strength, Dex = Dexterity 
1) Mage
Str 1, Dex 1, Magic 8.
Level up increases total stats by: Str +1, Dex +1, Magic +5.
Mage can only equip following items Staff, Wand and Cloth
Mage damage is based by total magic,

2) Ranger
Strength 1, Dexterity 7, Magic 1
Level up increases total stats by: Str +1, Dex +5, Magic +1
Ranger can only equip following items Bow, Mail and Leather
Ranger damage is based by total Dex

3) Rogue
Str 2, Dex 6, Magic 1
Every time a Rogue levels up, they gain:
Level up increases total stats by: Str +1, Dex +4, Magic +1
Rogue can only equip following items Dagger, Swords, Mail and Leather
Rogue Weapons - Daggers, Swords
Rogue damage is based by total Dex

4) Warrior
Str 5, Dex 2, Magic 1
Level up increases total stats by: Strength +3, Dexterity +2, Magic +1
Warrior can only equip following items Hammer, Sword, Axe, Mail and Plate
Warrior damage is based by total strength

# Other features
Console Game contains a controller that user can use to navigate 6 different actions such as level up, choose to equip items they want and see their attributes and inventory.
