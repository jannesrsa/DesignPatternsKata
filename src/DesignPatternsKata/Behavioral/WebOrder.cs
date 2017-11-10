using System.Diagnostics.CodeAnalysis;

namespace DesignPatternsKata.Behavioral
{
    [ExcludeFromCodeCoverage]
    public class WebOrder : BaseOrder
    {
        public string EmailAddress { get; }

        public WebOrder(string emailAddress)
            : base("Web")
        {
            EmailAddress = emailAddress;
        }
    }
}