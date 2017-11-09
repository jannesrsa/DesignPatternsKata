using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsKata.Command.Channel9
{
    public class Controller
    {
        private List<IAppCommand> CommandList { get; } = new List<IAppCommand>();

        public Controller()
        {
        }

        public IAppCommand AddCommand(IAppCommand command)
        {
            CommandList.Add(command);
            return CommandList.Last();
        }

        public string GetBuiltString()
        {
            var command = CommandList.Last();
            return command.Sb.ToString();
        }

        public IAppCommand GetCommandAt(IAppCommand addCommandReference)
        {
            var index = CommandList.IndexOf(addCommandReference);
            return CommandList[index];
        }
    }
}