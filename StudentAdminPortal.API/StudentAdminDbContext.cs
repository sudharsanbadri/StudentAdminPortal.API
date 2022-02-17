using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.API.Datamodel;

namespace StudentAdminPortal.API
{
    public class StudentAdminDbContext: DbContext
    {
        public StudentAdminDbContext(DbContextOptions<StudentAdminDbContext> options):base(options)
        {

        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
