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
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(PortalDbContext db) : base(db)
        {
        }

        public async Task<Category> GetWithProductByIdAsync(int catId)
        {
            return (await _db.Categories.Include(s => s.Products).FirstOrDefaultAsync(s => s.Id == catId))!;
        }
    }
}
