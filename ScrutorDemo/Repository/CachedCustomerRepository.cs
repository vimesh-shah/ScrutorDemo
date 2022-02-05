using ScrutorDemo.Models;

namespace ScrutorDemo.Repository;

public class CachedCustomerRepository : ICustomerRepository
{
    private readonly ICustomerRepository _customerRepository;

    private readonly Dictionary<int, Customer?> _customers = new();

    public CachedCustomerRepository(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<Customer?> GetCustomer(int customerId)
    {
        if (_customers.ContainsKey(customerId))
        {
            return await Task.FromResult<Customer?>(_customers[customerId]);
        }

        var customer = await _customerRepository.GetCustomer(customerId);

        _customers.Add(customerId, customer);

        return await Task.FromResult<Customer?>(customer);
    }
}