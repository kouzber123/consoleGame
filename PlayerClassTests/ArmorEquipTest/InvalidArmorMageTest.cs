using diab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PlayerClassTests.ArmorTest
{
    public class InvalidArmorMageTest
    {
        [Fact]
        #region
        public void MageClassCannotWearPlate_MailORLeatherResultIsNULL_AndClothNotNULL()
        {
            //Arrange
            string name = "Tom";
            HeroClass mageClass = new MageClass();
            Armor plate = new() {Name = "test", Dex=4, Magic=0, Str=10, RequiredLevel=1, ArmorType = Armor.Armors.Plate.ToString() };
            Armor mail = new() { Name = "test", Dex = 4, Magic = 0, Str = 10, RequiredLevel = 1 , ArmorType = Armor.Armors.Mail.ToString() };      
            Armor leather = new() { Name = "test", Dex = 4, Magic = 0, Str = 10, RequiredLevel = 1, ArmorType = Armor.Armors.Leather.ToString() };        
            Armor cloth = new() { Name = "test", Dex = 4, Magic = 0, Str = 10, RequiredLevel = 1, ArmorType = Armor.Armors.Cloth.ToString() };         
            //Act
            Player player = new(name, 1, mageClass)
            {
                Head = new(),
                Body = new(),
                Legs = new(),
                Weapon = new(),
            };

            Assert.False(player.Class.GearRestrictions(plate.ArmorType));
            Assert.False(player.Class.GearRestrictions(mail.ArmorType));
            Assert.False(player.Class.GearRestrictions(leather.ArmorType));
            Assert.True(player.Class.GearRestrictions(cloth.ArmorType));

            Assert.False(player.CheckItemType(plate.ArmorType));
            Assert.False(player.CheckItemType(mail.ArmorType));
            Assert.False(player.CheckItemType(leather.ArmorType));
            Assert.True(player.CheckItemType(cloth.ArmorType));
        }
        [Fact]
     
        public void MageClassCannotWearPlate_MailORLeatherResult_ThrowException()
        {
            //Arrange
            string name = "Tom";
            HeroClass mageClass = new MageClass();
            Armor plate = new() { Name = "test", Dex = 4, Magic = 0, Str = 10, RequiredLevel = 1, ArmorType = Armor.Armors.Plate.ToString() };
            //Act
            Player player = new(name, 1, mageClass)
            {
                Head = new(),
                Body = new(),
                Legs = new(),
                Weapon = new(),
            };

            Assert.Throws<InvalidArmorException>( () => player.Body = plate);
          


        }
    }
    #endregion

}


