using System.Collections.Generic;

namespace WebApp.Entities
{

    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<UserInRole> UsersInRoles { get; set; }
    }
}
