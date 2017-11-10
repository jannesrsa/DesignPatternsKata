using System.Collections.Generic;

namespace DesignPatternsKata.Behavioral
{
    public interface IOrder
    {
        string Status { get; }

        IEnumerable<IPizza> Pizzas { get; }

        string Type { get; }
    }
}