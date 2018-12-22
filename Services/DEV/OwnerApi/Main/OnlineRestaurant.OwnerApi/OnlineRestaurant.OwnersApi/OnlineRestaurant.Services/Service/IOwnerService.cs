using OnlineRestaurant.OwnerDAO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRestaurant.Services.Service
{
    public interface IOwnerService
    {
        bool AddAppetizer(Item item);
    }
}
