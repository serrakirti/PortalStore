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
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unit, IRepository<Product> repo) : base(unit, repo)
        {
        }

        public async Task<Product> GetWithOrderItemByIdAsync(int proId)
        {
            return await _unit.Product.GetWithOrderItemByIdAsync(proId);
        }
    }
}
