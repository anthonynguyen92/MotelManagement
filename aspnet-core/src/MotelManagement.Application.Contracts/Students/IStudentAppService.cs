using MotelManagement.Students.Dto;
using System;

namespace MotelManagement.Students
{
    public interface IStudentAppService : IBaseAppService<
        Guid, CreateUpdateStudentDto, GetStudentDto, GetStudentForEditDto, GetStudentForInputDto>
    {
    }
}
