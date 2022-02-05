using Microsoft.AspNetCore.Mvc;
using ScrutorDemo.Models;
using ScrutorDemo.Repository;

namespace ScrutorDemo.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerRepository _customerRepository;
    
    public CustomerController(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetCustomer(int customerId, CancellationToken cancellationToken)
    {
        var customer = await _customerRepository.GetCustomer(customerId);
        return Ok(customer);
    }
}