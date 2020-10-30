using Microsoft.Extensions.Localization;
using MotelManagement.Students.Dto;
using MotelManagement.Entites;
using MotelManagement.Localization;
using MotelManagement.Permissions;
using Shared.Eto;
using System;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Distributed;
using System.Threading.Tasks;

namespace MotelManagement.Customers
{
    public class StudentAppService : BaseAppService<
        Student, Guid, CreateUpdateStudentDto, GetStudentDto, GetStudentForEditDto, GetStudentForInputDto>
    {
        protected override string CreatePolicyName { get; set; } = MotelManagementPermissions.Student.Create;
        protected override string DeletePolicyName { get; set; } = MotelManagementPermissions.Student.Delete;
        protected override string GetListPolicyName { get; set; } = MotelManagementPermissions.Student.Default;
        protected override string GetPolicyName { get; set; } = MotelManagementPermissions.Student.Default;
        protected override string UpdatePolicyName { get; set; } = MotelManagementPermissions.Student.Update;

        private readonly IStringLocalizer<MotelManagementResource> _localizers;
        private readonly IDistributedEventBus _distributedEventBus;
        public StudentAppService(IRepository<Student, Guid> repository,
            IStringLocalizer<MotelManagementResource> localizers,
            IDistributedEventBus distributedEventBus) : base(repository)
        {
            _localizers = localizers;
            _distributedEventBus = distributedEventBus;
        }

        protected override async Task<Student> Create(CreateUpdateStudentDto input)
        {
            var student = await base.Create(input);
            return student;
        }
    }
}
