using RoomGenerator;
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
                #region Room Decriptions
                string[] rooms = new string[4];
                rooms[0] = "The door is made of redwood planks, it has a turning handle with no lock and an oversized human-like handprint, about ten inches across, is burnt into the door. This room has a black granite tile floor. Numerous lines are etched into the floor. They are less than a finger's width wide and have been filled and obscured by dirt and wear.\n\n" +
                        "The far wall is covered in small niches, about a forearm's width across and half as deep. Just inside the door sits a skeleton on a chair, it holds a rusted sword in it's hand and wears rotted leather armor.\n" +
                        "The air in the room is clear but cold. The room smells acrid. A loud bellowing noise can be heard.";

                rooms[1] = "he door is made of slate, it has a wood bolt on the inside and a hole has been drilled through the door at waist height but has been plugged with mud and wood. This room has an irregular flagstone tile floor. The floor of this room has several gentle waves worn into the stone, as if millions of feet wore some sort of haphazard paths into the stone. The ceiling is a coffered (flat ceiling with sunken rectangular recessed panels) and is covered with spikes. Many are rusted, stained, bent or even broken. They are spaced regularly every foot or so and protrude down about a foot.\n\n" +
                    "Two of the walls are covered in mushrooms. Investigation shows that they are made of stone. The skeleton of a small canine is curled up in one corner.\n" +
                    "The air in the room is clear and warm. The room smells earthy. A faint drumming noise can be heard.";

                rooms[2] = "The door is made of bronze, it has a carved wooden handle and shows signs of acid damage. This room has a hexagonal slate tile floor. Line traces of violet light appear and disappear randomly across the floor. The ceiling is a flat reinforced with stone beam with regular rectangular shaped beams and is covered with drops of condensation which occasionally run or drip to the ground below. Investigation reveals that it is cold to the touch.\n\n" +
                    "Elaborately carved in relief upon the wall is a Celtic cross. The entire room smells of wildflowers as if you were standing in a large meadow at the height of spring.\n" +
                    "The air in the room is clear but cold. The room smells of Manure. A faint bellowing noise can be heard.";

                rooms[3] = "The door is made of redwood planks with iron bands, it has a carved wooden knob and a red hand print is painted in the center. This room has a hexagonal slate tile floor. A five-foot circle of white marble is centered in the floor of this room. It is flush with the rest of the floor and shows no signs of stains or wear. The ceiling is a flat reinforced with stone beam with regular rectangular shaped beams and with a dozen pitons hammered into a star shaped pattern.\n\n" +
                    "A two-foot-high relief carved merchant's scale has been carved into the wall. Just inside the door sits a skeleton on a chair, it holds a rusted sword in it's hand and wears rotted leather armor.\n" +
                    "The air in the room is misty and cold. The room smells putrid. A loud clicking noise can be heard.";
                Random randRoomNmbr = new Random();
                int rand = randRoomNmbr.Next(rooms.Length);
                string randRoom = rooms[rand];
                #endregion



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