using MotelManagement.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace MotelManagement.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(MotelManagementEntityFrameworkCoreDbMigrationsModule),
        typeof(MotelManagementApplicationContractsModule)
        )]
    public class MotelManagementDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
