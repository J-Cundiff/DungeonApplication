using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Rabbit : Monster
    {
        //FIELDS --- funny
        // no fields

        //PROPERTIES --- people
        public bool IsFluffy { get; set; }

        //CONSTRUCTORS --- collect
        //Default ctor to set some basic values for a generic monster of this type
        public Rabbit()
        {
            MaxLife = 6;
            MaxDamage = 3;
            Name = "Baby Rabbit";
            Life = MaxLife;
            HitChance = 20;
            Block = 20;
            MinDamage = 1;
            Description = "It's just a cte little bunny.... Why would you hurt it?";
            IsFluffy = false;
        }
        //Parent compliment (Monster) ctor
        //Intellisense quick action on the Parent name in the class declaration.
        public Rabbit(string name, int hitChance, int block, //Character
            int maxLife, int maxDamage, int minDamage, string description,//Monster
            bool isFluffy) //Rabbit
            : base(name, hitChance, block, maxLife, maxDamage, minDamage, description)
        {
            IsFluffy = isFluffy;
        }


        //METHODS --- monkeys

        public override string ToString()
        {
            return base.ToString() + (IsFluffy ? "It's Fluffy!!" : "It's not fluffy");
        }
        //Character CalcBlock = Block
        //Monster CalcBlock = Block
        //Rabbit CalcBlock = not Block
        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            //Apply a 50% increase to the rabbit's if it's fluffy
            if (IsFluffy)
            {
                calculatedBlock += calculatedBlock / 2;
            }
            return calculatedBlock;
        }
    }
}
