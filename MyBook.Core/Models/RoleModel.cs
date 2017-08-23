using System.Collections.Generic;

namespace MyBook.Core.Models
{
    public class RoleModel
    {
        public int RoleID { get; set; }
        public string Name { get; set; }
        public ICollection<PermissionModel> Permission { get; set; } = new List<PermissionModel>();
    }
}