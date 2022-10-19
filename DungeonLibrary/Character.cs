﻿namespace DungeonLibrary
{
    //The "Abstract" modifier:
    //Denotes this datatype class is "incomplete" -- we don't intend
    //to make a Character object, but will instead use Character as 
    //a starting point for other, more specific types. More on this later.

    public abstract class Character
    {
        //fields
        private int _life;
        private string _name;
        private int _hitChance;
        private int _block;
        private int _maxLife;

        //Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }

        private int Block
        {
            get { return _block; }
            set{ _block = value; }
        }

        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }

        public int Life
        {
            get { return _life; }
            set 
            {
                if (value <= MaxLife)
                {
                    _life = value;
                }//end if
                else
                {
                    _life = MaxLife;
                }//end else
            }//end set
        }
        //Constructors
        public int ClacBlock()
        {
            return Block;
        }
        public int CalcHitChance()
        {
            return HitChance;
        }
        public int CalcDamage()
        {
            return 0;
        }

        public override string ToString()
        {
            return string.Format("{0}:\n" +
                "Current life:{1}\n" +
                "MaxLife:{2}\n" +
                "Block:{3}\n" +
                "Hit Chance:{4}", Name, Life, MaxLife, Block, HitChance);
        }

    }
}