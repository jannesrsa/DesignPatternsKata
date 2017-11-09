using System.Linq;

namespace DesignPatternsKata.Command
{
    public class AddTextCommand : BaseCommand
    {
        public override void Execute(string text)
        {
            Sb.Append(text);
            Entries.Add(text);
        }

        public override void UnExecute()
        {
            if (!Entries.Any())
            {
                return;
            }

            var lastEntry = Entries.Last();

            Sb.Remove(Sb.Length - lastEntry.Length, lastEntry.Length);

            Entries.Remove(lastEntry);
        }
    }
}