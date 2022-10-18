namespace Dungeon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Title & Introduction
            #region Tittle / Introduction

            Console.Title = "DUNGEON OF DOOM";

            Console.WriteLine("Your journey begins...\n");

            #endregion


            //Variable to Track the players score

            int score = 0;


            //TODO Weapon Object Creation


            //TODO Player Object Creation


            //TODO Create the main game loop

            #region Main Game Loop

            //Counter variabale - used in the condition of the loop
            bool exit = false;

            do
            {

                //TODO Generate a random room the player will enter ---- (Use for HW)

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
    }//end class
}//end namespace