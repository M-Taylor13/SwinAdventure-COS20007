using System;

namespace SwinAdventureProg
{
    public class Bag : Item, IHaveInventory
    {
        private Inventory _inventory;

        public Bag(string[] ids, string name, string desc) : base(ids, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {

            if (AreYou(id)) //returns bag info 
            {
                return this;
            }
            // if we are looking in this bag
            return _inventory.Fetch(id);

        }

        public override string FullDescription 
        {
            get
            {
                return ($"In the {FirstId()} you can see:\n{_inventory.ItemList}");
            }
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }
    }
}
