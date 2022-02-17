using AutoMapper;
using StudentAdminPortal.API.Datamodel;
using DomainModel=StudentAdminPortal.API.Domainmodel;

namespace StudentAdminPortal.API.Profiles
{
    public class StudentProfile: Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, DomainModel.Student>().ReverseMap();
            CreateMap<Gender, DomainModel.Gender>().ReverseMap();
            CreateMap<Address, DomainModel.Address>().ReverseMap();
        }
    }
}
