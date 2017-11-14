namespace DesignPatternsKata.Facade.Channel9
{
    public class BetterAPI : IBetterAPI
    {
        private readonly IConfusing _confusing = new Confussing();
        private readonly IOverdone _overdone = new Overdone();

        public BetterAPI()
        {
        }

        public int AddThenMultiple(params int[] values)
        {
            return _confusing.Method1(values);
        }

        public int AddThreeNumbers(int value1, int value2, int value3)
        {
            var returnVal = _overdone.Something(value1, value2);
            return _overdone.Something(returnVal, value3);
        }
    }
}