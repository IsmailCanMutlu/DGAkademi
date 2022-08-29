using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace W02.Models
{
    public partial class Contex : DbContext
    {
        public Contex()
        {
        }

        public Contex(DbContextOptions<Contex> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Prodact> Prodacts { get; set; }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}