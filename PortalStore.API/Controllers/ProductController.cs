using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortalStore.API.DTOs;
using PortalStore.Core.IntService;
using PortalStore.CoreLayer.Model;

namespace PortalStore.API.Controllers
{
    public class ProductController : ControllerBase
    {
        private IProductService _proService;
        private IMapper _mapper;

        public ProductController(IProductService proService, IMapper mapper)
        {
            _proService = proService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var cat = await _proService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<ProductDto>>(cat));
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cat = await _proService.GetByIdAsync(id);
            return Ok(_mapper.Map<ProductDto>(cat));
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProductDto orDto)
        {
            var newOrd = await _proService.AddAsync(_mapper.Map<Product>(orDto));

            return Created(String.Empty, _mapper.Map<ProductDto>(newOrd));
        }

        [HttpPut]
        public IActionResult Update(ProductDto orDto)
        {
            _proService.Update(_mapper.Map<Product>(orDto));
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            var pro = _proService.GetByIdAsync(id).Result;
            _proService.Remove(pro);
            return NoContent();
        }
    }
}
