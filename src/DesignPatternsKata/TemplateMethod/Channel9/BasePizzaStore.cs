using System.Collections.Generic;

namespace DesignPatternsKata.TemplateMethod.Channel9
{
    public abstract class BasePizzaStore
    {
        public Pizza PizzaForDelivery { get; protected set; }

        public List<string> Status { get; } = new List<string>();

        public void CreatePizzaForDelivery(string name)
        {
            TakeOrder();
            ProcessPayment();
            PizzaForDelivery = MakePizza(name);
            DeliverPizza();
        }

        internal void TakeOrder()
        {
            Status.Add("TakeOrder");
        }

        public abstract Pizza MakePizza(string name);

        public void DeliverPizza()
        {
            Status.Add("DeliverPizza");
        }

        internal void ProcessPayment()
        {
            Status.Add("ProcessPayment");
        }
    }
}