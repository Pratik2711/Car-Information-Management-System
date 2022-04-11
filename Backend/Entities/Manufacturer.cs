using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend.Entities
{
    public class Manufacturer
    {
        [Key]
        [Column(TypeName = "int")]
        public int Id { get; set; }

        // [Index(IsUnique = True)]
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string Name { get; set; }

        // [Index(IsUnique = True)]
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string ContactPerson { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string RegisteredOffice { get; set; }
    }
}
