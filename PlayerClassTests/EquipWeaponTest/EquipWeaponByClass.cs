using diab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerClassTests.EquipWeaponTest
{
    public class EquipWeaponByClass
    {

        [Fact]
        #region
        public void WarriorCannotEquipIncorrectWeapontype_ShouldThrowInvalidWeaponException()
        {
            //Arrange
            string name = "Tom";
            HeroClass heroclass = new WarriorClass();
            Weapon weapon = new() { Name = "test", damage = 1, RequiredLevel = 1, WeaponTypes = WeaponType.Staff.ToString() };
         

            //Act
            Player player = new(name, 1, heroclass)
            {
                Head = new(),
                Body = new(),
                Legs = new(),
                Weapon = new(),
            };

            Assert.Throws<InvalidWeaponException>(() => player.Weapon = weapon);

        }

        [Fact]

        public void RogueCannotEquipIncorrectWeapontype_ShouldThrowInvalidWeaponException()
        {
            //Arrange
            string name = "Tom";
            HeroClass heroclass = new RogueClass();
            Weapon weapon = new() { Name = "test", damage = 1, RequiredLevel = 1, WeaponTypes = WeaponType.Staff.ToString() };
   

            //Act
            Player player = new(name, 1, heroclass)
            {
                Head = new(),
                Body = new(),
                Legs = new(),
                Weapon = new(),
            };

            Assert.Throws<InvalidWeaponException>(() => player.Weapon = weapon);
        }

        [Fact]

        public void RangerCannotEquipIncorrectWeapontype_ShouldThrowInvalidWeaponException()
        {
            //Arrange
            string name = "Tom";
            HeroClass heroclass = new RangerClass();
            Weapon weapon = new() { Name = "test", damage = 1, RequiredLevel = 1, WeaponTypes = WeaponType.Staff.ToString() };
       

            //Act
            Player player = new(name, 1, heroclass)
            {
                Head = new(),
                Body = new(),
                Legs = new(),
                Weapon = new(),
            };

            Assert.Throws<InvalidWeaponException>(() => player.Weapon = weapon);

        }
        [Fact]

        public void MageCannotEquipIncorrectWeapontype_ShouldThrowInvalidWeaponException()
        {
            //Arrange
            string name = "Tom";
            HeroClass heroclass = new MageClass();
            Weapon weapon = new() { Name = "test", damage = 1, RequiredLevel = 1, WeaponTypes = WeaponType.Hammer.ToString() };
            //Act
            Player player = new(name, 1, heroclass)
            {
                Head = new(),
                Body = new(),
                Legs = new(),
                Weapon = new(),
            };

            Assert.Throws<InvalidWeaponException>(() => player.Weapon = weapon);

        }
        #endregion
    }
}


