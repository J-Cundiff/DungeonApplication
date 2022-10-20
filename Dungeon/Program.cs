using DungeonLibrary;
using RoomGenerator;
namespace Dungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Title & Introduction
            #region Tittle / Introduction

            Console.Title = "DUNGEON OF DOOM";

            Console.WriteLine("Your journey begins...\n");

            #endregion
            
            

            //Variable to Track the players score

            int score = 0;


            //Weapon Object Creation
            Weapon sword = new Weapon(8, "Long Sword", 10, false, WeaponType.Sword, 1);
            Weapon ninjaStars = new Weapon(6, "Ninja Stars", 10, false, WeaponType.Projectile, 1 );
            Weapon fire = new Weapon(10, "Fire Magic", 12, true, WeaponType.Elemental, 1);
            
            //Player Object Creation
            Player p1 = new Player("Roxy", 10, 5, 100, Race.Alien, sword);
            Player p2 = new Player("Gemma", 8, 5, 100, Race.Dragonborn, ninjaStars);
            Player p3 = new Player("Ranaldo", 12, 8, 100, Race.Gnome, fire);

            Player[] player = { p1, p2, p3 };  

            Random rand = new Random();
            int randChar = rand.Next(player.Length);
            

            Console.WriteLine(player[randChar]);
            
            

            //TODO Create the main game loop

            #region Main Game Loop

            //Counter variabale - used in the condition of the loop
            bool exit = false;

            do
            {

                //TODO Generate a random room the player will enter ---- (Use for HW)
                
                Console.WriteLine(GetRoom());



                //TODO Select a random monster to inhabit the room

                //Create the gameplay menu loop.

                #region Gameplay Menu Loop

                bool reload = false;

                do
                {

                    //TODO Create the main gameplay menu
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

                    //USe branching logic to act upon the user's selection
                    switch (userChoice)
                    {
                       case ConsoleKey.A:

                            //TODO Combat
                            Console.WriteLine("Atatck");
                          
                            break;

                        case ConsoleKey.R:
                            //TODO Run away - Attack of Opportunity
                           
                            Console.WriteLine("Run Away");
                            reload = true;
                            break;


                        case ConsoleKey.P:
                            //TODO Player Stats
                          
                            Console.WriteLine("Player Info");
                           
                            break;

                         case ConsoleKey.M:
                            
                            //Monster Stats
                            Console.WriteLine("Monster Info");
                           
                            break;
                            

                        case ConsoleKey.X:
                        case ConsoleKey.E:
                        case ConsoleKey.Escape:
                            //Exit
                           
                            exit = true;
                            
                            Console.WriteLine("Nobody likes a quitter...");
                           
                            break;



                        default:

                            Console.WriteLine("Thou has chosen an improper option. Triest throu again.");

                            break;
                    }//end switch
                    #region Check Player's Life Total 
                    
                    //TODO Check player's life

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
            //code
            #region Room Decriptions
            string[] rooms =
            {
             "Cavemen lurk behind row of giant mushrooms that split the room in two areas. Enemies shake fungi to release hallucinogenic spores",

             "Contrast between total darkness all around and cone of light projected at smiling mask on pedestal. Giant spiders drop from ceiling.",

             "Demon sultan on diamond throne carried by manticores. Everybody who doesn’t bow is decapitated. Secret elevator to observatory in column #649.",

            "A large, ragged room. It's covered in small bones, large bones and roots.\r\nYour torch allows you to see a broken tomb, decayed and absorbed by time itself.",

            "A modest, humid room. It's covered in puddles of water, puddles of water and large bones.\r\nYour torch allows you to see drawings and symbols on the walls, pillaged and spoiled by time itself."
            #endregion
        };

            /*
            Random roomDescrip = new Random();
            int rand = roomDescrip.Next(rooms.Length);
            string randRoom = rooms[rand];
            return randRoom;
            //**same as below***/
            
            return rooms[new Random().Next(rooms.Length)];


        }//end GetRoom()

    }//end class
}//end namespace