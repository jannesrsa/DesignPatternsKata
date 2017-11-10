using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DesignPatternsKata.Behavioral
{
    [ExcludeFromCodeCoverage]
    public abstract class BaseOrder : IOrder
    {
        public string Status { get; set; }

        public IEnumerable<IPizza> Pizzas { get; } = new List<IPizza>();

        public string Type { get; }

        public BaseOrder(string type)
        {
            Type = type;
        }
    }
}