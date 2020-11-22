using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foodly.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public int Password { get; set; }
        public string Email { get; set; }
        public string DisplayName { get; set; }
        public DateTime RegisterDate { get; set; }
        public string SecretKey { get; set; }
        public string Auth { get; set; }
    }
}
