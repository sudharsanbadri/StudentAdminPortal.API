using StudentAdminPortal.API.Datamodel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Repository
{
    public interface IStudentRepository
    {
        public Task<List<Student>> GetAllStudentAsync();
    }
}
