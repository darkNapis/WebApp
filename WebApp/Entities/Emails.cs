using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Entities
{
    public class Emails
    {
        public int Id { get; set; }
        public int User { get; set; }
        public string Email { get; set; }
        public bool IsPrimary { get; set; }

        [ForeignKey("UserId")]
        public virtual Users Users { get; set; }
        public int UserId { get; set; }
    }
}
