using SwinAdventureProg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SwinAdventureProg
{
    public class TransferCommand : Command
    {
        public TransferCommand() : base(new string[] { "take", "put", "pickup", "drop" })
            {
            }

        public override string Execute(Player p, string[] text)
        {
            string itemID;
            Item item = null;
            string cmd = string.Empty;
            IHaveInventory container1;
            Tuple<IHaveInventory, IHaveInventory> container;

            if (text.Length == 1)
            {
                return $"What do you want to {text[0]}?";
            }

            cmd = text[0];
            itemID = text[1];
            if (text.Length == 2)
            {
                //returns tuple where 'Item1' is the source container, and 'Item2' is the destination
                container = FindSource(p.Location, p, cmd);
                item = RetrieveItem(itemID, container.Item1) as Item;
            }
            else if (text.Length == 4)
            {
                if (text[2] != "in" && text[2] != "from")
                {
                    return $"What do you want to {text[0]}?";
                }

                container1 = FetchContainer(p, text[3]);
                container = FindSource(container1, p, cmd);
                if (container.Item1 != null)
                {
                    item = RetrieveItem(itemID, container.Item1) as Item;

                }
                else
                {
                    return ($"I cannot find the {text[3]}");
                }
            }
            else
            {
                return $"I don't know how to {text[0]} that";
            }

            if (item != null && container.Item2 != null)
            {
                Item takenItem = container.Item1.Inventory.Take(text[1]);
                container.Item2.Inventory.Put(takenItem);
                if (cmd == "take" || cmd == "pickup")
                {
                    return $"You have taken {item.Name} from {container.Item1.Name}";
                }
                else if (cmd == "put" || cmd == "drop")
                {
                    return $"You have put {item.Name} in {container.Item2.Name}";
                }
                else
                {
                    return "invalid command.";
                }
            }
            else
            {
                return ($"I cannot find {itemID} in {container.Item1.Name}");
            }

        }

        public IHaveInventory FetchContainer(Player p, string containerID)
        {
            GameObject obj = p.Locate(containerID);
            IHaveInventory container = obj as IHaveInventory;
            return container;
        }

        public Tuple<IHaveInventory, IHaveInventory> FindSource(IHaveInventory container, Player plyr, string cmmd)
        {
            IHaveInventory source;
            IHaveInventory dest;
            if (cmmd == "take" || cmmd == "pickup")
            {
                source = container;
                dest = plyr;
            }
            else
            {
                source = plyr;
                dest = container;
            }
            return Tuple.Create(source, dest);
        }

        public GameObject RetrieveItem(string thingId, IHaveInventory container)
        {
           
            GameObject item = container.Locate(thingId);
            if (item == null)
            {
                return null;
            }

            return item;
        }
    }
}



