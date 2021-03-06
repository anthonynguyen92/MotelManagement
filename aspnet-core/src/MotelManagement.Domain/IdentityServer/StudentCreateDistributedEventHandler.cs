﻿using Microsoft.AspNetCore.Identity;
using Shared.Eto;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus.Distributed;
using Volo.Abp.Guids;
using Volo.Abp.Identity;

namespace MotelManagement.IdentityServer
{
    public class StudentCreateDistributedEventHandler : IDistributedEventHandler<StudentEto>, ITransientDependency
    {

        private readonly IdentityUserManager _userManager;
        private readonly IdentityRoleManager _roleManager;
        private readonly IGuidGenerator _guidGenerator;
        private readonly IDistributedEventBus _distributedEventBus;

        public StudentCreateDistributedEventHandler(IdentityUserManager userManager, IdentityRoleManager roleManager,
            IGuidGenerator guidGenerator, IDistributedEventBus distributedEventBus)
        {
            _distributedEventBus = distributedEventBus;
            _userManager = userManager;
            _roleManager = roleManager;
            _guidGenerator = guidGenerator;
        }

        public async Task HandleEventAsync(StudentEto eventData)
        {
            if (await _userManager.FindByNameAsync(eventData.StudentCode) != null)
            {
                return;
            }

            var user = new Volo.Abp.Identity.IdentityUser(
                _guidGenerator.Create(),
                eventData.StudentCode,
                eventData.Email,
                eventData.CurrentTenantId)
            {
                Name = eventData.Name,
            };

            var role = await _roleManager.FindByNameAsync("student");

            if (role != null)
                user.AddRole(role.Id);

            var password = "1q2w3E*";

            (await _userManager.CreateAsync(user, password)).CheckErrors();

            if (role == null)
                await _userManager.AddDefaultRolesAsync(user);
            await _distributedEventBus.PublishAsync(new NewStudentUserEto
            {
                Email = eventData.Email,
                Name = eventData.Name,
                Password = eventData.StudentCode,
                UserName = eventData.StudentCode
            });
        }
    }
}
