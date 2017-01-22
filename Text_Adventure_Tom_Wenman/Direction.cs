using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Adventure_Tom_Wenman
{
    struct Direction
    {
        public const string North = "north"; //Creates a constant value, cannot be altered.
        public const string South = "south";
        public const string East = "east";
        public const string West = "west";



        //Is Valid Direction()
        public static bool IsValidDirection()
        {
            return true;
        }

    }
}
