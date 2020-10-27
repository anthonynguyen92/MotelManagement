using Microsoft.Extensions.Localization;
using MotelManagement.Customers.Dto;
using MotelManagement.Entites;
using MotelManagement.Localization;
using MotelManagement.Permissions;
using Shared.Eto;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Distributed;

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

        private readonly IStringLocalizer<MotelManagementResource> _localizers;
        private readonly IDistributedEventBus _distributedEventBus;
        public CustomerAppService(IRepository<Customer, Guid> repository,
            IStringLocalizer<MotelManagementResource> localizers,
            IDistributedEventBus distributedEventBus) : base(repository)
        {
            _localizers = localizers;
            _distributedEventBus = distributedEventBus;
        }

        protected override async Task<Customer> Create(CreateUpdateCustomerDto input)
        {
            await CheckCreatePolicyAsync();

            var customer = await base.Create(input);
            await _distributedEventBus.PublishAsync(new CustomerEto(customer.Id,
               customer.Name, customer.Email, customer.Email, CurrentTenant.Id));
            return customer;
        }
    }
}
