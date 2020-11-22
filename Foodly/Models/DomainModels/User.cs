using System;
using System.ComponentModel.DataAnnotations;

namespace Foodly.Models
{
    public class User
    {
        [Key,Required]
        public int UserID { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public int Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string DisplayName { get; set; }
        [Required]
        public DateTime RegisterDate { get; set; }
        [Required]
        public string SecretKey { get; set; }
        [Required]
        public string Auth { get; set; }
    }
}
