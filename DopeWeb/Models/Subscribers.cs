using Castle.MicroKernel.SubSystems.Conversion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DopeWeb.Models
{
    public class Subscribers
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column
            (TypeName = "varchar(100)")]

        public string Email { get; set; }

    }
}
