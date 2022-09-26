using Microsoft.EntityFrameworkCore;
using PortalStore.CoreLayer.IntRepository;
using PortalStore.CoreLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalStore.DataAccessLayer.Repository
{
    public class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(PortalDbContext db) : base(db)
        {
        }
    }
}
