using diab;

namespace PlayerClassTests
{

    public class PlayerClassTests
    {

        #region
        [Fact]
        public void TestLevelUpMethodShouldIncreaseLevelByOneAndStatsByClassSpecificAmount()
        {
            string name = "Tom";
            int sum;
            HeroClass playerClass = new MageClass();

            //Act
            Player player = new(name, 1, playerClass)
            {
                Head = new(),
                Body = new(),
                Legs = new(),
                Weapon = new(),
            };
            sum = player.Str + 1 + player.Dex + 1 + player.Magic + 5;

            player.LevelUp(player);
            Assert.Equal(sum, player.TotalStats());
      

        }
        [Fact]
        public void TestPlayerClassEnumSelectorShouldResultRString()
        {
            string name = "Tom";
            string selectedPlayerClass = PlayerClasses.PlayerClass(1);
            int sum;

            HeroClass playerClass = new MageClass();

            //Act
            Player player = new(name, 1, playerClass)
            {
                Head = new(),
                Body = new(),
                Legs = new(),
                Weapon = new(),
            };      
          
            Assert.Equal(selectedPlayerClass, player.Class.ClassName);
        }


        [Fact]
        public void TestPlayerCanPlayerEquipSelectedArmorShouldLevelBeEnoughResultIsNullBecauseArmorLevelIsHigher()
        {
            string name = "Tom";
            HeroClass playerClass = new MageClass();

            //Act
            Player player = new(name, 4, playerClass)
            {
                Head = new(),
                Body = new(),
                Legs = new(),
                Weapon = new(),
            };

            Armor armor= new() { Name = "test", RequiredLevel = 5};
            SetArmor.EquipGear(1, player, armor);
            Assert.Null(SetArmor.EquipGear(1, player, armor));       
        }
    }
    #endregion
}
