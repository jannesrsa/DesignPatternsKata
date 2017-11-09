using System.Text;

namespace DesignPatternsKata.Command.Channel9
{
    public interface IAppCommand
    {
        StringBuilder Sb { get; }

        void Execute(string text);

        void UnExecute();
    }
}