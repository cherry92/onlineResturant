using OnlineRestaurant.OwnerDAO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRestaurant.OwnerDAO.DAO
{
    public interface IOwnerDAO
    {
        bool AddAppetizers(Item item);
    }
}
