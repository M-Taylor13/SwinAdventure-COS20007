using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventureProg
{
    public class MoveCommand : Command
    {
        public MoveCommand() : base(new string[] { "move", "go", "head", "leave" })
        {
        }



        public override string Execute(Player p, string[] text)
        {

            if (text.Length <= 1)
            {
                return "Where do you want to move?";
            }

            if (text.Length > 2)
            {
                return "Invalid Move Command";
            }
            string cmdDirection = text[1];
            GameObject pathId = p.Location.Locate(cmdDirection);
            if (pathId != null && pathId != p.Location)
            {
                Path path = pathId as Path;
                p.Move(path);
                return $"{path.FullDescription}\nYou have arrived in {p.Location.Name}";

            }
            return $"Direction {cmdDirection} does not exist";
        }
    }
}
