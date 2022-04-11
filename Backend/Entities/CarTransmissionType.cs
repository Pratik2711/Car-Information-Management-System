using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Entities
{
    public class CarTransmissionType
    {
        [Key]
        [Required]
        [Column(TypeName = "int")]
        public int Id { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string Name { get; set; }
    }
}
