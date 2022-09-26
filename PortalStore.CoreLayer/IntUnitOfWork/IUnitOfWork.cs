using PortalStore.CoreLayer.IntRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalStore.CoreLayer.IntUnitOfWork
{
    public interface IUnitOfWork
    {
        IAdressRepository Adress { get; }
        ICategoryRepository Category { get; }
        IOrderRepository Order { get; }
        IOrderItemRepository OrderItem { get; }
        IProductRepository Product { get; }
        ICustomerRepository Customer { get; }

        Task CommitAsync();
        void Commit(); 
    }
}
