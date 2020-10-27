using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace MotelManagement.Entites
{
    public class Student: FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public string Code { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
