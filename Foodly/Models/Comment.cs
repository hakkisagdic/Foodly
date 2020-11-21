using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodly.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public string Entry { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }

    }
}
