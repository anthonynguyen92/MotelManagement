using MotelManagement.Enums;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace MotelManagement.Entites
{
    public class Motel : FullAuditedAggregateRoot<Guid>
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
        public IList<Student> Students { get; set; }
    }
}
