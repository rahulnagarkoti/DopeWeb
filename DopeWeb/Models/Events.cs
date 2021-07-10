using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DopeWeb.Models
{
    public class Events
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName="varchar(300)")]
        public string Description { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
