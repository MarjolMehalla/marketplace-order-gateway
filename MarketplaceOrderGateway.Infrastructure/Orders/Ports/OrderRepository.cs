using MarketplaceOrderGateway.Application.Orders.Ports;
using MarketplaceOrderGateway.Domain.Entities;

namespace MarketplaceOrderGateway.Infrastructure.Orders.Ports
{
    public class OrderRepository : IOrderRepository
    {
        public Task AddOrder(Order order, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
