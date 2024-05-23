using Microsoft.EntityFrameworkCore;
using MVCWebApp.Models;

namespace MVCWebApp.Data
{
    public class StudentRecord : DbContext
    {
        public StudentRecord (DbContextOptions<StudentRecord> options)
            : base(options)
        {
        }

        public DbSet<StudentModel> StudentModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentModel>().ToTable("StudentModel");
        }
    }
}
