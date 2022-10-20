using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
        //type - WeaponType
    {
        //minDamage – int

        //maxDamage – int

        //name – string

        //bonusHitChance – int

        //isTwoHanded - bool



        //Full Qualified CTOR

        //Nicely Formatted ToString()



        

       
        //FIELDS --- funny

        
        private WeaponType _type;
        private int _minDamage;
        private int _maxDamage;
        private string? _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;

        //PROPERTIES --- people
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }
        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }
        public WeaponType Type
        {
            get { return _type; }
            set { _type = value; }
        }
        
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
               _minDamage = (value > 0 && value <= MaxDamage ? value : 1);
                //If the value passed is greater than 0 && less than less than ot equal to max damage,
                //assisgn that value to _minDamage.Otherwise, assign 1 to _minDamage
                //this.MinDamage++, += 5, could send it over MaxDamage, we don't want that
                /*
                if (value > 0 && value <= MaxDamage)
                {
                   _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }*/

            }
        }
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        //CONSTRUCTORS --- collect
        public Weapon() { }

        public Weapon(int maxDamage, string name, int bonusHitChance, bool isTwoHanded, WeaponType type, int minDamage)
        {
            //Property = parameter
            //PascalCase = camelCase
            //Any other properties with business rules that rely on other properties MUST come AFTER
            //those properties are set.
            MaxDamage = maxDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            Type = type;
            MinDamage = minDamage;
           
        }

        //METHODS --- monkeys
        public override string ToString()
        {
            return $"{Name}\t{MinDamage} to {MaxDamage} Damage\n" +
                $"Bonus Hit: {BonusHitChance}%\n" + 
                $"Type: {Type}\t\t{(IsTwoHanded ? "Two-Handed" : "One-Handed")}";
        }//end ToString 

    }
}
