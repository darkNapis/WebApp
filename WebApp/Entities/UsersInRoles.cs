using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Entities
{
    public class UsersInRoles
    {
        public int Id { get; set; }
        
        [ForeignKey("UserId")]
        public virtual Users Users { get; set; }
        public int UserId { get; set; }

        [ForeignKey("RoleId")]
        public virtual Roles Roles { get; set; }
        public int RoleId { get; set; }
    }
}
