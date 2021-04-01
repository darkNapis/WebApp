using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Entities
{
    public class Roles
    {
        public int IdRole { get; set; }
        public string roleName { get; set; }

        public virtual ICollection<UsersInRoles> UsersInRoles { get; set; }
    }
}
