using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineRestaurant.OwnerApi.Models;
using OnlineRestaurant.Services.Service;

namespace OnlineRestaurant.OwnerApi.Controllers
{
    [Route("api/[controller]")]
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
        public IActionResult Post([FromBody] Item item)
        {
           bool value= _ownerService.AddAppetizer(item);
            return Ok(value);
        }
    }
}
