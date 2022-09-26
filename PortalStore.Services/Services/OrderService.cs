using PortalStore.Core.IntService;
using PortalStore.CoreLayer.IntRepository;
using PortalStore.CoreLayer.IntUnitOfWork;
using PortalStore.CoreLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalStore.Service.Services
{
    public class OrderService : Service<Order>, IOrderService
    {
        public OrderService(IUnitOfWork unit, IRepository<Order> repo) : base(unit, repo)
        {
        }

        public async Task<Order> GetWithOrderItemByIdAsync(int orderIId)
        {
            return await _unit.Order.GetWithOrderItemByIdAsync(orderIId);
        }
    }
}
