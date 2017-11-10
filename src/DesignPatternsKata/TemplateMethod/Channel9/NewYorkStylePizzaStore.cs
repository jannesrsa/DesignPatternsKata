namespace DesignPatternsKata.TemplateMethod.Channel9
{
    public class NewYorkStylePizzaStore : BasePizzaStore
    {
        public override Pizza MakePizza(string name)
        {
            return new Pizza("New York: " + name);
        }
    }
}