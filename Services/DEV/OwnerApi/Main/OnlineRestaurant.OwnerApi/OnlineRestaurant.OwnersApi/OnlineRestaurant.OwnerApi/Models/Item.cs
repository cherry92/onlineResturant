using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineRestaurant.OwnerApi.Models
{
    public class Item
    {
        public string Name { get; set; }
        public int Type_ID { get; set; }
        public long Prices { get; set; }
        public int Quantity { get; set; }
        public long Calorie { get; set; }
    }
}
