using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PortalStore.API.DTOs;
using PortalStore.Core.IntService;
using PortalStore.CoreLayer.Model;

namespace PortalStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemController : ControllerBase
    {
        private IOrderItemService _orItService;
        private IMapper _mapper;

        public OrderItemController(IOrderItemService orItService, IMapper mapper)
        {
            _orItService = orItService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var cat = await _orItService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<OrderItemDto>>(cat));
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cat = await _orItService.GetByIdAsync(id);
            return Ok(_mapper.Map<OrderItemDto>(cat));
        }

        [HttpPost]
        public async Task<IActionResult> Save(OrderItemDto orDto)
        {
            var newOrd = await _orItService.AddAsync(_mapper.Map<OrderItem>(orDto));

            return Created(String.Empty, _mapper.Map<OrderItemDto>(newOrd));
        }

        [HttpPut]
        public IActionResult Update(OrderItemDto orDto)
        {
            _orItService.Update(_mapper.Map<OrderItem>(orDto));
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            var pro = _orItService.GetByIdAsync(id).Result;
            _orItService.Remove(pro);
            return NoContent();
        }
    }
}
