using OnlineRestaurant.OwnerApi.Models;
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
    }
}
