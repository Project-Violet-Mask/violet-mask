using Microsoft.AspNetCore.Mvc;
using violet.mask.Domain.Catalog;
using violet.mask.Data;

namespace violet.mask.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatalogController : ControllerBase
    {
        private readonly StoreContext _context;

        public CatalogController(StoreContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult GetItems()
        {
           
            return Ok(_context.Items);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetItem(int id)
        {
            var item = new Item("Item 1", "Description 1", "Brand 1", 100.00m)
            {
                Id = id
            };
            
            return Ok(item);
        }

        [HttpPost]
        public IActionResult CreateItem(Item item)
        {
            return CreatedAtAction(nameof(GetItem), new { id = 42 }, item);
        }

        [HttpPost("{id:int}/ratings")]
        public IActionResult AddRating(int id, Rating rating)
        {
            return Ok();
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateItem(int id, Item item)
        {
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteItem(int id)
        {
            return NoContent();
        }
    }
}