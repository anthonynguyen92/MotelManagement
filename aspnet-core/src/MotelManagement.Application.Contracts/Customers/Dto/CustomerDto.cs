using MotelManagement.Enums;
using System;
using Volo.Abp.Application.Dtos;

namespace MotelManagement.Customers.Dto
{
    public class CustomerDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public RolesCustomer Roles { get; set; }
    }
}
