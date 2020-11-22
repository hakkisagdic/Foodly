using System;
using System.ComponentModel.DataAnnotations;

namespace Foodly.Models
{
    public class Restaurant
    {
        [Key,Required]
        public int RestaurantID { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        [Required]
        public string RestaurantAdress { get; set; }
        public string RestaurantWeb { get; set; }
        [Required]
        public Double StarCount { get; set; }
        [Required]
        public string FavProduct { get; set; }
    }
}
