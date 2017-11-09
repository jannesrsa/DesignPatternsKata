namespace DesignPatternsKata.Strategy.Wikipedia
{
    //The interface for the strategies
    public interface ICalculate
    {
        int Calculate(int value1, int value2);
    }
}