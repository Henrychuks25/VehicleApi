using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleApi.Models;

namespace VehicleApi.Context
{
    public class VehicleDbContext : DbContext
    {
        public VehicleDbContext(DbContextOptions<VehicleDbContext> options) :base(options)
        {

        }

        public DbSet<Vehicles> Vehicles { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Images> Images { get; set; }
    }
}
