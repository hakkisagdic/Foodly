using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodly.Models
{
    public class Comment
    {
        public string UserID { get; set; }
        public int CommentID { get; set; }
        public DateTime PublishDate { get; set; }
        public string Entry { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
        public User User { get; set; }
        public Review Review { get; set; }
    }
}
