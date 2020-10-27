using Volo.Abp.Modularity;

namespace MotelManagement
{
    [DependsOn(
        typeof(MotelManagementApplicationModule),
        typeof(MotelManagementDomainTestModule)
        )]
    public class MotelManagementApplicationTestModule : AbpModule
    {

    }
}