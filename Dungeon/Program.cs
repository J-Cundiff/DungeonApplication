using DungeonLibrary;
using RoomGenerator;
namespace Dungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Title & Introduction
            #region Tittle / Introduction

            Console.Title = "**************DUNGEON OF NIGHTMARES**************";
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

            //Weapon Object Creation
            //Weapon.GetWeapon(); //Made a Method to return a random weapon for the player.


            //Player Object Creation
            #region Player Creation

            //Expansion: 
            //Allow player to define chatacter name
            Console.Write("Dungeon Explorer, what is your name? ");
            string userName = Console.ReadLine().ToUpper();
            Console.Clear();

            
            #region race choice attempt
            /*
            bool choice = false;
            do
            {


                Console.Write("Choose your Race: 1)Human\n2)Orc\n3)Elf\n4)Dwarf\n5)Khajit\n6)Gnome\n7)Dragonborn\n8)Tiefling\n9)Alien\nA)Halfling\nB)Aasimar\nC)Drow\nR)Random");
                ConsoleKey userChoice = Console.ReadKey(true).Key;

                #region switch for race choice
                switch (userChoice)
                {
                    case ConsoleKey.D1:
                        userChoice = Race.Human;
                        choice = false;
                        break;

                    case ConsoleKey.D2:
                        userChoice = (ConsoleKey)Race.Orc;
                        choice = false;
                        break;

                    case ConsoleKey.D3:
                        userChoice = (ConsoleKey)Race.elf;
                        choice = false;
                        break;

                    case ConsoleKey.D4:
                        userChoice = (ConsoleKey)Race.Dwarf;
                        choice = false;
                        break;

                    case ConsoleKey.D5:
                        userChoice = (ConsoleKey)Race.Khajit;
                        choice = false;
                        break;

                    case ConsoleKey.D6:
                        userChoice = (ConsoleKey)Race.Gnome;
                        choice = false;
                        break;

                    case ConsoleKey.D7:
                        userChoice = (ConsoleKey)Race.Dragonborn;
                        choice = false;
                        break;

                    case ConsoleKey.D8:
                        userChoice = (ConsoleKey)Race.Tiefling;
                        choice = false;
                        break;

                    case ConsoleKey.D9:
                        userChoice = (ConsoleKey)Race.Alien;
                        choice = false;
                        break;

                    case ConsoleKey.A:
                        userChoice = (ConsoleKey)Race.Halfling;
                        choice = false;
                        break;

                    case ConsoleKey.B:
                        userChoice = (ConsoleKey)Race.Aasimar;
                        choice = false;
                        break;

                    case ConsoleKey.C:
                        userChoice = (ConsoleKey)Race.Drow;
                        choice = false;
                        break;

                    case ConsoleKey.R:
                        userChoice = (ConsoleKey)Player.GetRandomRace();
                        choice = false;

                        break;


                    default:
                        break;
                }
                #endregion
            } while (!choice); 
            */
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


            Weapon weapon = Weapon.GetWeapon();
            Race playerRace = Player.GetRandomRace();
            Player player = new Player(userName, 70, 5, 40, playerRace, weapon);
            #endregion

            
            

            
            #region Main Game Loop

            //Counter variabale - used in the condition of the loop
            bool exit = false;

            do
            {

                //Generate a random room the player will enter
                //Console.WriteLine("\n*******Dungeon Room*********\n");
                Console.WriteLine(GetRoom());



                //Select a random monster to inhabit the room
                Monster monster =  Monster.GetMonster();
                Console.WriteLine("\nIn this room..." + monster.Name );

                //Create the gameplay menu loop.

                #region Gameplay Menu Loop

                bool reload = false;

                do
                {

                    //Create the main gameplay menu
                    #region MENU

                    //Promt the user
                    Console.Write("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run Away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");

                    //Capture the user's menu selection
                    ConsoleKey userChoice = Console.ReadKey(true).Key;//Capture the pressed key, hide the key from the console and execute immediately

                    //Clear the console
                    Console.Clear();

                    //Use branching logic to act upon the user's selection
                    switch (userChoice)
                    {
                       case ConsoleKey.A:

                            //Combat
                            #region Possible Expansion - Racial/Weapon Bonus

                            //Possible Expansion: Give certain character races or characters with a certain weapon an advantage
                            //if (player.CharacterRace == Race.DarkElf)
                            //{
                            //    Combat.DoAttack(player, monster);
                            //}
                            #endregion


                            Combat.DoBattle(player, monster);
                            //Check if the monster is dead
                            if (monster.Life <= 0)
                            {
                                //loot, gold, experience, etc..
                                //use green to indicate winning
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





            } while (!exit);//keep looping as long as exit is flase

            #endregion

                //TODO output the Final Score
                Console.WriteLine("You defeated " + score + " monster" + ((score == 1) ? "." : "s."));





            #region KeyRead
            Console.WriteLine("Press any key to exit the dungeon...");
            Console.ReadKey(true);//true-  intercept - you wont see what the user types.
                                  //false (default) -lets you see what user types
            #endregion
        }//end main()
        private static string GetRoom()
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