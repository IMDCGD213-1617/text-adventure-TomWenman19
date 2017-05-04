using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Game
    {
       //Colour text reminders
       //Red text = Updates the player for found objects.
       //Blue text = Location movement. Shows where the player has gone.
       //Dark Yellow text = Item descriptions.
       //Dark Magenta text = Errors/ miss inputs.
        
        //Collects data for the location the player is in
        Location currentLocation;

        //Items for inventory system
        Item InventorySystem;

        //Allows the game to run and not instantly close
        public bool isRunning = true;

        //List for inventory system
        private List<Item> inventory;

        //Locations
        Location l1;
        Location l2;
        Location l3;
        Location l3b;
        Location l4;
        Location l5;
        Location l5b;
        Location l6;
        Location l7;
        Location l7b;
        Location l7c;
        Location l8;
        Location l8b;
        Location l8c;
        Location l8d;



        public Game()
        {
            inventory = new List<Item>();
            InventorySystem = new Item();

            Console.WriteLine("As a super villain, no-one is taking you serious anymore. \nThe only way to gain notority and fear from citizens is to capture their hero.");

            // Building the house and other locations found in the game.
            //Location 1
            l1 = new Location("Living Room", "A news report states that everyones hero is in your home town.\nLooking around your room you have spare utilities you can use\nto hatch a plan.\nCollecting items around your house will be neccesary to capture him");

            Item net = new Item();
            net.name = "net";
            net.desc = "Can be used to capture certain heroes.";
            l1.addItem(net);

            Item leafblower = new Item();
            leafblower.name = "leafblower";
            leafblower.desc = "Blows leaves. Obviously.";
            l1.addItem(leafblower);

            //Location 2
            l2 = new Location("Kitchen", "Trying to capture heroes can be hungry work.\nTaking some food could be benefiticial. ");

            Item apple = new Item();
            apple.name = "apple";
            apple.desc = "Quite tasty. May be you could use this as a *gift*";
            l2.addItem(apple);

            Item poison = new Item();
            poison.name = "poison";
            poison.desc = "Doesn't taste very good.";
            l2.addItem(poison);


            //Location 3
            l3 = new Location("Front Garden", "The front garden is covered in leaves.");

            //Location 32
            l3b = new Location("Clean Front Garden", "The front garden is now clear and reveals an object.");
            Item leaves = new Item();
            leaves.name = "leaves";
            leaves.desc = "Good for covering stuff up with";
            l3b.addItem(leaves);

            Item shovel = new Item();
            shovel.name = "shovel";
            shovel.desc = "Used for digging holes";
            l3b.addItem(shovel);

            //Location 4
            l4 = new Location("Cupboard", "All that is inside is a broom, bucket and a folded piece of paper.");
            Item paper = new Item();
            paper.name = "paper";
            paper.desc = "Some writing is found on the note. It seems to be a recipe of some kind.\nCombine poison and apple to make a painfully good snack.";
            l4.addItem(paper);


            //Location 5
            l5 = new Location("Town Statue", "In the centre of town, stands a statue commemorating the local hero.\nThe statue shows the hero holding his signature fruit, the apple.\nLocals are crowded around awaiting for his arrival.");
            l5b = new Location("Town Statue with hero", "The hero crawls towards the statue with the crowd looking worried.\nHe collapses to the floor and passes out.\n You've done it! You destroyed the local hero.\n I hope you're proud. *Slow claps*");
          
            
            //Location 6
            l6 = new Location("The Hero fan club", "The fan club stall is full of locals. You overhear them talk about how much he loves exercising and jogs through\nthe local park and often rests at the local fountain.");
           
            
            //Location 7                
            l7 = new Location("The Fountain", "A fresh water source for many joggers to rest.\n");
            Item water = new Item();
            water.name = "water";
            water.desc = "A bottle of water.";
            l7.addItem(water);
            l7b = new Location("The Fountain with the Hero", "The hero seems to be worn out. He notices you have an apple. He asks if he could eat it.");
            l7c = new Location("The Fountain with Poisoned Hero", "The hero munches on the apple without hesitation. He slowly jogs towards \nthe Town Statue");
            
            //Location 8 
            l8 = new Location("Local Park", "A place where a lot of people jog. The pathway is worndown by runners and easy\n to dig up.");
            l8b = new Location("Dug up Local Park", "A hole has been dug up on the joggers pathway.");
            l8c = new Location("Trap within Local Park", "A net has been placed over the hole.\nFinding a disguise is a neccesity.");
            l8d = new Location("Disguised Trap within Local Park", "Leaves have been placed over the net\nYou can see in the distance your enemy approaching.\nHe rushes past you and avoids the trap.\nHe rushes towards The Fountain");
            // Exits for the locations. Lists if the players can exit east, south, west or north.

            //Location 1 exits
            l1.addExit(new Exit(Exit.Directions.East, l2));

            //Location 2 exits
            l2.addExit(new Exit(Exit.Directions.North, l4));
            l2.addExit(new Exit(Exit.Directions.East, l3));

            //Location 3 exits
            l3.addExit(new Exit(Exit.Directions.West, l2));
            l3.addExit(new Exit(Exit.Directions.South, l5));
            //Location 3b exits
            l3b.addExit(new Exit(Exit.Directions.West, l2));
            l3b.addExit(new Exit(Exit.Directions.South, l5));
            //Location 4 exits
            l4.addExit(new Exit(Exit.Directions.South, l2));

            //Location 5 exits
            l5.addExit(new Exit(Exit.Directions.West, l6));
            l5.addExit(new Exit(Exit.Directions.South, l7));
            l5.addExit(new Exit(Exit.Directions.East, l8));
            l5.addExit(new Exit(Exit.Directions.North, l3));
            //Location 6 exits
            l6.addExit(new Exit(Exit.Directions.East, l5));
            //Location 7 exits
            l7.addExit(new Exit(Exit.Directions.North, l5));
            l7b.addExit(new Exit(Exit.Directions.North, l5));
            l7c.addExit(new Exit(Exit.Directions.North, l5b));
            //Location 8 exits
            l8.addExit(new Exit(Exit.Directions.West, l5));
            l8b.addExit(new Exit(Exit.Directions.West, l5));
            l8c.addExit(new Exit(Exit.Directions.West, l5));
            l8.addExit(new Exit(Exit.Directions.SouthWest, l7));
            l8b.addExit(new Exit(Exit.Directions.SouthWest, l7));
            l8c.addExit(new Exit(Exit.Directions.SouthWest, l7));
            l8d.addExit(new Exit(Exit.Directions.SouthWest, l7b));
            currentLocation = l1;
            showLocation();
        }


        //Inputs/ commands throughout the game
        public void doAction(string Command)
        {

            //Commands are put into strings
            // input [0] = first input made by the player. i.e. take input [1] = the other input i.e. key

            String[] input = Command.Split(default(String[]), StringSplitOptions.RemoveEmptyEntries);
            //Help screen for the player. Player can input help which will display the commands used in game and instructions. 
            
            #region help input data
            if (input.Length > 0)
            {
                if (input[0] == "help")
                {
                    Console.Clear();
                    Console.WriteLine(@"Instructions
 _________
 PRESS ENTER AFTER EACH COMMAND.
 take: input take followed by item name
 examine: examine with item name
 help: display help screen help
 Directions: north, east, south, west, southwest, southeast 
 OR n, e, s, w, sw, se.
 combine: input combine followed by both item names
 Inventory: i, inv or Inventory
 Quit: q or Quit 
 Use: Input use followed by item name

 Press any key to return!");
                    Console.ReadLine();
                    Console.Clear();
                    showLocation();
                    return;
                }
            }
            #endregion

            #region Inventory data    
            //Displays the players inventory if they input the following commands
            if (input.Length > 0)
            {
                if (input[0] == "inventory" || input[0] == "inv" || input[0] == "i")
                {
                   ShowInventory();
                    return;
                }
            }
            #endregion

            #region Location input data
            //The player will change rooms when inputted. Once done, the next location will state what direction they moved in.
            foreach (Exit exit in currentLocation.getExits())
            {
                if (input.Length > 0)
                {
                    if (input[0] == exit.ToString().ToLower() || input[0] == exit.ToString().ToLower().Remove(1, exit.ToString().Length - 1))
                    {
                        currentLocation = exit.getLeadsTo();
                        Console.Clear();
                        showLocation();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nYou moved " + exit + "\n");

                        return;
                    }
                }
            }
            #endregion
            //Allows the player to add the item into the inventory system.

            if (input.Length > 1)
            {
                if (input[0] == "take")
                {
                    for (int i = 0; i < currentLocation.getInventory().Count; i++)
                    {
                        if (currentLocation.getInventory()[i].name == input[1])
                        {
                            Item result = currentLocation.takeItem(input[1]);
                            InventorySystem.AddItem(result);
                            Console.Clear();
                            showLocation();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            if (result != null)
                                
                                Console.WriteLine("\nYou have obtained " + input[1] + "");
                            else
                                Console.WriteLine("Item not valid");

                            return;
                        }
                    }
                }
            }
            //Allows the player to access the inventorys items and show the descriptions of the input item.
            if (input.Length > 1)
            {
                if (input[0] == "examine") //the examine command is to allow players to display the description any time and anywhere.
                {
                    string desc = InventorySystem.GetDesc(input[1]); //Input 1 is the item name i.e. net, or paper.
                    Console.Clear();
                    showLocation();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n" + desc); //Places the description on a new line to not confuse the player.
                    return;
                }
            }

            //Use input in game
            if (input.Length > 1)
            {
                if (input[0] == "use") //Use input followed by leafblower allows player to find the shovel
                {
                    Item Itemname = null;
                    foreach (Item item in InventorySystem.getPlayerInventory())
                    {
                        if (input[1] == item.name)
                        {
                            Itemname = item;
                            break;
                        }
                    }
                    if (Itemname != null)
                    {

                        if (Itemname.name == "leafblower" && currentLocation.ToString() == "Front Garden") //Using the leafblower will load the "clean front garden" area
                        {
                            //Using an item will unlock/ spawn a new exit in that current location.
                            currentLocation = l3b; //Loads the new location with description to show the player the new area.
                            InventorySystem.RemoveItem(Itemname);
                            Item shovel = new Item();
                            shovel.name = "shovel";
                            shovel.desc = "Used for digging holes";

                            Console.Clear();
                            showLocation();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Using the blower scatters some leaves and reveals a shovel underneath.");
                            return;
                        }
                        else if (Itemname.name == "shovel" && currentLocation.ToString() == "Local Park")
                        {
                            currentLocation = l8b;
                            InventorySystem.RemoveItem(Itemname);

                            Console.Clear();
                            showLocation();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You used the shovel creating a large hole");
                            Console.WriteLine("Covering this up with a net might make do for a decent trap.");
                            return;
                        }
                        else if (Itemname.name == "net" && currentLocation.ToString() == "Dug up Local Park")
                        {
                            currentLocation = l8c;
                            InventorySystem.RemoveItem(Itemname);

                            Console.Clear();
                            showLocation();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You placed the net over the hole\neven for a stupid hero they will notice this.\nI need a disguise for this trap.");
                            return;
                        }
                        else if (Itemname.name == "leaves" && currentLocation.ToString() == "Trap within Local Park")
                        {
                            currentLocation = l8d;
                            InventorySystem.RemoveItem(Itemname);

                            Console.Clear();
                            showLocation();
                            Console.ForegroundColor = ConsoleColor.Red;
                            return;
                        }
                        else if (Itemname.name == "poisonapple" && currentLocation.ToString() == "The Fountain with the Hero")
                        {
                            currentLocation = l7c;
                            InventorySystem.RemoveItem(Itemname);

                            Console.Clear();
                            showLocation();
                            Console.ForegroundColor = ConsoleColor.Red;
                            return;

                            Console.Clear();
                            showLocation();
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.WriteLine("You cannot use that item here.");

                            return;
                        }
                    }
                }
            }
            //Combining two items together to form a new item.
            if (input.Length > 2)
            {
                if (input[0] == "combine") //This input allows the player to combine two items together
                {
                    Item StandardApple = null;
                    Item DangerousPoison = null;

                    foreach (Item item in InventorySystem.getPlayerInventory()) //Searches the inventory for the items inputted by the player.
                    {
                        if (input[1] == item.name)
                        {
                            StandardApple = item; //Apple name
                        }

                        if (input[2] == item.name)
                        {
                            DangerousPoison = item; //Poison name
                        }
                    }
                    if (StandardApple.name == "apple" && DangerousPoison.name == "poison") //Makes players input the item names to craft a new object.
                    {
                        InventorySystem.RemoveItem(StandardApple);
                        InventorySystem.RemoveItem(DangerousPoison); //Removes items from the inventory.

                        Item PoisonApple = new Item();
                        PoisonApple.name = "poisonapple";
                        PoisonApple.desc = "I wouldn't eat this. But a certain hero might."; //Crafted a new item with a new description

                        InventorySystem.AddItem(PoisonApple); //Adds newly crafted item into inventory.
                        Console.Clear();
                        showLocation();
                        Console.WriteLine("\nYou pour some poison into the apple core.\nCreating a poisonous apple!"); //Description displayed to allow player to know what has been achieved.
                        return;
                    }
                    else
                    {
                        Console.Clear();
                        showLocation();
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("You cannot combine these items together\n Try something else.");
                        return;
                    }
                }
            }
        }


            //Shows the players location, location description.
            public void showLocation()
        {
            Console.WriteLine("\n" + currentLocation.getTitle() + "\n");
            Console.WriteLine(currentLocation.getDescription());
       
            //Shows the available exits for the player to take.
            
            Console.WriteLine("\nAvailable Exits: \n");
          

            foreach (Exit exit in currentLocation.getExits())
            {
                Console.WriteLine(exit.getDirection());
            }
            
            Console.WriteLine();

            /// <summary>
            /// Contains the location item and item description. 
            /// </summary>          
            if (currentLocation.getInventory().Count > 0)
            {
                Console.WriteLine("\nThe room contains the following:\n");

                for (int i = 0; i < currentLocation.getInventory().Count; i++)
                {
                    Console.WriteLine(currentLocation.getInventory()[i].name);
                }

            }
    
        }

        /// <summary>
        /// Shows the player their current inventory.
        /// </summary>      
		private void ShowInventory()
		{
			if (InventorySystem.getPlayerInventory().Count > 0)
			{
				Console.WriteLine("\nYou look into your bag to reveal:\n");

				foreach ( Item item in InventorySystem.getPlayerInventory())
				{
                    Console.WriteLine(item.name);
				}
			}
            
         //Tells the player they don't have any items in their bag.
            else
            {
				Console.WriteLine("Nothing is in your bag.");
			}



        }

        //Allows player to input quit or q to quit the game.

		public void Update()
		{
			string currentCommand = Console.ReadLine().ToLower();

			// instantly check for a quit
			if (currentCommand == "quit" || currentCommand == "q")
			{
				isRunning = false;
				return;
			}

            // otherwise, process commands.
            if(currentCommand != " ")
            doAction(currentCommand);

            Console.ForegroundColor = ConsoleColor.Gray;
		}
	}
}
