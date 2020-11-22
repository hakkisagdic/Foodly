using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodly.Models
{
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantAdress { get; set; }
        public string RestaurantWeb { get; set; }
        public Double StarCount { get; set; }
        public string FavProduct { get; set; }
    }
}
