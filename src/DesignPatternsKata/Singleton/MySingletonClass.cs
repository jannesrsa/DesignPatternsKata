namespace DesignPatternsKata.Singleton
{
    public class MySingletonClass
    {
        public static MySingletonClass Instance { get; } = new MySingletonClass();

        public int SomeValue { get; set; }

        private MySingletonClass()
        {
        }
    }
}