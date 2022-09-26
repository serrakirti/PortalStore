using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortalStore.API.DTOs;
using PortalStore.Core.IntService;
using PortalStore.CoreLayer.Model;
using static Mernis.KPSPublicSoapClient;

namespace PortalStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService _cusService;
        private IMapper _mapper;

        public CustomerController(ICustomerService cusService, IMapper mapper)
        {
            _cusService = cusService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var cat = await _cusService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<CustomerDto>>(cat));
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cat = await _cusService.GetByIdAsync(id);
            return Ok(_mapper.Map<CustomerDto>(cat));
        }

        [HttpPost]
        public async Task<IActionResult> Save(CustomerDto orDto)
        {
            if (TcKimlikDogrula(orDto).Result == true)
            {
                var newOrd = await _cusService.AddAsync(_mapper.Map<Customer>(orDto));

                return Created(String.Empty, _mapper.Map<CustomerDto>(newOrd));
            }
            else
            {
                return BadRequest();
            }         
        }
        private Task<bool> TcKimlikDogrula(CustomerDto cd)
        {
            bool dogrulamaSonucu = false;
            try
            {
                var mernisClient = new Mernis.KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
                var tcKimlikDogrulamaServisResponse = mernisClient.TCKimlikNoDogrulaAsync(long.Parse(cd.TcId), cd.FirstName, cd.LastName, cd.BirthDate.Year).GetAwaiter().GetResult();
                dogrulamaSonucu = tcKimlikDogrulamaServisResponse.Body.TCKimlikNoDogrulaResult;
            }
            catch
            {
                dogrulamaSonucu = false;
            }
            return Task.FromResult(dogrulamaSonucu);
        }

        [HttpPut]
        public IActionResult Update(CustomerDto orDto)
        {
            _cusService.Update(_mapper.Map<Customer>(orDto));
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            var pro = _cusService.GetByIdAsync(id).Result;
            _cusService.Remove(pro);
            return NoContent();
        }
   
    }
}
