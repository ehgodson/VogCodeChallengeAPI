using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace VogCodeChallenge.API
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.FirstName).IsRequired().HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.LastName).IsRequired().HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.JobTitle).IsRequired().HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.Address).IsRequired().HasMaxLength(250).IsUnicode(false);

                entity.HasOne(d => d.Department).WithMany(p => p.Employees).HasForeignKey(d => d.DepartmentId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Employees_Departments");

                entity.HasData(new Employee
                {
                    Id = 1,
                    DepartmentId = 1,
                    FirstName = "Arthur",
                    LastName = "Parker",
                    JobTitle = "Sales Manager",
                    Address = "2267 Water Street, Kitchener, ON N2H 5A5"
                });
                entity.HasData(new Employee
                {
                    Id = 2,
                    DepartmentId = 2,
                    FirstName = "Steve",
                    LastName = "Padilla",
                    JobTitle = "Administrative assistant",
                    Address = "1884 Jasper Ave, Edmonton, AB T5J 3N6"
                });
                entity.HasData(new Employee
                {
                    Id = 3,
                    DepartmentId = 1,
                    FirstName = "Joe",
                    LastName = "Lukens",
                    JobTitle = "Associate manager",
                    Address = ""
                });
                entity.HasData(new Employee
                {
                    Id = 4,
                    DepartmentId = 2,
                    FirstName = "Richard",
                    LastName = "McCormick",
                    JobTitle = "Project Coordinator",
                    Address = "154 Carling Avenue, Ottawa, ON K1Z 7B5"
                });
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Description).IsRequired().HasMaxLength(50).IsUnicode(false);

                entity.HasData(new Department
                {
                    Id = 1,
                    Description = "Sales"
                });
                entity.HasData(new Department
                {
                    Id = 2,
                    Description = "Marketing",
                });
            });
        }
    }
}
