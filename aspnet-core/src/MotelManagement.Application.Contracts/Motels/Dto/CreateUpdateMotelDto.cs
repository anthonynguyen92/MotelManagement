using MotelManagement.Enums;
using System;
using Volo.Abp.Application.Dtos;

namespace MotelManagement.Motels.Dto
{
    public class CreateUpdateMotelDto : EntityDto<Guid?>
    {
        public string MotelCode { get; set; }
        public int Allotment { get; set; }
        public double Area { get; set; }
        public string StreetNumber { get; set; }
        public string Street { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
        public string Description { get; set; }
        public Guid CustomerId { get; set; }
        public Status Status { get; set; }
    }
}
