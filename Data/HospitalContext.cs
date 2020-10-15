using Hospital.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        {

        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder  modelBuilder)
        {
            modelBuilder.Entity<Doctor>().ToTable("Doctor");
            modelBuilder.Entity<Department>().ToTable("Department");
        }
    }
}
