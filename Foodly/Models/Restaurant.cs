using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodly.Models
{
    public class RestaurantModel
    {
        public int ID { get; set; }
        public string RestaurantName { get; set; }
        public Double StarCount { get; set; }
        public string FavProduct { get; set; }
    }
}
