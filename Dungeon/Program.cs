using DungeonLibrary;
using RoomGenerator;
using System.ComponentModel;

namespace Dungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Title & Introduction
            #region Tittle / Introduction

            Console.Title = "**************DUNGEON*****************";
            string art = @"                            
                           |.'',                                     ,''.|
                           |.'.'',                                 ,''.'.|
                           |.'.'.'',                             ,''.'.'.|
                           |.'.'.'.'',                         ,''.'.'.'.|
                           |.'.'.'.'.|                         |.'.'.'.'.|
                           |.'.'.'.'.|===;                 ;===|.'.'.'.'.|
                           |.'.'.'.'.|:::|',             ,'|:::|.'.'.'.'.|
                           |.'.'.'.'.|---|'.|, _______ ,|.'|---|.'.'.'.'.|
                           |.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
                           |,',',',',|---|',|'|???????|'|,'|---|,',',',',|
                           |.'.'.'.'.|:::|'.|'|???????|'|.'|:::|.'.'.'.'.|
                           |.'.'.'.'.|---|','   /%%%\   ','|---|.'.'.'.'.|
                           |.'.'.'.'.|===:'    /%%%%%\    ':===|.'.'.'.'.|
                           |.'.'.'.'.|%%%%%%%%%%%%%%%%%%%%%%%%%|.'.'.'.'.|
                           |.'.'.'.','       /%%%%%%%%%\       ','.'.'.'.|
                           |.'.'.','        /%%%%%%%%%%%\        ','.'.'.|
                           |.'.','         /%%%%%%%%%%%%%\         ','.'.|
                           |.','          /%%%%%%%%%%%%%%%\          ','.|
                           |;____________/%%%%%%%%%%%%%%%%%\____________;|";
            #endregion



            //Variable to Track the players score
            int score = 0;

            //Player Object Creation
            #region Player Creation

            
            //User Name Input
            Console.Write("Dungeon Explorer, what is your name? ");
            string userName = Console.ReadLine().ToUpper();
            Console.Clear();

            //User Race Selection
            #region Race Selection
            bool raceChosen = false;
            Race userRace = new Race();
            do
            {
                Console.WriteLine("****Chose Your Race*****");
                Console.WriteLine("[H]Human\n[G]Gnome\n[A]Alien\n[D]Dwarf\n[E]Elf\n[O]Orc\n[R]Random");
                ConsoleKey raceChoice = Console.ReadKey(true).Key;
                Console.Clear();

                switch (raceChoice)
                {
                    case ConsoleKey.H:
                        userRace = Race.Human;
                        raceChosen = true;
                        break;
                    case ConsoleKey.G:
                        userRace = Race.Gnome;
                        raceChosen = true;
                        break;
                    case ConsoleKey.A:
                        userRace = Race.Alien;
                        raceChosen = true;
                        break;
                    case ConsoleKey.D:
                        userRace = Race.Dwarf;
                        raceChosen = true;
                        break;
                    case ConsoleKey.E:
                        userRace = Race.Elf;
                        raceChosen = true;
                        break;
                    case ConsoleKey.O:
                        userRace = Race.Orc;
                        raceChosen = true;
                        break;
                    case ConsoleKey.R:
                        userRace = Player.GetRandomRace();
                        raceChosen = true;
                            break;
                    default:
                        Console.WriteLine("Invalid Selection....");
                        break;
                }

            } while (!raceChosen);



            #endregion


            //User Weapon Selection
            #region MyRegion Weapon Selection
            bool weaponChosen = false;
            Weapon userWeapon = new Weapon();
            do
            {
                Console.WriteLine("****Chose your Weapon****\n");
                Console.WriteLine("[S]Sword\n[N]Necromancy\n[F]Fire\n[W]Water\n[D]Daggers\n[R]Random");
                ConsoleKey weaponChoice = Console.ReadKey(true).Key;
                Console.Clear();

                switch (weaponChoice)
                {


                    case ConsoleKey.S:
                        userWeapon = new Weapon(8, "Long Sword", 10, false, WeaponType.Sword, 1);
                        weaponChosen = true;
                        break;
                    case ConsoleKey.N:
                        userWeapon = new Weapon(12, "Necromancy", 15, true, WeaponType.Magical, 1);
                        weaponChosen = true;
                        break;
                    case ConsoleKey.F:
                        userWeapon = new Weapon(10, "Fire Magic", 12, true, WeaponType.Elemental, 1);
                        weaponChosen = true;
                        break;
                    case ConsoleKey.W:
                        userWeapon = new Weapon(7, "Water Magic", 10, false, WeaponType.Elemental, 1);
                        weaponChosen = true;
                        break;
                    case ConsoleKey.D:
                        userWeapon = new Weapon(5, "Daggers of the dead", 9, true, WeaponType.Knife, 1);
                        weaponChosen = true;
                        break;
                    case ConsoleKey.R:
                        userWeapon = Weapon.GetWeapon();
                        weaponChosen = true;
                        break;

                    default:
                        Console.WriteLine("Invalid Selection...");
                        break;
                } 

            } while (!weaponChosen);
                #endregion

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(art);
            Console.ResetColor();
            Console.WriteLine($"Welcome, {userName}!\n" +
                $" Your journey begins...\n" +
                $"You enter a dark, mysterious dugneon with noone in sight....\n" +
                $"or so you think.... ");
            Console.ReadKey();
            Console.Clear();

            
            Player player = new Player(userName, 70, 13, 45, userRace, userWeapon);
            #endregion

            #region Main Game Loop

            
            bool exit = false;
            do
            {

                //Generate a random room the player will enter
                Console.WriteLine("\n*********Room Description*********\n");
                Console.WriteLine(GetRoom());



                //Random monster to inhabit the room
                Monster monster =  Monster.GetMonster();
                Console.WriteLine("\nIn this room..." + monster.Name + "!!!" );

                

                #region Gameplay Menu Loop

                bool reload = false;

                do
                {

                    
                    #region MENU

                    //User Menu
                    Console.Write("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");

                    //Capture the user's menu selection
                    ConsoleKey userChoice = Console.ReadKey(true).Key;
                    Console.Clear();

                    //User Selection
                    switch (userChoice)
                    {
                       case ConsoleKey.A:
                            //Combat

                            Combat.DoBattle(player, monster);
                            //Check if the monster is dead
                            if (monster.Life <= 0)
                            {
                                
                                Console.ForegroundColor = ConsoleColor.Green;

                                //output result
                                Console.WriteLine($"\nYou killed {monster.Name}!");
                                Console.ResetColor();

                                //Leave the inner loop
                                reload = true;

                                score++;
                            }
                          
                            break;

                        case ConsoleKey.R:
                            //Run away - Attack of Opportunity
                           
                            Console.WriteLine("Run Away!!!!!");

                            //monster gets an attack of opportunity
                            Console.WriteLine(monster.Name + " attacks you as you flee!");
                            Combat.DoAttack(monster, player);
                            

                            reload = true;
                            break;


                        case ConsoleKey.P:
                            //Player Stats
                          Console.WriteLine(player);
                           break;

                         case ConsoleKey.M:
                             //Monster Stats
                            Console.WriteLine(monster);
                            break;
                            

                        case ConsoleKey.X:
                        case ConsoleKey.E:
                        case ConsoleKey.Escape:
                            //Exit
                           exit = true;
                            Console.WriteLine("Nobody likes a quitter...");
                            break;

                         default:
                            Console.WriteLine("Thou has chosen an improper option. Triest again.");
                             break;
                    }//end switch
                    #region Check Player's Life Total 

                    //Check player's life
                    if (player.Life <= 0)
                    {
                        Console.WriteLine("Dude...you died!");
                        exit = true;
                        continue;
                    }

                    #endregion



                    #endregion





                } while (!reload && !exit);//end do while 

                #endregion





            } while (!exit);//end do while

            #endregion

                //Output Final Score
                Console.WriteLine("You defeated " + score + " monster" + ((score == 1) ? "." : "s."));





            #region KeyRead
            Console.WriteLine("Press any key to exit the dungeon...");
            Console.ReadKey(true);
            #endregion
        }//end main()
        public static string GetRoom()
        {
            
            #region Room Decriptions
            string[] rooms =
            {
                "You enter a room with thick cobwebs fill the corners of the room, and wisps of webbing hang from the ceiling and waver in a wind youcan barely feel. One corner of the ceiling has a particularly large clot of webbing within which a goblin's bones aretangled.",

                 "You enter a room with contrast between total darkness all around and cone of light projected at smiling mask on pedestal. The walls start to move in towards each other....\n" +
                "better hurry...",

                "You enter a room with a demon sultan on a diamond throne carried by manticores. Everybody who doesn’t bow is decapitated. Secret elevator to observatory in random column.",

                "You enter a room with a large, ragged room. It's covered in small bones, large bones and roots.\r\nYour torch allows you to see a broken tomb, decayed and absorbed by time itself.",

                 "You enter a room with when a flurry of bats suddenly flaps through the doorway, their screeching barely audible as they careen past yourheads. They flap past you into the rooms and halls beyond. The room from which they came seems barren at firstglance.",

                "You enter a room with three low, oblong piles of rubble lie near the center of this small room. Each has a weapon jutting upright from one end -- a longsword, a spear, and a quarterstaff. The piles resemble cairns used to bury dead adventurers.",

                "You enter a room with a 30-foot-tall demonic idol dominates this room of black stone. The potbellied statue is made of red stone, and its grinning face holds what looks to be two large rubies in place of eyes. A fire burns merrily in a wide brazier the idolholds in its lap.",

                "You enter a room....as the door opens, it scrapes up frost from a floor covered in ice. The room before you looks like an ice cave. A tunnel wends its way through solid ice, and huge icicles and pillars of frozen water block your vision of its farthestreaches.",

                "As you enter this room a glow escapes the room through its open doorways. The masonry between every stone emanates an unnatural orange radiance. Glancing quickly about the room, you note that each stone bears the carving of someone's name.",

                "When looking into this chamber, you're confronted by a thousand reflections of yourself looking back. Mirrored walls set at different angles fill the room. A path seems to wind through the mirrors, although you can't tell where itleads.",

                "You enter a small room and your steps echo. Looking about, you're uncertain why, but then a wall vanishes andreveals an enormous chamber. The wall was an illusion and whoever cast it must be nearby!"
            };
                 return rooms[new Random().Next(rooms.Length)];
            #endregion


        }//end GetRoom()

    }//end class
}//end namespace