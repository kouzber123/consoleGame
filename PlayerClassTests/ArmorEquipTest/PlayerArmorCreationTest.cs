using diab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerClassTests.ArmorTest
{
    public class PlayerArmorCreationTest
    {
        #region Creation
        [Fact]
        public void Initial_CreatePlayerArmorWithAttributes_Name_LevelRequirementShouldArmorWithThese()
        {
            //Arrange
            string name = "Steel my chastity leggings";
            string armorType = "Plate";
            int requiredLevel = 1;
            int str = 10;
            int dex = 15;
            int magic = 20;
            //ACT
            Armor armor= new() { Name = name, RequiredLevel = requiredLevel, Str = str, Dex = dex, Magic = magic, ArmorType = armorType};         

            //Assert
            Assert.Equal(name, armor.Name);
            Assert.Equal(armor.RequiredLevel, requiredLevel);
            Assert.Equal(armorType, armor.ArmorType);
            Assert.Equal(magic, armor.Magic);
            Assert.Equal(str, armor.Str);
            Assert.Equal(dex, armor.Dex);
        }

    }
    #endregion
}
