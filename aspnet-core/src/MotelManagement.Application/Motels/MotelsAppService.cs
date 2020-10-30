using Microsoft.Extensions.Localization;
using MotelManagement.Motels.Dto;
using MotelManagement.Entites;
using MotelManagement.Localization;
using MotelManagement.Permissions;
using Shared.Eto;
using System;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Distributed;

namespace MotelManagement.Motels
{
    public class MotelAppService : BaseAppService<
        Motel, Guid, CreateUpdateMotelDto, GetMotelDto, GetMotelForEditDto, GetMotelForInputDto>
    {
        protected override string CreatePolicyName { get; set; } = MotelManagementPermissions.Motel.Create;
        protected override string DeletePolicyName { get; set; } = MotelManagementPermissions.Motel.Delete;
        protected override string GetListPolicyName { get; set; } = MotelManagementPermissions.Motel.Default;
        protected override string GetPolicyName { get; set; } = MotelManagementPermissions.Motel.Default;
        protected override string UpdatePolicyName { get; set; } = MotelManagementPermissions.Motel.Update;

        private readonly IStringLocalizer<MotelManagementResource> _localizers;
        private readonly IDistributedEventBus _distributedEventBus;
        public MotelAppService(IRepository<Motel, Guid> repository,
            IStringLocalizer<MotelManagementResource> localizers,
            IDistributedEventBus distributedEventBus) : base(repository)
        {
            _localizers = localizers;
            _distributedEventBus = distributedEventBus;
        }


    }
}
