using DungeonLibrary;
using System.Numerics;
using System.Threading;


namespace DungeonTests
{
    public class DungeonTests
    {
        //TODO Make test
        [Fact]
        public void Test_GetMonster()
        {
            //Arrange
            //Monster expected = new Monster();
            //Act
            Monster result = Monster.GetMonster();
            //Assert
            
            Assert.IsAssignableFrom<Monster>(result);
            
        }

        [Fact]
        public void Test_GetRandomRace()
        {
            Race result = Player.GetRandomRace();

            Assert.IsAssignableFrom<Race>(result);
        }

        [Fact]
        public void Test_GetWeapon()
        {
            Weapon result = Weapon.GetWeapon();
            
            Assert.IsAssignableFrom<Weapon>(result);
        }

        [Fact]
        public void Test_DoAttack()
        {
            Weapon sword = new Weapon(1, "Long Sword", 10, false, WeaponType.Sword, 1);
            Player player = new Player("Bob", 20, 10, 30, Race.Human, sword);
            Monster monster = new Monster("Monster", 40, 20, 10, 12, 1, "Description");

            int roll = 15;
            if (roll <= (player.CalcHitChance() - monster.CalcBlock()))
            {                 //30                     //10
                
                int damageDealt = player.CalcDamage();//2

                
                monster.Life -= damageDealt;//38
                
                Console.WriteLine($"{player.Name} hit {monster.Name} for {damageDealt} damage!");

                int expected = 38;
                int actual = monster.Life -= damageDealt;


                Assert.Equal(expected, actual);
            }
           
            
        }


    
        [Fact]
        public void Test_DoBattle()
        {
            Weapon sword = new Weapon(8, "Long Sword", 10, false, WeaponType.Sword, 1);
            Player player = new Player("Bob", 20, 10, 30, Race.Human, sword);
            Monster monster = new Monster("Monster", 40, 20, 10, 12, 1, "Description");
          
            Combat.DoAttack(player, monster);
          
            if (monster.Life > 0)
            {
                Combat.DoAttack(monster, player);
       
       
            }
            Combat expected = new Combat();

            Assert.NotNull(expected);
       
       
        }
        [Fact]
        public void Test_CalcHitChance()
        {
            Weapon sword = new Weapon(8, "Long Sword", 10, false, WeaponType.Sword, 1);
            Player player = new Player("Bob", 20, 10, 30, Race.Human, sword);
            //int hitChance = 20;
            //int bonusHitChance = 10;

            int expected = 30;

            int actual = player.CalcHitChance();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test_CalcBlock()
        {
            Weapon sword = new Weapon(8, "Long Sword", 10, false, WeaponType.Sword, 1);
            Player player = new Player("Bob", 20, 10, 30, Race.Human, sword);
            int expected = 10;
            int actual = player.CalcBlock();

            Assert.Equal(expected, actual);
        }
    }
}