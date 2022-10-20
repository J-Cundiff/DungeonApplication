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
        //minDamage as an int - can't be more than MaxDamage or less than 0
        //MaxDamage as an int
        //Decsription as a string
        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if(value > 0 && value <= MaxDamage)
                {
                    MinDamage = value;

                }
                else
                {
                    MinDamage = 1;
                }
            }
        }

        //CONSTRUCTORS --- collect
        public Monster()
        {

        }

        public Monster(string name, int hitChance, int block, int maxLife, int maxDamage, int minDamage, string description) 
            : base(name, hitChance, block, maxLife)
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
                //minDanage to MaxDamage
                $"Damage: {MinDamage} to {MaxDamage}\n" +
                $"Block: {CalcBlock}\n" +
                $"{Description}";
        }
        public override int CalcDamage()
        {
            
            Random random = new Random();
            
            return random.Next(MinDamage, MaxDamage + 1);
            //return a random number between monster min and maxDamage.
        }
    }
}
