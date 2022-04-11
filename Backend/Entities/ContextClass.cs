using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Backend.Entities;

namespace Backend.Entities
{
    public class ContextClass:DbContext
    {
        public ContextClass(DbContextOptions<ContextClass> options) : base(options) { }

        public DbSet<Car> cars { get; set; }
        public DbSet<CarType> CarType { get; set; }

        public DbSet<CarTransmissionType> CarTransmissionType { get; set; }
        public DbSet<Manufacturer> Manufacturer { get; set; }
    }
}
