using ScrutorDemo.Models;

namespace ScrutorDemo.Repository;

public class CustomerRepository : ICustomerRepository
{
    private List<Customer> _customerList = new List<Customer>
    {
        new Customer
        {
            Id = 1,
            Name = "Vimesh Shah",
            Age = 28
        },
        new Customer
        {
            Id = 2,
            Name = "Disha Shah",
            Age = 28
        }
    };
    
    public async Task<Customer?> GetCustomer(int customerId)
    {
        return await Task.FromResult(_customerList.SingleOrDefault(x => x.Id == customerId));
    }
}