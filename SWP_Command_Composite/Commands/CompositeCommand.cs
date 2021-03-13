using System;
using System.Collections.Generic;
using System.Text;

namespace SWP_Command_Composite.Commands
{
    public abstract class CompositeCommand
    {
        protected List<ICommand> _commands = new List<ICommand>();

        public void AddCommand(ICommand addedCommand)
        {
            _commands.Add(addedCommand);
        }

        public void RemoveCommand(ICommand removedCommand)
        {
            _commands.Remove(removedCommand);
        }
    }
}
