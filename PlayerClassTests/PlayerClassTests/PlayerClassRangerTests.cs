using diab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PlayerClassTests
{
    public class PlayerClassRangerTests
    {

            #region Creation
            [Fact]
            public void Initilize_PlayerWtithNameClassOfRANGERLevel_ShouldCreatePlayerWithTheseStats()
            {
                //Arrange
                string name = "Tom";
                int level = 1;


                HeroClass rangerClass = new RangerClass();

                //Act

                Player player = new(name, 1, rangerClass)
                {
                    Head = new(),
                    Body = new(),
                    Legs = new(),
                    Weapon = new(),
                };

                //Assert
                Assert.Equal(name, player.PlayerName);
                Assert.Equal(level, player.Level);
                Assert.Equal(rangerClass.Str, player.Str);
                Assert.Equal(rangerClass.Dex, player.Dex);
                Assert.Equal(rangerClass.Magic, player.Magic);
            
        }


        [Fact]
        public void TestDamageMethodShouldBeAtStartOneDamage()
        {
            //Arrange
            string name = "Tom";
      
            HeroClass rangerClass = new RangerClass();

            //Act
            Player player = new(name, 1, rangerClass)
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
            HeroClass playerClass = new  RangerClass();

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
            HeroClass mageClass = new RangerClass();

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
            HeroClass playerClass = new RangerClass();

            //Act
            Player player = new(name, 1, playerClass)
            {
                Head = new(),
                Body = new(),
                Legs = new(),
                Weapon = new(),
            };
            sumStr = player.Str + 1 + player.Dex +5 + player.Magic + 1;

            player.Class.LevelUp(player);
            Assert.Equal(sumStr, player.TotalStats());
    
        }
        #endregion
    }
    }

