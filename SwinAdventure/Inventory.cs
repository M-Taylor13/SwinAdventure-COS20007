using System;
using System.Collections.Generic;

namespace SwinAdventureProg
{
    public class Inventory
    {
        private List<Item> _items;

        public Inventory()
        {
            _items = new List<Item>();
        }

        public bool HasItem(string id)
        {
            bool hasItem = false;
            Item itemCheck = Fetch(id);

            if (itemCheck != null)
            {
                hasItem = true;
            }

            return hasItem;
        }

        public void Put(Item item)
        {
            _items.Add(item);
        }

        public Item Take(string id)
        {
            Item itemTake = Fetch(id);
            _items.Remove(itemTake);
            return itemTake;
        }

        public Item Fetch(string id)
        {

            foreach (Item i in _items)
            {

                if (i.AreYou(id))
                {
                    return i;
                }
            }

            return null;
        }

        public string ItemList
        {
        get
        {
            string listItem;
            string totalInv = "";
                foreach (Item i in _items)
                {
                    listItem = "\t" + i.ShortDescription + "\n";
                    totalInv += listItem;
                }

                return totalInv;
            }

        }
    }
}
