using System;

namespace SwinAdventureProg
{
    public class Player : GameObject, IHaveInventory
    {
        private Inventory _inventory;
        private Location _location;

        public Player(string name, string desc) : base(new string[] {"me", "inventory"}, name, desc)
        {
            _inventory = new Inventory();
            _location = new Location("start", "the starting place");
        }

        public GameObject Locate(string id)
        {
            
            if (AreYou(id)) //returns player info 
            {
                return this;
            }
            // if we are not locating ourself (player)
            if (_inventory.Fetch(id) != null)
            {
                return _inventory.Fetch(id);
            }
            return _location.Locate(id);

        }

        public void Move(Path nextPath)
        {
            Location = nextPath.Destination;

        }

        public override string FullDescription
        {
            get
            {
                return ("You are carrying:\n" + _inventory.ItemList);
            }
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }

        public Location Location
        {
            get
            {
                return _location;
            }
            set
            {
                _location = value;
            }
        }
    }

}
