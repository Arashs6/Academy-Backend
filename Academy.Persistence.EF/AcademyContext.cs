using System;
using Academy.Domain;
using Academy.Persistence.EF.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Academy.Persistence.EF
{
    public class AcademyContext : DbContext
    {
        public DbSet<CourseCategory> CourseCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Academy;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseCategoryMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}