using CommonUtilities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.MenuApi.Service
{
    public interface IMenuService
    {
        IEnumerable<Item> GetVegAppetizers();
        IEnumerable<Item> GetChickenAppetizers();
        IEnumerable<Item> GetMuttonAppetizers();
        IEnumerable<Item> GetSeaFoodAppetizers();
        IEnumerable<Desert> GetDeserts();
        IEnumerable<Item> GetVegMainCourse();
        IEnumerable<Item> GetChickenMainCourse();
        IEnumerable<Item> GetMuttonMainCourse();
        IEnumerable<Item> GetSeaFoodMainCourse();
        IEnumerable<Beverage> GetAlcoholicBeverages();
        IEnumerable<Beverage> GetNonAlcoholicBeverages();
        IEnumerable<Item> GetVegSalads();
        IEnumerable<Item> GetChickenSalads();
        IEnumerable<Item> GetVegEntrees();
        IEnumerable<Item> GetChickenEntrees();
        IEnumerable<Item> GetMuttonEntrees();
        IEnumerable<Item> GetSeaFoodEntrees();
        IEnumerable<Item> GetVegChefSpecials();
        IEnumerable<Item> GetChickenChefSpecials();
        IEnumerable<Item> GetMuttonChefSpecials();
        IEnumerable<Item> GetSeaFoodChefSpecials();
        IEnumerable<Item> GetVegSoups();
        IEnumerable<Item> GetChickenSoups();
        IEnumerable<Tables> GetTables();
    }
}
