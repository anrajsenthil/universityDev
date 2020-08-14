using JetBrains.Annotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using University.Domain.Entities;

namespace University.Domain.DataAccess
{
    public class UniversityContext : IdentityDbContext<IdentityUser>
    {
       

        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
        {
        } 
        public DbSet<Student> Students { get; set; }

        public DbSet<UserRegister> UserRegisters { get; set; }
        public int IdentityRole { get; private set; }

       // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       // {
          //  optionsBuilder.UseSqlServer("server=MYKULLP7KSJRV2;Database=UniversityDB;Integrated Security = False; User Id = sa; Password = 0987@suse; MultipleActiveResultSets = True");
       // }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserRegister>(userregister =>
            {
                userregister.ToTable("UserRegister");
                userregister.HasKey("Username");

            });
            modelBuilder.Entity<Student>(student =>
            {
                student.ToTable("Student");
                student.HasKey("StudentId");

            });
            modelBuilder.Entity<IdentityRole>().HasData(
                new {Id="1",Name="Admin",NormalizedName="ADMIN"},
                new { Id = "2", Name = "Staff", NormalizedName = "STAFF" },
                 new { Id = "3", Name = "Student", NormalizedName = "STUDENT" }
                );

           

        }
    }
}
