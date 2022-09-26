using PortalStore.CoreLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalStore.CoreLayer.IntRepository
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<Order> GetWithOrderItemByIdAsync(int orderIId);
    }
}
