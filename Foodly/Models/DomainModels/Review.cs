using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Foodly.Models
{
    public class Review
    {
        [Key,Required]
        public string UserID { get; set; }
        [Key,Required]
        public int ReviewID { get; set; }
        [Required]
        public string Header { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Blog { get; set; }
        [Required]
        public string PictureURL { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        [Required]
        public double Star { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public DateTime PublishDate { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public bool Publish { get; set; }
        public User User { get; set; }
    }
}
