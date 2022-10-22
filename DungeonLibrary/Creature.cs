using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Creature : Monster
    {
        public DateTime HourChangeNight { get; set; }
       

        public Creature(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description) 
            : base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            HourChangeNight = DateTime.Now;
            if (HourChangeNight.Hour < 2 || HourChangeNight.Hour > 20)
            {
                HitChance += 12;
                Block += 13;
                MinDamage += 1;
                MaxDamage += 2;
            }
        }
        public override string ToString()
        {
            return base.ToString() + 
                (HourChangeNight.Hour < 2 || HourChangeNight.Hour > 20 ? "The night stregnthens this creature!" : "Weakend during the daytime..");
        }



    }
}
