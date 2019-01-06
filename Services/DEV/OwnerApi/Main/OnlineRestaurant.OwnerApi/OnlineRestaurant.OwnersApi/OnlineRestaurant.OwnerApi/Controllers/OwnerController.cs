using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonUtilities.Models;
using Microsoft.AspNetCore.Mvc;
using OnlineRestaurant.Services.Service;

namespace OnlineRestaurant.OwnerApi.Controllers
{
    [Route("api/v1/Owner")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService _ownerService;
        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }


        [HttpPost]
        [Route("Appetizers")]
        public IActionResult Appetizer([FromBody] Item item)
        {
           bool value= _ownerService.AddAppetizer(item);
            return Ok(value);
        }
        [HttpPost]
        [Route("Deserts")]
        public IActionResult Deserts([FromBody] Desert desert)
        {
            bool value = _ownerService.AddDeserts(desert);
            return Ok(value);
        }
        [HttpPost]
        [Route("MainCourse")]
        public IActionResult MainCourse([FromBody] Item item)
        {
            bool value = _ownerService.AddMainCourse(item);
            return Ok(value);
        }
        [HttpPost]
        [Route("Beverages")]
        public IActionResult Beverages([FromBody] Beverage beverage)
        {
            bool value = _ownerService.AddBeverages(beverage);
            return Ok(value);
        }
        [HttpPost]
        [Route("Salads")]
        public IActionResult Salads([FromBody] Item item)
        {
            bool value = _ownerService.AddSalads(item);
            return Ok(value);
        }
        [HttpPost]
        [Route("Entrees")]
        public IActionResult Entrees([FromBody] Item item)
        {
            bool value = _ownerService.AddEntrees(item);
            return Ok(value);
        }
        [HttpPost]
        [Route("ChefSpecials")]
        public IActionResult ChefSpecials([FromBody] Item item)
        {
            bool value = _ownerService.AddChefSpecials(item);
            return Ok(value);
        }
        [HttpPost]
        [Route("Soups")]
        public IActionResult Soups([FromBody] Item item)
        {
            bool value = _ownerService.AddSoups(item);
            return Ok(value);
        }
        [HttpPost]
        [Route("Tables")]
        public IActionResult Tables([FromBody] Tables table)
        {
            bool value = _ownerService.AddTables(table);
            return Ok(value);
        }
    }
}
