using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MotelManagement.Motels.Dto
{
    public class GetMotelForInputDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }

    }
}
