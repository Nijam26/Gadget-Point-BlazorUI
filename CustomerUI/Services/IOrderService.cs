using CustomerUI.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerUI.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAllOrders();
        Task<Order> GetOrderById(int orderId);
        Task CreateOrder(Order order);
        Task UpdateOrder(Order order);
        Task DeleteOrder(int orderId);
    }
}
