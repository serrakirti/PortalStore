using AutoMapper;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using PortalStore.API.DTOs;
using PortalStore.Core.IntService;
using PortalStore.CoreLayer.Model;

namespace PortalStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdressController : ControllerBase
    {
        private IAdressService _adService;
        private IMapper _mapper;

        public AdressController(IAdressService adService, IMapper mapper)
        {
            _adService = adService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var cat = await _adService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<AdressDto>>(cat));
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var ord = await _adService.GetByIdAsync(id);
            return Ok(_mapper.Map<AdressDto>(ord));
        }

        [HttpPost]
        public async Task<IActionResult> Save(AdressDto orDto)
        {
            var newOrd = await _adService.AddAsync(_mapper.Map<Adress>(orDto));

            return Created(String.Empty, _mapper.Map<AdressDto>(newOrd));
        }

        [HttpPut]
        public IActionResult Update(AdressDto orDto)
        {
            _adService.Update(_mapper.Map<Adress>(orDto));
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            var pro = _adService.GetByIdAsync(id).Result;
            _adService.Remove(pro);
            return NoContent();
        }
    }
}
