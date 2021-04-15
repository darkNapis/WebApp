using System.Collections.Generic;

namespace WebApp.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<UserInRole> UsersInRoles { get; set; }
    }
}
