using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataManagement.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Integrated Security=true;Initial Catalog=Student=StudentDbMvc");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("StudentTbl");
            modelBuilder.Entity<Student>().Property(o => o.StudentName).HasMaxLength(25).HasColumnType("varchar").IsRequired();
            modelBuilder.Entity<Student>().Property(o => o.StudentSurname).HasMaxLength(25).HasColumnType("varchar").IsRequired();
           
        }
    }
}
