using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{    
	class Item
	{
        public string name = " "; //The items name
        public string desc = " "; //The items description
        private List<Item> playerInventory; //The players inventory
        public Location UsableLocation;

		public Item()
		{
            playerInventory = new List<Item>();
		}

        public override string ToString()
        {
            return name;
        }

        //Returns items into players inventory
        public List<Item> getPlayerInventory()
        {
            return new List<Item>(playerInventory);
        }

        //Adds an item into the players inventory system
        public void AddItem(Item item)
        {
            playerInventory.Add(item);
        }

        //Removes the item from the players inventory system
        public void RemoveItem(Item item)
        {
            playerInventory.Remove(item);
        }

        //Obtains the items description and shows it. 
        public String GetDesc(String item)
        {
            foreach (Item items in playerInventory)
            {
                if (items.name == item)
                {
                    string desc = items.desc;
                    return desc;
                }
            }
        //States to the user that the item is not currently in their inventory.
            return "You do not hold this item";
        }
    }
}
