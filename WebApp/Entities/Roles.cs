using System.Collections.Generic;

namespace WebApp.Entities
{
    public class Roles
    {
        public int Id { get; set; }
        public string roleName { get; set; }

        public virtual ICollection<UsersInRoles> UsersInRoles { get; set; }
    }
}
