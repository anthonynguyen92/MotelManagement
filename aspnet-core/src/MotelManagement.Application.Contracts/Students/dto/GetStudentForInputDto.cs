using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MotelManagement.Students.Dto
{
    public class GetStudentForInputDto:PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}
