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
    public class CustomerService : Service<Customer>, ICustomerService
    {
        public CustomerService(IUnitOfWork unit, IRepository<Customer> repo) : base(unit, repo)
        {
        }

        public async Task<Customer> GetWithOrderByIdAsync(int cusId)
        {
            return await _unit.Customer.GetWithOrderByIdAsync(cusId);
        }
    }
}
