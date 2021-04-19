using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Entities
{
    public class Email
    {
        public int Id { get; set; }
        public int User { get; set; }
        public string Emails { get; set; }
        [DefaultValue(false)]
        public bool IsPrimary { get; set; }

        [ForeignKey("UserId")]
        public virtual User Users { get; set; }
        public int UserId { get; set; }
    }
}
