using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Entities
{

    public class User
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string SurName { get; set; }

        public virtual ICollection<Email> Emails { get; set; }
        public virtual ICollection<UserInRole> UsersInRoles { get; set; }
    }
}
