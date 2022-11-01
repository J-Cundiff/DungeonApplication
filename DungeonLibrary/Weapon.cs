using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
        
    {
        
       
        //FIELDS

        
        private WeaponType _type;
        private int _minDamage;
        private int _maxDamage;
        private string? _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;

        //PROPERTIES
        
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
              

            }
        }
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        //CONSTRUCTORS 
        public Weapon() { }

        public Weapon(int maxDamage, string name, int bonusHitChance, bool isTwoHanded, WeaponType type, int minDamage)
        {
           
            MaxDamage = maxDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
            Type = type;
            MinDamage = minDamage;
           
        }

        
        public override string ToString()
        {
            return $"{Name}\t{MinDamage} to {MaxDamage} Damage\n" +
                $"Bonus Hit: {BonusHitChance}%\n" + 
                $"Type: {Type}\t\t{(IsTwoHanded ? " Two-Handed " : " One-Handed ")}";
        }
        public  static Weapon GetWeapon()
        {
            Weapon sword = new Weapon(8, "Long Sword", 10, false, WeaponType.Sword, 1);
            Weapon ninjaStars = new Weapon(6, "Ninja Stars", 10, false, WeaponType.Projectile, 1);
            Weapon fire = new Weapon(10, "Fire Magic", 12, true, WeaponType.Elemental, 1);
            Weapon water = new Weapon(7, "Water Magic", 10, false, WeaponType.Elemental, 1);
            Weapon daggers = new Weapon(5, "Daggers of the dead", 9, true, WeaponType.Knife, 1);
            Weapon necromany = new Weapon(12, "Necromancy", 15, true, WeaponType.Magical, 1);

            List<Weapon> weapons = new List<Weapon>()
            {
                sword,sword,sword,
                ninjaStars,ninjaStars,
                fire,
                water, water,
                daggers,daggers,daggers,
                necromany
            };
            int randIndex = new Random().Next(weapons.Count);
            Weapon weapon = weapons[randIndex];
            return weapon;


        }
    }
}
