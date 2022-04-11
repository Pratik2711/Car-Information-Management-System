using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Backend.Entities
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string Model { get; set; }

        [ForeignKey("Manufacturer")]
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string ManufacturerId { get; set; }

        [ForeignKey("CarType")]
        [Column(TypeName = "int")]
        public int TypeId { get; set; }
        [Column(TypeName = "varchar")]
        public bool Engine { get; set; }

        [Column(TypeName = "int")]
        public int BHP { get; set; }

        [ForeignKey("CarTransmissionType")]
        [Column(TypeName = "int")]
        public int TransmissionId { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Mileage { get; set; }

        [Required]
        [Column(TypeName = "int")]
        public int Seat { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string AirBagDetails { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string BootSpace { get; set; }

        [Required]
        //[Column(TypeName = "decimal")]
        public int Price { get; set; }
    }
}
