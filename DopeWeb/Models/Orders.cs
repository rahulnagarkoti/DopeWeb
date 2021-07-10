using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DopeWeb.Models
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string Address { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string PhoneNumber { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }

        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public Products Product { get; set; }
    }
}
