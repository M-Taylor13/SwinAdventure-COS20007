using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace SwinAdventureProg
{
    public class Location : GameObject, IHaveInventory
    {
        private Inventory _inventory;
        private List<Path> _paths;

        public Location(string name, string desc) : base(new string[] { "room", "here" }, name, desc)
        {
            _inventory = new Inventory();
            _paths = new List<Path>();
        }

        public Location(List<Path> paths, string name, string desc) : this(name, desc)
        {
            _paths = paths;
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id)) //returns location info 
            {
                return this;
            }
            foreach (Path path in _paths)
            {
                if (path.AreYou(id)) // checks for path match to id given
                {
                    return path;
                }
            }
           
            return _inventory.Fetch(id); //finally checks inventory for id 
        }

        public void AddPath(Path path)
        {
            _paths.Add(path);

        }

        public override string FullDescription
        {
            get
            {
            
                return $"\nYou are in {Name}\n{base.FullDescription}\nIn this room you can see:\n{Inventory.ItemList}";
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
