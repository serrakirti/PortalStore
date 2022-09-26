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
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unit, IRepository<Category> repo) : base(unit, repo)
        {
        }

        public async Task<Category> GetWithProductByIdAsync(int catId)
        {
            return await _unit.Category.GetWithProductByIdAsync(catId);
        }
    }
}
