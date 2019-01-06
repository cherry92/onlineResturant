using System;
using System.Collections.Generic;
using System.Text;

namespace CommonUtilities.Models
{
    public class Beverage
    {
        public string Name { get; set; }
        public long Prices { get; set; }
        public int Quantity { get; set; }
        public long Calorie { get; set; }
        public bool Alocoholic { get; set; }
        public string Description { get; set; } 
    }
}
