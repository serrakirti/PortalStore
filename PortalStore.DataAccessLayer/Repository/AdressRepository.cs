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
    public class AdressRepository : Repository<Adress>, IAdressRepository
    {
        public AdressRepository(PortalDbContext db) : base(db)
        {
        }

        public async Task<Adress> GetWithOrderByIdAsync(int adId)
        {
            return (await _db.Adresses.Include(s => s.Orders).FirstOrDefaultAsync(s => s.Id == adId))!;
        }
    }
}
