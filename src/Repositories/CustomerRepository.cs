
namespace MinimalApi;

internal class CustomerRepository : ICustomerRepository
{
    private readonly Dictionary<Guid, Customer> _customers = [];
    public void Create(Customer? customer)
    {
        if (customer is null)
        {
            return;
        }

        _customers[customer.Id] = customer;
    }

    public void Delete(Guid id)
    {
        _customers.Remove(id);
    }

    public List<Customer> GetAll()
    {
        return [.. _customers.Values];
    }

    public Customer? GetById(Guid Id)
    {
        return _customers.GetValueOrDefault(Id);
    }

    public void Update(Customer customer)
    {
        var existingCustomer = GetById(customer.Id);
        if (existingCustomer != null)
        {
            return;
        }

        _customers[customer.Id] = customer;
    }
}
