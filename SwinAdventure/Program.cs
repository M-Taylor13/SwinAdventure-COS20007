using SwinAdventure;
using System;
using System.Diagnostics;
using System.Diagnostics.Eventing;
using System.Windows.Forms;

namespace SwinAdventureProg
{
    public partial class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            

            Debug.WriteLine("gay");
            //Player setup
            Console.WriteLine("What is the player's name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"What is {name}'s description: ");
            string desc = Console.ReadLine();
            Player player = new Player(name, desc);
            Console.WriteLine($"Welcome Player {player.Name}!");
            Console.WriteLine("SwinAdventure has begun! You may now enter game commands:");

            //Inventory/bag setup
            Item item1 = new Item(new string[] { "sword"}, "a rusty sword", "It's a heavily rusted sword, but better than nothing.");
            Item item2 = new Item(new string[] { "sandwich" }, "a sandwich", "A turkey sandwich, restores your health.");
            Item item3 = new Item(new string[] { "radio" }, "a radio", "A broken radio, you might be able to fix it.");
            Bag bag = new Bag(new string[] { "bag" }, "a bag", "a bag that holds things outside of player inventory.");
            player.Inventory.Put(item1);
            bag.Inventory.Put(item3);
            player.Inventory.Put(bag);
            Location loc = new Location("the kitchen", "A kitchen with a fridge.");
            loc.Inventory.Put(item2);
            player.Location = loc;
                       
            Location loc2 = new Location("the lounge room", "A lounge room with a couch.");
            Path northPath = new Path(new string[] { "north", "up" }, "a hallway", "You open a wooden door", loc2);
            loc.AddPath(northPath);

            //Command App Loop
            string cmd = "";
            while (cmd != "quit") // quit ends the game loop
            {
                Gui controlsGui = new Gui();
                Application.EnableVisualStyles();
                Application.Run(controlsGui);
                cmd = controlsGui.CmdOutput;
                Console.WriteLine(cmd);

                if ((!string.IsNullOrEmpty(cmd))!=(cmd=="quit")) // reads in input if it is not null/an empty string XOR the input is not 'quit'
                {
                    //converts to word array -- lenient about extra accidental spaces
                    string[] cmdArray = cmd.Trim().Split(new string[] { " ", "  ", "   " }, 
                        StringSplitOptions.RemoveEmptyEntries);
                    CommandProcessor executeCmd = new CommandProcessor();
                    string cmdResult = executeCmd.Execute(player, cmdArray);
                    Console.WriteLine(cmdResult); // executes and returns the result from the LookCommand object
                }
                else if(string.IsNullOrEmpty(cmd))
                {
                    Console.WriteLine("You must enter a command.");
                }

            }

            Console.WriteLine("Game Exited.");

        }
    }
}
