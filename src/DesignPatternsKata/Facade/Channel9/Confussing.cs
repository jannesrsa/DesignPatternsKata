namespace DesignPatternsKata.Facade.Channel9
{
    public class Confussing : IConfusing
    {
        public int Method1(params int[] values)
        {
            return values[0] * values[1];
        }
    }
}