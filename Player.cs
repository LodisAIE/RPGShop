using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        private int _gold;
        private Item[] _inventory;

        public Player()
        {
            _gold = 100;
            //Creates a new item array with three items with default values
            _inventory = new Item[3];
        }

        public bool Buy(Item item, int inventoryIndex)
        {
            //Check to see if the player can afford the item
            if(_gold >= item.cost)
            {
                //Pay for item.
                _gold -= item.cost;
                //Place item in inventory array.
                _inventory[inventoryIndex] = item;
                return true;
            }

            return false;
        }

        public int GetGold()
        {
            return _gold;
        }

        public Item[] GetInventory()
        {
            return _inventory;
        }
    }
}
