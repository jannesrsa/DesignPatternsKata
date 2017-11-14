namespace DesignPatternsKata.Decorator.Channel9
{
    public class BaseCar : ICar
    {
        public int Attack()
        {
            return 100;
        }

        public int Defend()
        {
            return 100;
        }

        public int Drive()
        {
            return 100;
        }
    }
}