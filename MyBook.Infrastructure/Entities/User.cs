using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBook.Infrastructure.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string  Password { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; } = new HashSet<UserRole>();
    }
}
