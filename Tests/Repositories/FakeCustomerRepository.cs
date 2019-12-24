using Domain.Entities;
using Domain.Repositories;

namespace Tests.Repositories
{
    public class FakeCustomerRepository : ICustomerRepository
    {
        public Customer GetCustomer(string document)
        {
            if(document == "12345678911")
                return new Customer("Bruce Wayne", "bruce@balta.io");
            
            return null;
        }
    }
}