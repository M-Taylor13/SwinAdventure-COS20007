using System;
using System.Collections.Generic;
using System.Linq;

namespace SwinAdventureProg
{
    public class LookCommand : Command
    {
        public LookCommand() : base(new string[] {"look"})
        {
        }
        
        public override string Execute(Player p, string[] text)
        {
            string itemID;

            if (text[0] != "look")
            {
                return "Error in look input";
            }

            if (text.Length == 1)
            {
                return p.Location.FullDescription;
            }

            if (text[1] != "at" || text.Length == 2)
            {
                return "What do you want to look at?"; 
            }
            


            itemID = text[2];
            if (text.Length == 3)
            {
                return LookAtIn(itemID, p);
            }
            else if (text.Length == 5)
            {
                if (text[3] != "in")
                {
                    return "What do you want to look in?";
                }

                if (FetchContainer(p, text[4]) != null)
                {
                    return LookAtIn(itemID, FetchContainer(p, text[4]));
                   
                }

                return ($"I cannot find the {text[4]}");
            }
            else
            {
                return "I don't know how to look like that";
            }
        }

        public IHaveInventory FetchContainer(Player p, string containerID)
        {
            GameObject obj = p.Locate(containerID);
            IHaveInventory container = obj as IHaveInventory;
            return container;
        }

        public string LookAtIn(string thingId, IHaveInventory container)
        {
            GameObject item = container.Locate(thingId);
            if (item == null)
            {
                return ($"I cannot find {thingId} in {container.Name}");
            }

            return item.FullDescription;
        }
    }
}
