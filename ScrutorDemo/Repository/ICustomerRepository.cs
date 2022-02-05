using ScrutorDemo.Models;

namespace ScrutorDemo.Repository;

public interface ICustomerRepository
{
   Task<Customer?> GetCustomer(int customerId);
}