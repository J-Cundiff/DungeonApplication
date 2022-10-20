using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        //Fields
        //none
        
        //Properties
        public Race CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        

        //CONSTRUCTORS --- collect
        public Player(string name, int hitChance, int block, int maxLife, Race characterRace, Weapon equippedWeapon)
           : base(name, hitChance, block, maxLife)
        {
            #region Possiable expansion
            //potenial expansion, not required
            //handle unique assignment
            // case Race.Elf:
            //    HitChance =+ 5;
            //    MaxHealth -= 5;
            //   break; 
            #endregion
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;


        }
        public Player()
        {

        }

        //METHODS --- monkeys
        public override int CalcDamage()
        {
           Random random = new Random();
            return random.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
        }
        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
            //HitChance  + Weapon BonusHitChance
        }
       
        public override string ToString()
        {

            #region Switch for CharacterRace
            switch (CharacterRace)
            {
                case Race.Human:
                    Console.WriteLine("Humans are a boring... good luck..");
                    break;
                case Race.Orc:
                    Console.WriteLine("Orcs are a brutish, aggressive, ugly, and malevolent race of monsters,");
                    break;
                case Race.elf:
                    Console.WriteLine("Elves are slender, graceful yet strong, and were resistant to extremes of nature, illness and disease");
                    break;
                case Race.Dwarf:
                    Console.WriteLine("Dwarfs are Bold and hardy, dwarves are known as skilled warriors, miners, and workers of stone and metal.");
                    break;
                case Race.Khajit:
                    Console.WriteLine("Khajit are known for their natural agility, stealth, and their production of moon sugar, which can be refined into skooma.");
                    break;
                case Race.Dragonborn:
                    Console.WriteLine("Drangonborn are tall and strongly built, often standing close to 6½ feet tall and weighing 300 pounds or more. Their hands and feet are strong, talonlike claws with three fingers and a thumb on each hand.");
                    break;
                case Race.TieFling:
                    Console.WriteLine("Tie Flings possess large thick horns of various styles on their heads, prehensile tails approximately 4 to 5 feet in length, sharply pointed teeth, and their eyes are solid orbs of red, black, white, silver, or gold.");
                    break;
                case Race.Gnome:
                    Console.WriteLine("Gnomes average slightly over 3 feet tall and weigh 40 to 45 pounds. Their tan or brown faces are usually adorned with broad smiles (beneath their prodigious noses), and their bright eyes shine with excitement.");
                    break;
                case Race.HalfLing:
                    Console.WriteLine("Halflings are inclined to be stout, weighing between 40 and 45 pounds. Halflings' skin ranges from tan to pale with a ruddy cast, and their hair is usually brown or sandy brown and wavy. They have brown or hazel eyes. Halfling men often sport long sideburns, but beards are rare among them and mustaches even more so.");
                    break;
                case Race.Alien:
                    Console.WriteLine("Ramurans are mind-altering aliens with the highest advancement in stealth imaginable");
                    break;
                case Race.Aasimar:
                    Console.WriteLine("Aasimar are human-based planetouched, native outsiders that had in their blood some good, otherworldly characteristics. They were often, but not always, descended from celestials and other creatures of pure good alignment, but while predisposed to good alignments, aasimar were by no means always good.");
                    break;
                case Race.Drow:
                    Console.WriteLine("The Drow(dark elves) are a dark-skinned and white-haired subrace of elves connected to the subterranean Underdark. They are generally evil and connected to the evil goddess Lolth.");
                    break;
                default:
                    break;
            }
                    #endregion
                    //holding variable for the description
                    //Switch on CharacterRace
                    //case CharacterRace.Elf
                    //description = "Describe an elf"
                    return String.Format( $"--------{Name}---------\n" +
                $"Life: {Life} of {MaxLife}\n" +
                $"Weapon: {EquippedWeapon}" +
                $"Hit Chance: {HitChance}%\n" +
                $"Block: {Block}\n" +
                $"Race: {CharacterRace}\n"); //+some unquie description based in the player race

            
            
            

        }


    }
}
