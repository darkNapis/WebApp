using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Entities
{
    public class Emails
    {
        public int IdEmail { get; set; }
        public int IdUser { get; set; }
        public string email { get; set; }
        public string isPrimary { get; set; }

        [ForeignKey("UserId")]
        public virtual Users Users { get; set; }
        public int UserId { get; set; }
    }
}
