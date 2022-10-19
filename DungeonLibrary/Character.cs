namespace DungeonLibrary
{
    public class Character
    {
        private int _life;
        private string _name;
        private int _hitChance;
        private int _block;
        private int _maxLife;


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