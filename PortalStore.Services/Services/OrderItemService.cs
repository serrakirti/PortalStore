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
    public class OrderItemService : Service<OrderItem>, IOrderItemService
    {
        public OrderItemService(IUnitOfWork unit, IRepository<OrderItem> repo) : base(unit, repo)
        {
        }
    }
}
