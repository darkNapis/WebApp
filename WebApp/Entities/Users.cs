using System.Collections.Generic;

namespace WebApp.Entities
{

    public class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public virtual ICollection<Emails> Emails { get; set; }
        public virtual ICollection<UsersInRoles> UsersInRoles { get; set; }
    }
}
