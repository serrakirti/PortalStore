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
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(PortalDbContext db) : base(db)
        {
        }

        public async Task<Customer> GetWithOrderByIdAsync(int cusId)
        {
            return (await _db.Customers.Include(s => s.Orders).FirstOrDefaultAsync(s => s.Id == cusId))!;
        }
    }
}
