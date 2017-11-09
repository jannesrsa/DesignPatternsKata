using System.Linq;

namespace DesignPatternsKata.Command.Channel9
{
    public class AddNumbersCommand : BaseCommand
    {
        public override void Execute(string value)
        {
            Sb.Append(value);
            Entries.Add(value);
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