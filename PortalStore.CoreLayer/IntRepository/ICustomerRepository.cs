using PortalStore.CoreLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalStore.CoreLayer.IntRepository
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Task<Customer> GetWithOrderByIdAsync(int cusId);
    }
}
