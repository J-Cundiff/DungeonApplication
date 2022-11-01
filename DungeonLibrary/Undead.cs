using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Undead : Monster
    {

        //CONSTRUCTORS --- collect
        public Undead()
        {
            Name = "Zombie";
            MaxLife = 20;
            HitChance = 25;
            Block = 10;
            Life = MaxLife;
            MaxDamage = 12;
            MinDamage = 1;
            Description = "A reawakened corpse with a ravenous appetite for brains....";

        }

        public Undead(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description) 
            : base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
        }

        //METHODS --- monkeys
        public override string ToString()
        {
            return base.ToString();
        }



    }
}
