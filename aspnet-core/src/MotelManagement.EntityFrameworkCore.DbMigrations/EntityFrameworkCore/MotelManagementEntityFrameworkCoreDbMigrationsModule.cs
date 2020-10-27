using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace MotelManagement.EntityFrameworkCore
{
    [DependsOn(
        typeof(MotelManagementEntityFrameworkCoreModule)
        )]
    public class MotelManagementEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<MotelManagementMigrationsDbContext>();
        }
    }
}
