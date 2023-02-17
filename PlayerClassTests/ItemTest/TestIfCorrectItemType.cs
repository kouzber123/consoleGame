using diab;

namespace PlayerClassTests
{
    public class TestIfCorrectItemType
    {
        #region
        [Fact]
        public void TestIsGivenItemTypeCorrectForThePlayerClassMage_ShouldAcceptBothArmorAndWeaponClassesAndReturnTrueOrFalse()
        {
            string name = "Tom";
            HeroClass playerClass = new MageClass();

            //Act
            Player player = new(name, 1, playerClass);
 
            Weapon weaponStaffTest = new() { damage = 100, RequiredLevel = 1, WeaponTypes=WeaponType.Staff.ToString()};
            Weapon weaponSwordTest = new() { damage = 100, RequiredLevel = 1, WeaponTypes = WeaponType.Sword.ToString() };
            Armor armor = new() { RequiredLevel = 1, ArmorType =Armor.Armors.Cloth.ToString()};
    
           bool result = player.Class.GearRestrictions(armor.ArmorType);
           Assert.True(result);

           result = player.Class.GearRestrictions(weaponStaffTest.WeaponTypes);
           Assert.True(result);

           result = player.Class.GearRestrictions(weaponSwordTest.WeaponTypes);
           Assert.False(result);

        }

        [Fact]
        public void TestIsGivenItemTypeCorrectForThePlayerClassWarrior_ShouldAcceptBothArmorAndWeaponClassesAndReturnTrueOrFalse()
        {
            string name = "Tom";
            HeroClass playerClass = new WarriorClass();

            //Act
            Player player = new(name, 1, playerClass);

            Weapon weaponStaffTest = new() { damage = 100, RequiredLevel = 1, WeaponTypes = WeaponType.Staff.ToString() };
            Weapon weaponSwordTest = new() { damage = 100, RequiredLevel = 1, WeaponTypes = WeaponType.Sword.ToString() };
            Armor armor = new() { RequiredLevel = 1, ArmorType = Armor.Armors.Cloth.ToString() };

            bool result = player.Class.GearRestrictions(armor.ArmorType);
            Assert.False(result);

            result = player.Class.GearRestrictions(weaponStaffTest.WeaponTypes);
            Assert.False(result);

            result = player.Class.GearRestrictions(weaponSwordTest.WeaponTypes);
            Assert.True(result);

        }
        [Fact]
        public void TestIsGivenItemTypeCorrectForThePlayerClassRogue_ShouldAcceptBothArmorAndWeaponClassesAndReturnTrueOrFalse()
        {
            string name = "Tom";
            HeroClass playerClass = new RogueClass();

            //Act
            Player player = new(name, 1, playerClass);
      

            Weapon weaponStaffTest = new() { damage = 100, RequiredLevel = 1, WeaponTypes = WeaponType.Staff.ToString() };
            Weapon weaponDaggerTest = new() { damage = 100, RequiredLevel = 1, WeaponTypes = WeaponType.Dagger.ToString() };
            Armor armor = new() { RequiredLevel = 1, ArmorType = Armor.Armors.Cloth.ToString() };

            bool result = player.Class.GearRestrictions(armor.ArmorType);
            Assert.False(result);

            result = player.Class.GearRestrictions(weaponStaffTest.WeaponTypes);
            Assert.False(result);

            result = player.Class.GearRestrictions(weaponDaggerTest.WeaponTypes);
            Assert.True(result);

        }
        [Fact]
        public void TestIsGivenItemTypeCorrectForThePlayerClassRanger_ShouldAcceptBothArmorAndWeaponClassesAndReturnTrueOrFalse()
        {
            string name = "Tom";
            HeroClass playerClass = new RangerClass();

            //Act
            Player player = new(name, 1, playerClass);


            Weapon weaponStaffTest = new() { damage = 100, RequiredLevel = 1, WeaponTypes = WeaponType.Staff.ToString() };
            Weapon weaponBowTest = new() { damage = 100, RequiredLevel = 1, WeaponTypes = WeaponType.Bow.ToString() };
            Armor armor = new() { RequiredLevel = 1, ArmorType = Armor.Armors.Mail.ToString() };

            bool result = player.Class.GearRestrictions(armor.ArmorType);
            Assert.True(result);

            result = player.Class.GearRestrictions(weaponStaffTest.WeaponTypes);
            Assert.False(result);

            result = player.Class.GearRestrictions(weaponBowTest.WeaponTypes);
            Assert.True(result);

        }
        [Fact]
        public void TestIfSelectedItemSlotMethodReturnCorrectSlotValueAsString()
        {
            int slotPosition = 1;
            string positionIsWeapon = "Weapon";

            string returnedPosition = Item.SelectedPlayerGear(slotPosition);
            Assert.Equal(positionIsWeapon, returnedPosition);

        }
        #endregion
    }
}
