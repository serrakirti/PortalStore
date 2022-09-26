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
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(PortalDbContext db) : base(db)
        {
        }

        public async Task<Product> GetWithOrderItemByIdAsync(int proId)
        {
            return (await _db.Products.Include(s => s.OrderItems).FirstOrDefaultAsync(s => s.Id == proId))!;
        }
    }
}
