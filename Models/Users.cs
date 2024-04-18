using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string FullName { get; set; } = "";
        public string userName{ get; set; } = "";
        public string Password{ get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public string? Email { get; set; }
        public Role Role { get; set; }
    }
}
