using SwinAdventureProg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class CommandProcessor : Command
    {
        private List<Command> _commandTypes;
        public CommandProcessor() : base(new string[] {})
        {
            _commandTypes = new List<Command>();
            _commandTypes.Add(new LookCommand());
            _commandTypes.Add(new MoveCommand());
            _commandTypes.Add(new TransferCommand());
        }

        public override string Execute(Player p, string[] txt)
        {
            foreach (Command cmd in _commandTypes)
            {
                if (cmd.AreYou(txt[0]))
                {
                    return cmd.Execute(p, txt);
                }
                
            }

            return "Command not found";
        }
    }
}
