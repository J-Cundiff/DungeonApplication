using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        
        
        //Properties
        public Race CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }

        
        

        //CONSTRUCTORS
        public Player(string name, int hitChance, int block, int maxLife, Race characterRace, Weapon equippedWeapon)
           : base(name, maxLife, hitChance, block)
        {
          
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
           
        }
       

        //METHODS
        public override int CalcDamage()
        {
            
            return new Random().Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            
        }
        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
            
        }
      
        public override string ToString()
        {
            string descsription = CharacterRace.ToString().Replace('_', ' ');
            Weapon weapon = Weapon.GetWeapon();
            #region Switch for CharacterRace
            switch (CharacterRace)
            {
                case Race.Human:
                    descsription = "Humans are a boring... good luck..";
                    break;
                case Race.Orc:
                    descsription = "Orcs are a brutish, aggressive, ugly, and malevolent race of monsters,";
                    break;
                case Race.Elf:
                    descsription = "Elves are slender, graceful yet strong, and were resistant to extremes of nature, illness and disease";
                    break;
                case Race.Dwarf:
                    descsription = "Dwarfs are Bold and hardy, dwarves are known as skilled warriors, miners, and workers of stone and metal.";
                    break;
                
                case Race.Gnome:
                    descsription = "Gnomes average slightly over 3 feet tall and weigh 40 to 45 pounds. Their tan or brown faces are usually adorned with broad smiles (beneath their prodigious noses), and their bright eyes shine with excitement.";
                    break;
                
                case Race.Alien:
                    descsription = "Ramurans are mind-altering aliens with the highest advancement in stealth imaginable";
                    break;
                 default:
                    break;
            }
                    #endregion
                    
                    
                    return String.Format( $"--------{Name}---------\n" +
                $"Life: {Life} of {MaxLife}\n" +
                $"Weapon: {EquippedWeapon}" +
                $"Hit Chance: {CalcHitChance()}%\n" +
                $"Block: {Block}\n" +
                $"Race: {CharacterRace}\n" +
                $"Description: {descsription}"); 

            
            
            

        }
        public static Race GetRandomRace()
        {
            
            
            List<Race> races = new List<Race>()
            {
                Race.Gnome,
                Race.Alien,
                Race.Human,
                Race.Dwarf,
                Race.Elf,
                Race.Orc,
                  
            };
            int randNum = new Random().Next(races.Count);
            Race randRace = races[randNum];
            return randRace;
        }
        



    }
}
