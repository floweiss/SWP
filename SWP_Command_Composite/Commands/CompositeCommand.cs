using System;
using System.Collections.Generic;
using System.Text;

namespace SWP_Command_Composite.Commands
{
    public abstract class CompositeCommand : ICommand
    {
        protected List<ICommand> _commands;
        protected PointReceiver _pointReceiver;

        protected CompositeCommand(PointReceiver pointReceiver)
        {
            _commands = new List<ICommand>();
            _pointReceiver = pointReceiver;
        }

        public void AddCommand(ICommand addedCommand)
        {
            _commands.Add(addedCommand);
        }

        public void RemoveCommand(ICommand removedCommand)
        {
            _commands.Remove(removedCommand);
        }

        public virtual void Execute()
        {
            _commands.ForEach(command => command.Execute());
        }
    }
}
