using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Dragon : Monster
    {

        //FIELDS --- funny




        //PROPERTIES --- people
        public bool IsScaly { get; set; }


        //CONSTRUCTORS --- collect
        public Dragon(string name, int maxLife, int hitChance, int block,  int maxDamage, int minDamage, string description, bool isScaly) 
            : base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            IsScaly = isScaly;
        }
        public Dragon()
        {
            MaxLife = 30;
            MaxDamage = 12;
            Name = "Galzra";
            Life = 35;
            HitChance = 45;
            Block = 20;
            MinDamage = 1;
            Description = "A huge fire breathing dragon. It still looks angry...";
            IsScaly = false;
        }

        //METHODS --- monkeys
        public override string ToString()
        {
            return base.ToString() + "\n" + (IsScaly ? "Coated in thick scales" : "Has a soft, underdeveloped hide");
        }
        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            //Apply a 50% increase to the rabbit's if it's fluffy
            if (IsScaly)
            {
                calculatedBlock += calculatedBlock / 2;
            }
            return calculatedBlock;
        }



    }
}
