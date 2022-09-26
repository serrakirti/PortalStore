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
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(PortalDbContext db) : base(db)
        {
        }

        public async Task<Order> GetWithOrderItemByIdAsync(int orderIId)
        {
            return (await _db.Orders.Include(s => s.OrderItems).FirstOrDefaultAsync(s => s.Id == orderIId))!;
        }
    }
}
