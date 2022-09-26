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
    public class AdressService : Service<Adress>, IAdressService
    {
        public AdressService(IUnitOfWork unit, IRepository<Adress> repo) : base(unit, repo)
        {
        }

        public async Task<Adress> GetWithOrderByIdAsync(int adId)
        {
            return await _unit.Adress.GetWithOrderByIdAsync(adId);
        }
    }
}
