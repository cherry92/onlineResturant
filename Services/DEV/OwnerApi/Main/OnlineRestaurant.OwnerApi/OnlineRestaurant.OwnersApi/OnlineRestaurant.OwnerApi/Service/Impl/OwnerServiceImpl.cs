using CommonUtilities.Models;
using OnlineRestaurant.OwnerDAO.DAO;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRestaurant.Services.Service.Impl
{
    public class OwnerServiceImpl:IOwnerService
    {
        private readonly IOwnerDAO _ownerDAO;
        public OwnerServiceImpl(IOwnerDAO ownerDAO) => _ownerDAO = ownerDAO;
        public bool AddAppetizer(Item item)
        {
            return _ownerDAO.AddAppetizers(item);
        }
        public bool AddDeserts(Desert desert)
        {
            return _ownerDAO.AddDeserts(desert);
        }
        public bool AddMainCourse(Item item)
        {
            return _ownerDAO.AddMainCourse(item);
        }
        public bool AddBeverages(Beverage beverage)
        {
            return _ownerDAO.AddBeverages(beverage);
        }
        public bool AddSalads(Item item)
        {
            return _ownerDAO.AddSalads(item);
        }
        public bool AddEntrees(Item item)
        {
            return _ownerDAO.AddEntrees(item);
        }
        public bool AddChefSpecials(Item item)
        {
            return _ownerDAO.AddChefSpecials(item);
        }
        public bool AddSoups(Item item)
        {
            return _ownerDAO.AddSoups(item);
        }
        public bool AddTables(Tables table)
        {
            return _ownerDAO.AddTables(table);
        }
    }
}
