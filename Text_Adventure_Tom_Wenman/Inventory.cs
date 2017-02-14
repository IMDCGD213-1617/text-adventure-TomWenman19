using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Text_Adventure_Tom_Wenman
{
    static void Main(string[] args)
    {
        string Input;
        int ArrayCount = 0;
        string[] Inventory = new string[5];

        //Inventory system
        Inventory[0] = "Knife"; Inventory[1] = "Herb"; Inventory[2] = "Key";
        Input = Console.ReadLine();
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
   
