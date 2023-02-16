using diab;

namespace PlayerClassTests.WeaponClassTest
{
    public class DamageTest
    {
        #region
        [Fact]
        public void InitialWeaponCreationWithItsPropertiesResult_WeaponCreatedWithCorrectProps()
        {
            string name = "test";
       
            int damage = 1 * (1 + 5 / 100);

            HeroClass playerClass = new WarriorClass();
            Player player = new(name, 1, playerClass)
            {
                Head = new(),
                Body = new() { Name = "test", Str = 0, Dex = 0, Magic = 0, RequiredLevel = 1 },
                Legs = new(),
                Weapon = new() { Name = "Test", damage = 0, RequiredLevel = 1 },
                    
            };
           
            player.Body.SetArmorType("Plate"); 
           
            Assert.Equal(damage, player.Damage(player));

            damage= 2 * (1 + 5 / 100);
            player.Weapon.SetDamage(2);
            Assert.Equal(damage, player.Damage(player));
            player.Body.Str = 1;
            
            damage = 2 * (1+(5+1)/ 100);
            Assert.Equal(damage, player.Damage(player));

       

        }
     #endregion
    }
}
