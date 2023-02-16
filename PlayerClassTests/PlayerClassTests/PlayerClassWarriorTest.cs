using diab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerClassTests
{
    
    public class PlayerClassWarriorTest
    {
        #region Creation
        [Fact]
        public void Initilize_PlayerWtithNameClassOfWARRIORLevelShouldCreatePlayerWithTheseStats()
        {
            //Arrange
            string name = "Tom";
            int level = 1;
     
            HeroClass warriorClass = new WarriorClass();
            //Act
      
            Player player = new(name, 1, warriorClass)
            {
                Head = new(),
                Body = new(),
                Legs = new(),
                Weapon = new(),
            };

        
            //Assert
            Assert.Equal(name, player.PlayerName);
            Assert.Equal(level, player.Level);
            Assert.Equal(warriorClass.Str, player.Str);
            Assert.Equal(warriorClass.Dex, player.Dex);
            Assert.Equal(warriorClass.Magic, player.Magic);



        }

    
    [Fact]
    public void TestDamageMethodShouldBeAtStartOneDamage()
    {
        //Arrange
        string name = "Tom";

        HeroClass warriorClass = new WarriorClass();

        //Act
        Player player = new(name, 1, warriorClass)
        {
            Head = new(),
            Body = new(),
            Legs = new(),
            Weapon = new(),
        };


        Assert.Equal(1, player.Damage(player));
        Assert.Equal(1, player.Class.Damage(player));
        }
        [Fact]
        public void TestGetTotalAttributesFromLevelingStatsAndItemStats_ShouldSumStatsThatIsOnlyPlayerStats_GearIsEmptyNow()
        {
            string name = "Tom";
            int sum;
            HeroClass playerClass = new WarriorClass();

            //Act
            Player player = new(name, 1, playerClass)
            {
                Head = new(),
                Body = new(),
                Legs = new(),
                Weapon = new(),
            };
            sum = player.Head.TotalAttributes() + player.Body.TotalAttributes() + player.Legs.TotalAttributes() + player.TotalStats();

            Assert.Equal(sum, player.Class.TotalAttributes(player));
        }
        [Fact]
        public void TestGetSingleAttributeFromLevelingAttributeAndSingularItemAttribute_ShouldSumSelectedAttribute()
        {
            string name = "Tom";
            int sumStr;
            int sumDex;
            int sumMagic;
            HeroClass mageClass = new WarriorClass();

            //Act
            Player player = new(name, 1, mageClass)
            {
                Head = new(),
                Body = new(),
                Legs = new(),
                Weapon = new(),
            };
            sumStr = player.Str + Armor.TotalAttribute(player, 1);
            sumDex = player.Dex + Armor.TotalAttribute(player, 2);
            sumMagic = player.Magic + Armor.TotalAttribute(player, 3);

            Assert.Equal(sumStr, player.Class.TotalAttribute(player.Str, Armor.TotalAttribute(player, 1)));
            Assert.Equal(sumDex, player.Class.TotalAttribute(player.Dex, Armor.TotalAttribute(player, 2)));
            Assert.Equal(sumMagic, player.Class.TotalAttribute(player.Magic, Armor.TotalAttribute(player, 3)));
        }
        [Fact]
        public void TestLevelUpMethodShouldIncreaseLevelByOneAndStatsByClassSpecificAmount()
        {
            string name = "Tom";
            int sumStr;
            int sumDex;
            int sumMagic;
            HeroClass playerClass = new WarriorClass();

            //Act
            Player player = new(name, 1, playerClass)
            {
                Head = new(),
                Body = new(),
                Legs = new(),
                Weapon = new(),
            };
            sumStr = player.Str + 3 + player.Dex + 2 + player.Magic + 1;

            player.Class.LevelUp(player);
            Assert.Equal(sumStr, player.TotalStats());
       
        }
        #endregion


    }
}
