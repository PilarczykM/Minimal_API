using MinimalApi.Models;

namespace MinimalApi.Repositories
{
    internal class CustomerRepository : ICustomerRepository
    {
        private readonly Dictionary<Guid, Customer> _customers = new();

        public void Create(Customer? customer)
        {
            if (customer is null)
            {
                return;
            }

            _customers[customer.Id] = customer;
        }

        public Customer? GetById(Guid Id)
        {
            return _customers.GetValueOrDefault(Id);
        }

        public List<Customer> GetAll()
        {
            return _customers.Values.ToList();
        }

        public void Update(Customer customer)
        {
            var existringCustomer = GetById(customer.Id);
            if (existringCustomer != null)
            {
                return;
            }

            _customers[customer.Id] = customer;
        }

        public void Delete(Guid id)
        {
            _customers.Remove(id);
        }
    }
}
