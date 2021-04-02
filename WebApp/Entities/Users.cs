using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string name { get; set; }
        public string surName { get; set; }

        public virtual ICollection<Emails> Emails { get; set; }
        public virtual ICollection<UsersInRoles> UsersInRoles { get; set; }
    }
}
