using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineRestaurant.OwnerDAO.Models
{
    public class Item
    {
        public string Name { get; set; }
        public int Type_ID { get; set; }
        public int Prices { get; set; }
        public int Quantity { get; set; }
        public long Calorie { get; set; }

    }
}
