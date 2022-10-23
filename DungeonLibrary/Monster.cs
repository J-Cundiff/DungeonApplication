using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
       
        int _minDamage;

        //PROPERTIES --- people
        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if(value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;

                }
                else
                {
                    _minDamage = 1;
                }
            }
        }

        //CONSTRUCTORS --- collect
        public Monster()
        {

        }

        public Monster(string name, int maxLife,  int hitChance, int block, int maxDamage, int minDamage, string description) 
            : base(name, maxLife, hitChance, block)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }
        //METHODS --- monkeys
        public override string ToString()
        {
            return $"--------{Name}---------\n" +
                $"Life: {Life} of {MaxLife}\n" +
                $"Damage: {MinDamage} to {MaxDamage}\n" +
                $"Block: {Block}\n" +
                $"Hit Chance: {CalcHitChance()}%\n" +
                $"{Description}";
        }
        public override int CalcDamage()
        {
            
            Random random = new Random();
            
            return random.Next(MinDamage, MaxDamage + 1);
            //return a random number between monster min and maxDamage.
        }
        public static Monster GetMonster()
        {
            Rabbit rabbit = new Rabbit(name: "White Rabbit", maxLife: 25, hitChance: 50, block: 20, maxDamage: 8, minDamage: 2, description: "Thats not ordinary rabbit! Look at the bones!", isFluffy: true );
            
            Vampire vampire = new Vampire("Dracula", 30, 70, 8, 8, 1, "The father of all the undead");
            Vampire vampire2 = new Vampire("Ammar", 35, 40, 10, 12, 1, "One of the oldest vampires still unalived..");

            Turtle turtle = new Turtle("Mikey", 25, 50, 10, 4, 1, "He is no longer a teenager but he is still a mutant turtle", 3, 10);

            Dragon dragon = new Dragon("Smaug", 35, 65, 20, 10, 1, "The last great dragon", isScaly: true);
            Dragon galzra = new Dragon();

            Undead zombie = new Undead();
            Undead skeleton = new Undead("Skeleton", 30, 60, 15, 12, 1, "A Skeleton holding a sword and shield");

            Creature spider = new Creature("Giant Black Widow", 40, 50, 12, 10, 1, "A 10-foot tall spider that shots poisionious webs");
            Creature leprechaun = new Creature("McGetcha", 35, 45, 10, 8, 1, "A Leprechuan that will stop at nothing to find his pot of gold..");

            List<Monster> monsters = new List<Monster>()
            {
                rabbit,
                vampire,vampire,
                vampire2,vampire2,
                turtle,
                dragon,
                galzra, galzra, galzra,
                zombie,
                skeleton,skeleton,
                spider,
                leprechaun,leprechaun

            };
            int randomIndex = new Random().Next(monsters.Count);
            Monster monster = monsters[randomIndex];
            return monster;


        }
    }
}
