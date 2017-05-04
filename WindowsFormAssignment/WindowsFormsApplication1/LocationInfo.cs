using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class LocationInfo
    {
        private string LocationName; 
        private string LocationDescription;
        private string LocationItems;
        private string LocationItemsDesc;
        private string LocationExits;


        public string locationName //This string allows the input information to be then set as the value
        {                  
            get { return LocationName; } 
            set { LocationName = value; }
        }

        public string locationDescription
        {
            get { return LocationDescription; }
            set { LocationDescription = value; }
        }
        public string locationItems
        {
            get { return LocationItems; }
            set { LocationItems = value; }
        }
        public string locationItemsDesc
        {
            get { return LocationItemsDesc; }
            set { LocationItemsDesc = value; }
        }
            public string locationExits
        {
            get { return LocationExits; }
            set { LocationExits = value; }
        }
    }
}
