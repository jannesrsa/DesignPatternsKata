using System.Diagnostics.CodeAnalysis;

namespace DesignPatternsKata.Behavioral
{
    [ExcludeFromCodeCoverage]
    public class Pizza : IPizza
    {
        public string Name
        {
            get { return "Regina"; }
        }
    }
}