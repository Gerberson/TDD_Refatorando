using Domain.Entities;

namespace Domain.Repositories
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(string document);
    }
}