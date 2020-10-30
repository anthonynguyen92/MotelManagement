using System;
using MotelManagement.Enums;
using Volo.Abp.Application.Dtos;

namespace MotelManagement.Students.Dto
{
    public class CreateUpdateStudentDto : EntityDto<Guid?>
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public DateTime Birthday { get; set; }

        public string Code { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
    }
}
