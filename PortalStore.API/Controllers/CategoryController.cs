using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortalStore.API.DTOs;
using PortalStore.Core.IntService;
using PortalStore.CoreLayer.Model;

namespace PortalStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _catService;
        private IMapper _mapper;

        public CategoryController(ICategoryService catService, IMapper mapper)
        {
            _catService = catService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var cat = await _catService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<CategoryDto>>(cat));
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cat = await _catService.GetByIdAsync(id);
            return Ok(_mapper.Map<CategoryDto>(cat));
        }

        [HttpPost]
        public async Task<IActionResult> Save(CategoryDto orDto)
        {
            var newOrd = await _catService.AddAsync(_mapper.Map<Category>(orDto));

            return Created(String.Empty, _mapper.Map<CategoryDto>(newOrd));
        }

        [HttpPut]
        public IActionResult Update(CategoryDto orDto)
        {
            _catService.Update(_mapper.Map<Category>(orDto));
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            var pro = _catService.GetByIdAsync(id).Result;
            _catService.Remove(pro);
            return NoContent();
        }
    }
}
