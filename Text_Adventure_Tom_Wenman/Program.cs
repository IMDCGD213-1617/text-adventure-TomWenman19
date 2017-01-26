using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_Tom_Wenman
{
    class Program
    {
        static void Main(string[] args)
        {
            int CorrectInput = 0;
            int ArrayCount = 0;

            //User input strings
            string[] Inventory = new string[5];
            string Input; // Used to determine if what the player writes is a correct command or not.
            string search; //Used in every area of the game to find objects, clues and enemies.

            //Combat based strings
            string Fight;
            string slash; //Used for out of combat situations and in combat situations. Some enemies may be weak to slash attacks.
            string Crush;

            //Directions for the player to move in
            string west;
            string North;
            string East;
            string South;



            //Introduction
            do
            { Input = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\n While stumbling through a forest you come across");
                Console.WriteLine("\n an old temple. Outside of the temple has many bodies");
                Console.WriteLine("\n hanging from trees and bodies splattered on spikes.");
                Console.WriteLine("\n Venturing in will take courage and preparation.");
                Console.WriteLine("\n But first, investigating the scene may come of use.");
                search = Console.ReadLine().ToLower();
                if (Input == "search")
                {
                    CorrectInput = 1;
                }
                else { }
            } while (CorrectInput == 0);
            CorrectInput = 0;

            //Finding the bag with items inside
            do
            {
                Input = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\n Within the grasp of the skeleton, you find a bag with food and a knife.");
                Console.WriteLine("\n The bag has several spaces to hold future objects.");
                Console.WriteLine("\n Next to the body you notice a glowing purple gem laying in a scaffolding of cobwebs.");
                Console.WriteLine("\n The knife you found may be of use for slashing the webs.");
                slash = Console.ReadLine().ToLower();
                if (Input == "slash")
                {
                    CorrectInput = 1;
                }
                else { }
            } while (CorrectInput == 0);
            CorrectInput = 0;

            //Obtaining the gem and choosing the tunnel direction   
            do
            {
                Input = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("\n You obtain the gem and place it in your bag");
                Console.WriteLine("\n As the gem has a light source of its own, it will allow you now to walk into the temple.");
                Console.WriteLine("\n You step into the temple. With the gem in your hand it guides you to a intersection.");
                Console.WriteLine("\n A path going west, north and east. Or the cowards way out, south.");
                Console.WriteLine("\n Which path would you like to take?");
                west = Console.ReadLine().ToLower();
                if (Input == "west")
                {
                   
                    CorrectInput = 1;
                }
                else { }
                } while (CorrectInput == 0);
                CorrectInput = 0;

                Console.Clear();
                Console.WriteLine("\n You start to hear squeaks getting louder and louder while you proceed.");
                Console.WriteLine("\n Foul smells start to fester in the hallway and the squeaks echo louder.");
                Console.WriteLine("\n Are you sure you wish to proceed further?");

            if (Input == "yes")
                        Console.WriteLine("\n A giant rat appears to dislike your presence.");
                    if (Input == "no")
                        Console.WriteLine("\n A path going west, north and east. Or the cowards way out, south.");
                        Console.WriteLine("\n Which path would you like to take?");

            //Inventory system
            Inventory[0] = "Knife"; Inventory[1] = "Herb"; Inventory[2] = "Key";
            Console.Clear();
            if (Input == "Inventory")
            {
                Console.Clear();
                Console.WriteLine("Your bag contains:");
                for (ArrayCount = 0; ArrayCount < 5; ArrayCount++) //Used an array of 5 to determine how much space the bag has. A max value of 5 is given.
                {
                    Console.SetCursorPosition(0, ArrayCount);
                    Console.WriteLine("{0}", Inventory[ArrayCount]);
                }
            }
            else
            {

            }
            Console.ReadLine();
        }
            }
            }
   

         
