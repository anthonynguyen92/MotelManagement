using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MotelManagement.Data;
using Volo.Abp.DependencyInjection;

namespace MotelManagement.EntityFrameworkCore
{
    public class EntityFrameworkCoreMotelManagementDbSchemaMigrator
        : IMotelManagementDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreMotelManagementDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the MotelManagementMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<MotelManagementMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}