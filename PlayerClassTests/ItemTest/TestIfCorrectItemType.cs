using diab;

namespace PlayerClassTests
{
    public class TestIfCorrectItemType
    {
        #region
        [Fact]
        public void TestIsGivenItemTypeCorrectForThePlayerClassShouldAcceptBothArmorAndWeaponClassesAndReturnEmptyStringOrNotNULL()
        {
            string name = "Tom";
            string currentlyEquppedItem;
            int itemType = 1; 
            HeroClass playerClass = new MageClass();

            //Act
            Player player = new(name, 1, playerClass)
            {
                Head = new(),
                Body = new(),
                Legs = new(),
                Weapon = new(),
            };

 
            Weapon weaponStaffTest = new() { damage = 100, RequiredLevel = 1};
            weaponStaffTest.SetWeaponType("Staff");

            Weapon weaponSwordTest = new() { damage = 100, RequiredLevel = 1 };
            weaponSwordTest.SetWeaponType("Staff");

           Armor armor = new Armor() { RequiredLevel = 1};
           armor.SetArmorType("Cloth");
           string result = CheckItemType.IsCorrectGearType(itemType, new OptionalClassParams { Class1 = weaponStaffTest!, Class2 = null } , player);
           Assert.NotNull(result);

           result = CheckItemType.IsCorrectGearType(itemType, new OptionalClassParams { Class1 = weaponSwordTest!, Class2 = null }, player);
           Assert.Equal("",result);

           result = CheckItemType.IsCorrectGearType(itemType, new OptionalClassParams { Class1 = null!, Class2 = armor }, player);
           Assert.NotNull(result);

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
