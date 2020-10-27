using MotelManagement.Customers.Dto;
using MotelManagement.Entites;
using MotelManagement.Permissions;
using System;
using Volo.Abp.Domain.Repositories;

namespace MotelManagement.Customers
{
    public class CustomerAppService : BaseAppService<
        Customer, Guid, CreateUpdateCustomerDto, GetCustomerDto, GetCustomerForEditDto, GetCustomerForInputDto>
    {
        protected override string CreatePolicyName { get; set; } = MotelManagementPermissions.Customer.Create;
        protected override string DeletePolicyName { get; set; } = MotelManagementPermissions.Customer.Delete;
        protected override string GetListPolicyName { get; set; } = MotelManagementPermissions.Customer.Default;
        protected override string GetPolicyName { get; set; } = MotelManagementPermissions.Customer.Default;
        protected override string UpdatePolicyName { get; set; } = MotelManagementPermissions.Customer.Update;
        public CustomerAppService(IRepository<Customer, Guid> repository) : base(repository)
        {
        }
    }
}
