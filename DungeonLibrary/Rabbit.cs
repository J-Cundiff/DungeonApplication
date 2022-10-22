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
            Name = "Baby Rabbit";
            MaxLife = 6;
            HitChance = 20;
            Block = 20;
            MaxDamage = 3;
            Life = MaxLife;
            MinDamage = 1;
            Description = "It's just a cute little bunny.... Why would you hurt it?";
            IsFluffy = false;
        }
        //Parent compliment (Monster) ctor
        //Intellisense quick action on the Parent name in the class declaration.
        public Rabbit(string name, int maxLife, int hitChance, int block, //Character
             int maxDamage, int minDamage, string description,//Monster
            bool isFluffy) //Rabbit
            : base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
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
