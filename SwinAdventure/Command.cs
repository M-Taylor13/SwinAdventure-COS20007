using System;
using System.Collections.Generic;
using System.Linq;

namespace SwinAdventureProg
{
    public abstract class Command : IdentifiableObject
    {
        public Command(string[] ids) : base(ids)
        {
        }

        public abstract string Execute(Player p, string[] text);
    }
}
