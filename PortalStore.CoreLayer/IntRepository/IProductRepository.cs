using PortalStore.CoreLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalStore.CoreLayer.IntRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetWithOrderItemByIdAsync(int proId);
    }
}
