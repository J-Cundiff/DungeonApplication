namespace DungeonLibrary
{
    //The "Abstract" modifier:
    //Denotes this datatype class is "incomplete" -- we don't intend
    //to make a Character object, but will instead use Character as 
    //a starting point for other, more specific types. More on this later.

    public abstract class Character
    {
        //fields
        private int _life;
        private string? _name;
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

        public int Block
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
                if (value <= _maxLife)
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
        public Character(string name, int maxLife, int hitChance, int block)
        {
            Name = name;
            MaxLife = maxLife;
            HitChance = hitChance;
            Block = block;
            Life = maxLife;
        }
        public Character()
        {

        }
        

        public override string ToString()
        {
            return $"--------{Name}---------\n" +
                $"Life: {Life} of {MaxLife}\n" +
                $"Hit Chance: {CalcHitChance()}%\n" +
                $"Block: {Block}";


        }
        public virtual int CalcBlock()
        {
            return Block;
        }
        public virtual int CalcHitChance()
        {
            return HitChance;
        }
        public virtual int CalcDamage()
        {
            return 0;
        }


    }
}