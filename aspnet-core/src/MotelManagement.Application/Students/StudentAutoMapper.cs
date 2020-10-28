using AutoMapper;
using MotelManagement.Students.Dto;
using MotelManagement.Entites;

namespace MotelManagement.Students
{
    public class StudentAutoMapper : Profile
    {
        public StudentAutoMapper()
        {
            CreateMap<Customer, StudentDto>(MemberList.None);
            CreateMap<StudentDto, Student>(MemberList.None);
            CreateMap<Student, GetStudentDto>(MemberList.None);
            CreateMap<Student, GetStudentForEditDto>(MemberList.None);
            CreateMap<CreateUpdateStudentDto, Student>(MemberList.None);
        }
    }
}
