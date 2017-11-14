namespace DesignPatternsKata.Facade.Channel9
{
    public interface IBetterAPI
    {
        int AddThreeNumbers(int value1, int value2, int value3);

        int AddThenMultiple(params int[] values);
    }
}