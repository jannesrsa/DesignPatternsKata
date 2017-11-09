using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsKata.Memento
{
    public class ChangeCustomerCommand
    {
        private readonly List<MementoForCustomerEntity> _mementos = new List<MementoForCustomerEntity>();

        public ChangeCustomerCommand(Customer customer)
        {
            Customer = customer;
        }

        public Customer Customer { get; private set; }

        public void Execute(string newName)
        {
            _mementos.Add(new MementoForCustomerEntity(Customer));
            Customer.Name = newName;
        }

        public void UnExecute()
        {
            if (!_mementos.Any())
            {
                return;
            }

            var last = _mementos.Last();
            Customer = last.GetCustomer();
            _mementos.Remove(last);
        }
    }
}