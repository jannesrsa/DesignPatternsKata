namespace DesignPatternsKata.Memento
{
    public class MementoForCustomerEntity
    {
        private Customer _customer;

        public MementoForCustomerEntity(Customer customer)
        {
            this._customer = customer.Clone();
        }

        public Customer GetCustomer()
        {
            return _customer;
        }
    }
}