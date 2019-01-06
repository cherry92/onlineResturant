using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonUtilities.Models;
using Microsoft.AspNetCore.Mvc;
using OnlineRestaurant.MenuApi.Service;

namespace OnlineRestaurant.MenuApi.Controllers
{
    [Route("api/v1/Menu")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        // GET api/values
        private readonly IMenuService _menuService;
        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }


        [HttpGet]
        [Route("Appetizers/SeaFood")]
        public IActionResult Appetizer()
        {
            IEnumerable<Item> value = _menuService.GetSeaFoodAppetizers();
            return Ok(value);
        }
        [HttpGet]
        [Route("Appetizers/Veg")]
        public IActionResult VegAppetizer()
        {
            IEnumerable<Item> value = _menuService.GetVegAppetizers();
            return Ok(value);
        }
        [HttpGet]
        [Route("Appetizers/Chicken")]
        public IActionResult ChickenAppetizer()
        {
            IEnumerable<Item> value = _menuService.GetChickenAppetizers();
            return Ok(value);
        }
        [HttpGet]
        [Route("Appetizers/Mutton")]
        public IActionResult MuttonAppetizer()
        {
            IEnumerable<Item> value = _menuService.GetMuttonAppetizers();
            return Ok(value);
        }
        [HttpGet]
        [Route("Deserts")]
        public IActionResult Deserts()
        {
            IEnumerable<Desert> value = _menuService.GetDeserts();
            return Ok(value);
        }
        [HttpGet]
        [Route("MainCourse/Veg")]
        public IActionResult VegMainCourse()
        {
            IEnumerable<Item> value = _menuService.GetVegMainCourse();
            return Ok(value);
        }
        [HttpGet]
        [Route("MainCourse/Chicken")]
        public IActionResult ChickenMainCourse()
        {
            IEnumerable<Item> value = _menuService.GetChickenMainCourse();
            return Ok(value);
        }
        [HttpGet]
        [Route("MainCourse/Mutton")]
        public IActionResult MuttonMainCourse()
        {
            IEnumerable<Item> value = _menuService.GetMuttonMainCourse();
            return Ok(value);
        }
        [HttpGet]
        [Route("MainCourse/SeaFood")]
        public IActionResult SeaFoodMainCourse()
        {
            IEnumerable<Item> value = _menuService.GetSeaFoodMainCourse();
            return Ok(value);
        }
        [HttpGet]
        [Route("Beverages/NonAlcohol")]
        public IActionResult NonAlcoholicBeverages()
        {
            IEnumerable<Beverage> value = _menuService.GetNonAlcoholicBeverages();
            return Ok(value);
        }
        [HttpGet]
        [Route("Beverages/Alcoholic")]
        public IActionResult AlcoholicBeverages()
        {
            IEnumerable<Beverage> value = _menuService.GetAlcoholicBeverages();
            return Ok(value);
        }
        [HttpGet]
        [Route("Salads/Veg")]
        public IActionResult VegSalads()
        {
            IEnumerable<Item> value = _menuService.GetVegSalads();
            return Ok(value);
        }
        [HttpGet]
        [Route("Salads/Chicken")]
        public IActionResult ChickenSalads()
        {
            IEnumerable<Item> value = _menuService.GetChickenSalads();
            return Ok(value);
        }

        [HttpGet]
        [Route("Entrees/Veg")]
        public IActionResult VegEntrees()
        {
            IEnumerable<Item> value = _menuService.GetVegEntrees();
            return Ok(value);
        }
        [HttpGet]
        [Route("Entrees/Chicken")]
        public IActionResult ChickenEntrees()
        {
            IEnumerable<Item> value = _menuService.GetChickenEntrees();
            return Ok(value);
        }
        [HttpGet]
        [Route("Entrees/Mutton")]
        public IActionResult MuttonEntrees()
        {
            IEnumerable<Item> value = _menuService.GetMuttonEntrees();
            return Ok(value);
        }
        [HttpGet]
        [Route("Entrees/SeaFood")]
        public IActionResult SeaFoodEntrees()
        {
            IEnumerable<Item> value = _menuService.GetSeaFoodEntrees();
            return Ok(value);
        }
        [HttpGet]
        [Route("ChefSpecials/Veg")]
        public IActionResult ChefSpecials()
        {
            IEnumerable<Item> value = _menuService.GetVegChefSpecials();
            return Ok(value);
        }
        [HttpGet]
        [Route("ChefSpecials/Chicken")]
        public IActionResult ChefChickenSpecials()
        {
            IEnumerable<Item> value = _menuService.GetChickenChefSpecials();
            return Ok(value);
        }
        [HttpGet]
        [Route("ChefSpecials/Mutton")]
        public IActionResult MuttonChefSpecials()
        {
            IEnumerable<Item> value = _menuService.GetMuttonChefSpecials();
            return Ok(value);
        }
        [HttpGet]
        [Route("ChefSpecials/SeaFood")]
        public IActionResult ChefSeaFoodSpecials()
        {
            IEnumerable<Item> value = _menuService.GetSeaFoodChefSpecials();
            return Ok(value);
        }
        [HttpGet]
        [Route("Soups/Veg")]
        public IActionResult VegSoups()
        {
            IEnumerable<Item> value = _menuService.GetVegSoups();
            return Ok(value);
        }
        [HttpGet]
        [Route("Soups/Chicken")]
        public IActionResult ChickenSoups()
        {
            IEnumerable<Item> value = _menuService.GetChickenSoups();
            return Ok(value);
        }
        [HttpGet]
        [Route("Tables")]
        public IActionResult Tables()
        {
            IEnumerable<Tables> value = _menuService.GetTables();
            return Ok(value);
        }
    }
}
