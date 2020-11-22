using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Foodly.Models
{
    public class Comment
    {
        [Key,Required]
        public string UserID { get; set; }
        [Key,Required]
        public int CommentID { get; set; }
        [Required]
        public DateTime PublishDate { get; set; }
        [Required]
        public string Entry { get; set; }
        [Required]
        public int Like { get; set; }
        public int Dislike { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public Review Review { get; set; }
    }
}
