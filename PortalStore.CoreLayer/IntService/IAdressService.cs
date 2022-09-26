using PortalStore.CoreLayer.IntService;
using PortalStore.CoreLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalStore.Core.IntService
{
    public interface IAdressService:IServices<Adress>
    {
        Task<Adress> GetWithOrderByIdAsync(int adId);
    }
}
