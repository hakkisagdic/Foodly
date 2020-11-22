using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodly.Models
{
    public class Review
    {
        public string UserID { get; set; }
        public int ReviewID { get; set; }
        public string Header { get; set; }
        public string Adress { get; set; }
        public string Blog { get; set; }
        public string PictureURL { get; set; }
        public string RestaurantName { get; set; }
        public double Star { get; set; }
        public string ProductName { get; set; }
        public DateTime PublishDate { get; set; }
        public int Price { get; set; }
        public bool Publish { get; set; }
        public User User { get; set; }
    }
}
