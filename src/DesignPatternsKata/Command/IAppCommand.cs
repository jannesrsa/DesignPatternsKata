using System.Text;

namespace DesignPatternsKata.Command
{
    public interface IAppCommand
    {
        StringBuilder Sb { get; }

        void Execute(string text);

        void UnExecute();
    }
}