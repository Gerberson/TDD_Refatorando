using Domain.Repositories;

namespace Tests.Repositories
{
    public class FakeDeliveryRepository : IDeliveryFeeRepository
    {
        public decimal Get(string zipCode)
        {
            return 10;
        }
    }
}