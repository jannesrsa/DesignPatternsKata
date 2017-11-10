using System.Diagnostics.CodeAnalysis;

namespace DesignPatternsKata.Behavioral
{
    [ExcludeFromCodeCoverage]
    public class PhoneOrder : BaseOrder
    {
        public string PhoneNumber { get; }

        public PhoneOrder(string phoneNumber)
            : base("Phone")
        {
            PhoneNumber = phoneNumber;
        }
    }
}