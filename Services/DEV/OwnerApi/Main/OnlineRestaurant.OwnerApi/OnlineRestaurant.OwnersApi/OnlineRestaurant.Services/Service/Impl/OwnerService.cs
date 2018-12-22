using OnlineRestaurant.OwnerDAO.DAO;
using OnlineRestaurant.OwnerDAO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRestaurant.Services.Service.Impl
{
    public class OwnerService
    {
        private readonly IOwnerDAO _ownerDAO;
        public OwnerService(IOwnerDAO ownerDAO) => _ownerDAO = ownerDAO;
        public bool AddAppetizer(Item item)
        {
            return _ownerDAO.AddAppetizers(item);
        }
    }
}
