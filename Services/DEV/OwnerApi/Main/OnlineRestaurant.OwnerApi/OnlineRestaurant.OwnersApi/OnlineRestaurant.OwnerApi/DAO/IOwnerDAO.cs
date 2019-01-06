using CommonUtilities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRestaurant.OwnerDAO.DAO
{
    public interface IOwnerDAO
    {
        bool AddAppetizers(Item item);
        bool AddDeserts(Desert desert);
        bool AddMainCourse(Item item);
        bool AddBeverages(Beverage beverage);
        bool AddSalads(Item item);
        bool AddEntrees(Item item);
        bool AddChefSpecials(Item item);
        bool AddSoups(Item item);
        bool AddTables(Tables table);
    }
}
