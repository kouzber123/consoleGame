using diab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerClassTests.ArmorTest
{
    public class InvalidArmorRogueTest
    {
        [Fact]
        #region
        public void RogueClassCannotWearCloth_OR_Plate_ResultIsNULL_AndForLeatherAndMail_NotNULL()
        {
            //Arrange
            string name = "Tom";
            int level = 1;
            int str = 1;
            int dex = 7;
            int magic = 1;
            HeroClass playerClass = new RogueClass();
            Armor plate = new() { Name = "test", Dex = 4, Magic = 0, Str = 10, RequiredLevel = 1 };
            plate.SetArmorType("Plate");

            Armor mail = new() { Name = "test", Dex = 4, Magic = 0, Str = 10, RequiredLevel = 1 };
            mail.SetArmorType("Mail");

            Armor leather = new() { Name = "test", Dex = 4, Magic = 0, Str = 10, RequiredLevel = 1 };
            leather.SetArmorType("Leather");

            Armor cloth = new() { Name = "test", Dex = 4, Magic = 0, Str = 10, RequiredLevel = 1 };
            cloth.SetArmorType("Cloth");
            //Act
            Player player = new(name, 1, playerClass)
            {
                Head = new(),
                Body = new(),
                Legs = new(),
                Weapon = new(),
            };

            Assert.False(player.Class.GearRestrictions(plate.ArmorType));
            Assert.True(player.Class.GearRestrictions(mail.ArmorType));
            Assert.True(player.Class.GearRestrictions(leather.ArmorType));
            Assert.False(player.Class.GearRestrictions(cloth.ArmorType));

            Assert.False(player.CheckItemType(plate.ArmorType));
            Assert.True(player.CheckItemType(mail.ArmorType));
            Assert.True(player.CheckItemType(leather.ArmorType));
            Assert.False(player.CheckItemType(cloth.ArmorType));
        }


        [Fact]

        public void RogueClassCannotWearPlate_Cloth_ThrowException()
        {
            //Arrange
            string name = "Tom";
            HeroClass rogueClass = new RogueClass();
            Armor plate = new() { Name = "test", Dex = 4, Magic = 0, Str = 10, RequiredLevel = 1 };
            plate.SetArmorType("Plate");

            //Act
            Player player = new(name, 1, rogueClass)
            {
                Head = new(),
                Body = new(),
                Legs = new(),
                Weapon = new(),
            };

            Assert.Throws<InvalidArmorException>(() => player.Legs = plate);



        }
        #endregion
    }
}
