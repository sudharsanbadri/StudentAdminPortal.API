using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.API.Datamodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentAdminDbContext _context;
        public StudentRepository(StudentAdminDbContext context)
        {
            this._context = context;
        }
        public async Task<List<Student>> GetAllStudentAsync()
        {
            return await this._context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }
    }
}
