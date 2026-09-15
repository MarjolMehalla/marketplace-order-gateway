using MarketplaceOrderGateway.Domain.Entities;

namespace MarketplaceOrderGateway.Application.Orders.Ports
{
    public interface IOrderRepository
    {
        Task AddOrder(Order order, CancellationToken cancellationToken);
    }
}
