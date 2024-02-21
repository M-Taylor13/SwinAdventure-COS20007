
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SwinAdventureProg
{
    public class Path : GameObject
    {
        Location _destination;
        public Path(string[] idents, string name, string desc, Location destLocation) : base(idents, name, desc)
        {
            _destination = destLocation;

        }


        public Location Destination
        {
            get
            {
                return _destination; 
            }
            set
            {
                _destination = value;
            }
        }

        public override string FullDescription
        {
            get
            {
                return $"You head {FirstId()}\nYou go through {Name}";
            }
        }

    }
}
