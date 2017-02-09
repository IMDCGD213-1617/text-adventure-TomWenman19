using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Game
    {
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
        Location l4;
        Location l5;
        Location l6;
        Location l7;
        Location l8;
        Location l9;

        public Game()
        {
            inventory = new List<Item>();
            InventorySystem = new Item();

            Console.WriteLine("As a super villain, no-one is taking you serious anymore. \nThe only way to gain");

            // Building the University map with various locations and items
            //Location 1
            Location l1 = new Location("The Entrance", "The students body is hanging off the ceiling. A computer mouse is found wrapped around their neck.\n\n A staircase is located to the east.");
            Item mouse = new Item();
            mouse.name = "mouse";
            mouse.desc = "A computer mouse. Can be plugged in somewhere with the USB connector.";
            l1.addItem(mouse);

            //Location 2
            Location l2 = new Location("Staircase", "The stairs display muddy footprints.\n Whomever was at the scene must still have mud underneath their shoes.\nA rubber duck is by a step.\nThe trail leads up the stairs and stops at a T junction");
            Item duck = new Item();
            duck.name = "duck";
            duck.desc = "A rubber duck. Why and who on earth would own this?";
            l2.addItem(duck);

            //Location 3
            Location l3 = new Location("Cupboard", "The cupboard is filled with mops and buckets. Nothing is of use here.");

            Location l4 = new Location("Long Corridor", "");
            Location l5 = new Location("Toilets", "");
            Location l6 = new Location("Lecturer Office", "");

            Location l7 = new Location("Labs", "");
            Item sign = new Item();
            sign.name = "sign";
            sign.desc = "A sign.";
            l7.addItem(sign);

            Location l8 = new Location("Common Room", "");
            // Exits for the locations. Lists if the players can exit east, south, west or north.

            //Location 1 exits
            l1.addExit(new Exit(Exit.Directions.East, l2));

            //Location 2 exits
            l2.addExit(new Exit(Exit.Directions.West, l4));
            l2.addExit(new Exit(Exit.Directions.East, l3));

            //Location 3 exits
            l3.addExit(new Exit(Exit.Directions.South, l1));
            //Location 4 exits

            //Location 5 exits

            //Location 6 exits

            //Location 7 exits
            l7.addExit(new Exit(Exit.Directions.West, l6));
            //Location 8 exits

            currentLocation = l1;
            showLocation();
        }


        //Inputs/ commands throughout the game
        public void doAction(string Command)
        {

            //Commands are put into strings
            String[] input = Command.Split(default(String[]), StringSplitOptions.RemoveEmptyEntries);

            //Displays the players inventory if they input the following commands
            if (input.Length > 0)
            {
                if (input[0] == "inventory" || input[0] == "inv" || input[0] == "i")
                {
                   ShowInventory();
                    return;
                }
            }

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
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\nYou moved " + exit + "\n");

                        return;
                    }
                }
            }

            //Allows the player to add the item into the inventory system.
            if (input.Length > 1)
            {
                if (input[0] == "add")
                {
                    for (int i = 0; i < currentLocation.getInventory().Count; i++)
                    {
                        if (currentLocation.getInventory()[i].name == input[1])
                        {
                            Item result = currentLocation.takeItem(input[1]);
                            InventorySystem.AddItem(result);
                            Console.Clear();
                            showLocation();
                            if (result != null)
                                Console.WriteLine("\nYou have collected " + input[1] + "!\n");
                            else
                                Console.WriteLine("Item not valid");

                            return;
                        }
                    }
                }
            }

            if (input.Length > 1)
            {
                if (input[0] == "look" || input[0] == "search" || input[0] == "examine")
                {
                    string desc = InventorySystem.GetDesc(input[1]);
                    Console.Clear();
                    showLocation();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("\n" + desc + "\n");
                    return;
                }
            }

            //Use input in game
            if (input.Length > 1)
            {
                if (input[0] == "use")
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

                        if (Itemname.name == "key" && currentLocation.ToString() == "Labs")
                        {
                            //Using an item will unlock/ spawn a new exit in that current location.
                            l7.addExit(new Exit(Exit.Directions.East, l8));
                            l7.addExit(new Exit(Exit.Directions.West, l9));
                            InventorySystem.RemoveItem(Itemname);

                            Console.Clear();
                            showLocation();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You try the key in the lock.");
                            Console.WriteLine("The key works and the door is unlocked.");
                            return;
                        }
                        Console.Clear();
                        showLocation();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You can't do that!");

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

            // Contains the location item and item description.    
            if (currentLocation.getInventory().Count > 0)
            {
                Console.WriteLine("\nThe room contains the following:\n");

                for (int i = 0; i < currentLocation.getInventory().Count; i++)
                {
                    Console.WriteLine(currentLocation.getInventory()[i].name);
                }
            }
        }

        //Shows the player their current inventory.
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
            //Shows the available exits for the player to take.
            Console.WriteLine("\nAvailable Exits: \n");

            foreach (Exit exit in currentLocation.getExits())
            {
                Console.WriteLine(exit.getDirection());
            }

            Console.WriteLine();
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
