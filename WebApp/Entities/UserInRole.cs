using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Entities
{
    public class UserInRole
    {
        public int Id { get; set; }
        
        [ForeignKey("UserId")]
        public virtual User Users { get; set; }
        public int UserId { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Roles { get; set; }
        public int RoleId { get; set; }
    }
}
