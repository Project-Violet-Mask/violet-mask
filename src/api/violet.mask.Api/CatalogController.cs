using Microsoft.AspNetCore.Mvc;
using violet.mask.Domain.Catalog;

namespace violet.mask.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            var items = new[]
            {
                new Item(name: "Item 1", description: "Description", brand:"Brand 1", price: 100.00m),
                new Item(name: "Item 2", description: "Description", brand:"Brand 2", price: 200.00m),
                new Item(name: "Item 3", description: "Description", brand:"Brand 3", price: 300.00m),
                new Item(name: "Item 4", description: "Description", brand:"Brand 4", price: 400.00m),
                new Item(name: "Item 5", description: "Description", brand:"Brand 5", price: 500.00m),
            };
            return Ok(items);
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