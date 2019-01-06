using CommonUtilities.Models;
using OnlineRestaurant.MenuApi.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.MenuApi.Service.Impl
{

    public class MenuServiceImpl : IMenuService
    {
        private readonly IMenuDAO _menuDAO;
        public MenuServiceImpl(IMenuDAO menuDAO) => _menuDAO = menuDAO;

        public IEnumerable<Item> GetVegAppetizers()
        {
            return _menuDAO.GetVegAppetizers();
        }
        public IEnumerable<Item> GetChickenAppetizers()
        {
            return _menuDAO.GetChickenAppetizers();
        }
        public IEnumerable<Item> GetMuttonAppetizers()
        {
            return _menuDAO.GetMuttonAppetizers();
        }
        public IEnumerable<Item> GetSeaFoodAppetizers()
        {
            return _menuDAO.GetSeaFoodAppetizers();
        }

        public IEnumerable<Beverage> GetAlcoholicBeverages()
        {
            return _menuDAO.GetAlcoholicBeverages();
        }
        public IEnumerable<Beverage> GetNonAlcoholicBeverages()
        {
            return _menuDAO.GetNonAlcoholicBeverages();
        }
        public IEnumerable<Item> GetVegChefSpecials()
        {
            return _menuDAO.GetVegChefSpecials();
        }
        public IEnumerable<Item> GetChickenChefSpecials()
        {
            return _menuDAO.GetChickenChefSpecials();
        }
        public IEnumerable<Item> GetMuttonChefSpecials()
        {
            return _menuDAO.GetMuttonChefSpecials();
        }
        public IEnumerable<Item> GetSeaFoodChefSpecials()
        {
            return _menuDAO.GetSeaFoodChefSpecials();
        }
        public IEnumerable<Desert> GetDeserts()
        {
            return _menuDAO.GetDeserts();
        }

        public IEnumerable<Item> GetVegEntrees()
        {
            return _menuDAO.GetVegEntrees();
        }
        public IEnumerable<Item> GetChickenEntrees()
        {
            return _menuDAO.GetChickenEntrees();
        }
        public IEnumerable<Item> GetMuttonEntrees()
        {
            return _menuDAO.GetMuttonEntrees();
        }
        public IEnumerable<Item> GetSeaFoodEntrees()
        {
            return _menuDAO.GetSeaFoodEntrees();
        }
        public IEnumerable<Item> GetVegMainCourse()
        {
            return _menuDAO.GetVegMainCourse();
        }
        public IEnumerable<Item> GetChickenMainCourse()
        {
            return _menuDAO.GetChickenMainCourse();
        }
        public IEnumerable<Item> GetMuttonMainCourse()
        {
            return _menuDAO.GetMuttonMainCourse();
        }
        public IEnumerable<Item> GetSeaFoodMainCourse()
        {
            return _menuDAO.GetSeaFoodMainCourse();
        }
        public IEnumerable<Item> GetVegSalads()
        {
            return _menuDAO.GetVegSalads();
        }
        public IEnumerable<Item> GetChickenSalads()
        {
            return _menuDAO.GetChickenSalads();
        }
        public IEnumerable<Item> GetVegSoups()
        {
            return _menuDAO.GetVegSoups();
        }
        public IEnumerable<Item> GetChickenSoups()
        {
            return _menuDAO.GetChickenSoups();
        }
        public IEnumerable<Tables> GetTables()
        {
            return _menuDAO.GetTables();
        }
    }
}
